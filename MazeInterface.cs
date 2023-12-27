using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Maze_Solver.Library;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Maze_Solver
{
    public partial class MazeInterface : Form
    {
        private bool mazeLoaded = false;
        private MazeOptics model;
        private int MazeSize;

        public MazeInterface()
        {
            InitializeComponent();
            SolveMazeButton.Enabled = false;
        }

        public void LoadMazeButton_Click(object sender, EventArgs e)
        {
            MazeLayout.Invalidate();
            SolutionProgressBar.Value = 0;
            FinishCord.Text = "";
            SolutionValue.Text = "0";

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a File";
            openFileDialog.Filter = "All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                MazeOptics mazeModel = new MazeOptics(selectedFileName);

                if (mazeModel.LoadedSuccessfully && mazeModel.Start != null && mazeModel.Finish != null)
                {
                    model = mazeModel;
                    mazeLoaded = true;                  
                    MazeLayout_Paint(MazeLayout.CreateGraphics(), MazeLayout.Width, MazeLayout.Height);
                    SolveMazeButton.Enabled = true;
                    MazeSize = model.maze_col * model.maze_row;
                    SizeValue.Text = $"{MazeSize} Cells";
                    StartCord.Text = $"X-{model.Start[0]+1} Y-{model.Start[1]+1}";               
                }
                else
                {
                    MessageBox.Show(" Failed to load the maze.\n check if the Start 'S' and Exit 'E' \n are properly identified");
                }
            }
        }

        public void SolveMazeButton_Click(object sender, EventArgs e)
        {
            Solution_BFS solved = new Solution_BFS(model);

            if (model.solved)
            {
                LoadMazeButton.Enabled = false;
                PaintSolutionPath();
                SolveMazeButton.Enabled = false;
                SolutionProgressBar.Maximum = model.solution.Count;
            }
            else { MessageBox.Show(" Exit 'E' is unreachable"); }
        }


        private void MazeLayout_Paint(Graphics g, int pictureBoxWidth, int pictureBoxHeight)
        {
            List<string> maze = model.maze;

            for (int row = 0; row < maze.Count; row++)
            {
                for (int col = 0; col < maze[row].Length; col++)
                {
                    char cell = maze[row][col];

                    // Calculate the position for the current cell
                    int x = col * (pictureBoxWidth / maze[row].Length);
                    int y = row * (pictureBoxHeight / maze.Count);

                    // Draw walls as rectangles
                    if (cell == '#')
                    {
                        g.FillRectangle(Brushes.Black, x, y, pictureBoxWidth / maze[row].Length, pictureBoxHeight / maze.Count);
                    }
                    // Draw open paths as spaces
                    else if (cell == '.')
                    {
                        g.FillRectangle(Brushes.White, x, y, pictureBoxWidth / maze[row].Length, pictureBoxHeight / maze.Count);
                    }
                    // Draw the start and exit with different colors
                    else if (cell == 'S')
                    {
                        g.FillRectangle(Brushes.Blue, x, y, pictureBoxWidth / maze[row].Length, pictureBoxHeight / maze.Count);
                    }
                    else if (cell == 'E')
                    {
                        g.FillRectangle(Brushes.Red, x, y, pictureBoxWidth / maze[row].Length, pictureBoxHeight / maze.Count);
                    }
                }
            }
        }
        private async void PaintSolutionPath()
        {
            List<string> maze = model.maze;
            int z = 1;

            using (Graphics g = MazeLayout.CreateGraphics())
            {
                // Highlight the path cells in a different color (e.g., green)
                foreach ((int row, int col) in model.solution)
                {
                    // Skip painting over the start and finish cells
                    if ((row, col) == (model.Start[0], model.Start[1]) || (row, col) == (model.Finish[0], model.Finish[1]))
                        continue;

                    // Calculate the position for the current cell
                    int x = col * (MazeLayout.Width / maze[row].Length);
                    int y = row * (MazeLayout.Height / maze.Count);

                    // Draw the solution path cells
                    g.FillRectangle(Brushes.Green, x, y, MazeLayout.Width / maze[row].Length, MazeLayout.Height / maze.Count);
                    await Task.Delay(20);
                 
                    z++;
                    SolutionProgressBar.Value = z+1;
                    SolutionValue.Text = $"{z}";
                }
                FinishCord.Text = $"X-{model.Finish[0] + 1} Y-{model.Finish[1] + 1}";
                LoadMazeButton.Enabled = true;
            }
        }

    }
}
