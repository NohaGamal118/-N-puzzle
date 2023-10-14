using System;
using System.Collections.Generic;
using System.Text;

namespace Algo_project
{
    class check
    {

        public int get_count(int[] arr)
        {
            int inv_count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == 0)
                    {
                        continue;
                    }

                    //Value 0 is used for empty space
                    else if (arr[i] > arr[j])
                    {
                        inv_count++;
                    }
                }
            }
            return inv_count;
        }

        public bool check_sol(int n, int[] puzzle, int[,] q)
        {
            int kk = -1;
            int y = -1;
            for (int i = 0; i < puzzle.Length - 1; i++)
            {
                if (puzzle[i] == 0)
                {
                    kk = i / n;
                    y = i % n;
                    continue;
                }

            }

            if (n % 2 != 0 && get_count(puzzle) % 2 == 0)
            {

                return true;
            }
            else if (n % 2 == 0 && get_count(puzzle) % 2 != 0 && kk % 2 == 0)
            {

                return true;
            }
            else if (n % 2 == 0 && get_count(puzzle) % 2 == 0 && kk % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}