using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Solver.Library
{
    public class MazeOptics
    {

        public List<string> maze { get; set; } = new List<string>();
        public int maze_row { get; set; }
        public int maze_col { get; set; }
        public int[] Start { get; set; }
        public int[] Finish { get; set; }
        public bool LoadedSuccessfully { get; internal set; }

        public List<(int, int)> solution = new List<(int, int)>();
        public bool solved { get; set; }

        public void FindStartFinish(List<string> maze)
        {

            foreach (string rows in maze)
            {
                for (int row = 0; row < maze.Count; row++)
                {
                    for (int col = 0; col < maze[row].Length; col++)
                    {
                        char cell = maze[row][col];

                        // Check if the cell is the start position
                        if (cell == 'S' || cell == 's')
                        {
                            Start = new int[] { row, col };
                        }
                        // Check if the cell is the finish position
                        else if (cell == 'E' || cell == 'e')
                        {
                            Finish = new int[] { row, col };
                        }
                    }
                }

            }

        }
        public MazeOptics(string path)
        {
            try
            {
                maze = new List<string>(File.ReadAllLines(path));
                maze_col = maze[0].Length;
                maze_row = maze.Count;
                LoadedSuccessfully = true;
                FindStartFinish(maze);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load maze: {ex.Message}");
                LoadedSuccessfully = false;
            }
        }

    }


}
