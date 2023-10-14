using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_project
{
    class Hamming
    {
        public int hamming(int n, int[,] puzzle, int[,] goal)
        {
            int calcHamming = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (puzzle[i, j] == 0)
                    {
                        continue;
                    }
                    int tx = (puzzle[i, j] - 1) / n;
                    int ty = (puzzle[i, j] - 1) % n;
                    if (tx != i || ty != j)
                    {
                        calcHamming++;
                    }

                }
            }
            return calcHamming;
        }
        public int[,] goal(int n)
        {
            int[,] m = new int[n, n];
            int count = 0;
            int zeroindex = n - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != zeroindex && j != zeroindex)
                    {
                        m[i, j] = count + 1;
                        count++;
                    }
                    else if (i == zeroindex && j == zeroindex)
                    {
                        m[i, j] = 0;
                    }
                }
            }
            return m;
        }
    }
}
