using System;
using System.Collections.Generic;

namespace Maze_Solver.Library
{
    public class Solution_BFS
    {
        public MazeOptics Model;
        public List<(int, int)> Solution { get; }

        public Solution_BFS(MazeOptics maze)
        {
            Model = maze;
            FindShortestPath();
        }

        public void FindShortestPath()
        {
            // Mark cells as visited
            bool[,] visited = new bool[Model.maze_row, Model.maze_col];

            // Store predecessors (x, y)
            int[,,] predecessors = new int[Model.maze_row, Model.maze_col, 2];

            // Queue to perform BFS
            Queue<int[]> positionQueue = new Queue<int[]>();

            // Enqueue the starting position
            positionQueue.Enqueue(Model.Start);
            visited[Model.Start[0], Model.Start[1]] = true;

            // Perform BFS
            while (positionQueue.Count != 0)
            {
                int[] current = positionQueue.Dequeue();
                int x = current[0];
                int y = current[1];

                // Check if we reached the exit 'E'
                if (Model.maze[x][y] == 'E' || Model.maze[x][y] == 'e')
                {
                    ReconstructPath(predecessors, Model.Start, current);
                    Model.solved = true;
                    return;
                }

                // Explore neighbors (up, down, left, right)
                Explore(x - 1, y, positionQueue, visited, predecessors, current); // Up
                Explore(x + 1, y, positionQueue, visited, predecessors, current); // Down
                Explore(x, y - 1, positionQueue, visited, predecessors, current); // Left
                Explore(x, y + 1, positionQueue, visited, predecessors, current); // Right
            }

            // No path to the exit 'E' found
            Model.solved = false;
        }

        private void Explore(int x, int y, Queue<int[]> positionQueue, bool[,] visited, int[,,] predecessors, int[] current)
        {
            // Check if the new position is within bounds and not visited
            if (x >= 0 && x < Model.maze_row && y >= 0 && y < Model.maze_col && (Model.maze[x][y] == '.' || Model.maze[x][y] == 'E' || Model.maze[x][y] == 'e') && !visited[x, y])
            {
                // Enqueue the new position
                positionQueue.Enqueue(new int[] { x, y });

                // Mark the new position as visited
                visited[x, y] = true;

                // Store the predecessor's coordinates
                predecessors[x, y, 0] = current[0];
                predecessors[x, y, 1] = current[1];
            }
        }

        private void ReconstructPath(int[,,] predecessors, int[] start, int[] end)
        {
            int x = end[0];
            int y = end[1];

            // Reconstruct the path by backtracking from the exit to the start
            while (x != start[0] || y != start[1])
            {
                // Insert the current cell at the beginning of the path
                Model.solution.Insert(0, (x, y));

                // Update the current coordinates to the predecessor's coordinates
                int tempX = x;
                x = predecessors[x, y, 0];
                y = predecessors[tempX, y, 1];
            }

            // Insert the start cell at the beginning of the path
            Model.solution.Insert(0, (start[0], start[1]));

        }
    }
}
