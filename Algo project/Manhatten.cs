using System;
using System.Collections.Generic;
using System.Text;

namespace Algo_project
{
    class manhatten
    {
        int f = -1;
        public int Manhattan(int n, int[,] puzzle)
        {
            int c = 0;
            int row_or_col = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int arr = puzzle[i, j];
                    if (arr == 0)
                    {
                        f = arr;
                        continue;
                    }
                    if (arr != ((i * n + j) + 1))
                    {
                        int tx = (arr - 1) / n;
                        int ty = (arr - 1) % n;
                        int dx = i - tx;
                        int dy = j - ty;
                        c += Math.Abs(dx) + Math.Abs(dy);
                    }
                }
            }

            return c;
        }
    }
}