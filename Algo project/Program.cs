using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using Algo_project;

namespace Algo_project
{
    class Program
    {
        static void Reading_file_and_check_it(FileStream file, StreamReader s)
        {
            check t = new check();
            s = new StreamReader(file);
            string line = s.ReadLine();
            string[] s2;
            s2 = line.Split(' ');
            int n = int.Parse(s2[0]);
            int[] b = new int[n * n];
            while (s.Peek() != -1)
            {
                int cont = 0;
                for (int i = 0; i < n; i++)
                {
                    line = s.ReadLine();
                    s2 = line.Split(' ');



                    for (int j = 0; j < n; j++)
                    {
                        b[cont] = int.Parse(s2[j]);
                        cont++;
                    }
                }
            }
            int i0 = -1, j0 = -1;
            int[,] q = new int[n, n];
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    q[i, j] = b[counter];
                    counter++;
                }
            }



            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (q[i, j] == 0)
                    {
                        i0 = i;
                        j0 = j;
                    }
                }
            }
            //t.isSolvable(n, b);
            Stopwatch stopwatch = new Stopwatch();
            // Begin timing
            stopwatch.Start();



            System.Threading.Thread.Sleep(500);
            if (t.check_sol(n, b, q))
            {
                Console.WriteLine("Solvable");
                Console.Write("Total # of movements = ");
                int cc = 0;
                manhatten m = new manhatten();
                int m_value = m.Manhattan(n, q);
                cc = m_value;
                Hamming h = new Hamming();
                int[,] p = h.goal(n);
                int h_value = h.hamming(n, q, p);
                node_of_tree n1 = new node_of_tree(q, n, i0, j0, cc, 0);
                A_Star a = new A_Star();
                node_of_tree n2 = a.astar(n1);
                if (n == 3)
                {
                    a.getpath(n2);
                }

            }

            else
            {
                Console.WriteLine("Not Solvable");
            }

            // Stop timing
            stopwatch.Stop();

            Console.WriteLine("Time : {0}", stopwatch.Elapsed);

            s.Close();
            file.Close();
        }
        //main
        static void Main(string[] args)
        {
            
            check t = new check();
            StreamReader s;
            FileStream file;
            TextReader origConsole = Console.In;
            char rr = 'y';
            do
            {
                Console.WriteLine("N puzzle:\n[1] Sample test cases\n[2] Complete testing\n");
                Console.Write("\nEnter your choice [1-2]: ");
                char choice = (char)Console.ReadLine()[0];


                switch (choice)
                {
                    case '1':
                        {
                            Console.Write("Choice the Puzzle[1-11]: ");
                            string c = (string)Console.ReadLine();
                            switch (c)
                            {
                                case "1":
                                    {
                                        file = new FileStream("..//Debug/Sample/Sample Test/Solvable Puzzles/8 Puzzle (1).txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);

                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }

                                case "2":
                                    {
                                        file = new FileStream("..//Debug/Sample/Sample Test/Solvable Puzzles/8 Puzzle (2).txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);

                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                                case "3":
                                    {
                                        file = new FileStream("..//Debug/Sample/Sample Test/Solvable Puzzles/8 Puzzle (3).txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);

                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                                case "4":
                                    {
                                        file = new FileStream("..//Debug/Sample/Sample Test/Solvable Puzzles/15 Puzzle - 1.txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);



                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                                case "5":
                                    {
                                        file = new FileStream("..//Debug/Sample/Sample Test/Solvable Puzzles/24 Puzzle 1.txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);



                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                                case "6":
                                    {
                                        file = new FileStream("..//Debug/Sample/Sample Test/Solvable Puzzles/24 Puzzle 2.txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);



                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                                case "7":
                                    {
                                        file = new FileStream("..//Debug/Sample/Sample Test/Unsolvable Puzzles/8 Puzzle - Case 1.txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);



                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                                case "8":
                                    {
                                        file = new FileStream("..//Debug/Sample/Sample Test/Unsolvable Puzzles/8 Puzzle(2) - Case 1.txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);



                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                                case "9":
                                    {
                                        file = new FileStream("..//Debug/Sample/Sample Test/Unsolvable Puzzles/8 Puzzle(3) - Case 1.txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);



                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                                case "10":
                                    {
                                        file = new FileStream("..//Debug/Sample/Sample Test/Unsolvable Puzzles/15 Puzzle - Case 2.txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);



                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                                case "11":
                                    {
                                        file = new FileStream("..//Debug/Sample/Sample Test/Unsolvable Puzzles/15 Puzzle - Case 3.txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);



                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                            }

                            break;
                        }
                    case '2':
                        {
                            Console.Write("Choice the Puzzle[1-13]: ");
                            string c = (string)Console.ReadLine();
                            switch (c)
                            {
                                case "1":
                                    {
                                        file = new FileStream("..//Debug/Complete/Complete Test/Solvable puzzles/Manhattan & Hamming/50 Puzzle.txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);

                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                                case "2":
                                    {
                                        file = new FileStream("..//Debug/Complete/Complete Test/Solvable puzzles/Manhattan & Hamming/99 Puzzle - 1.txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);



                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                                case "3":
                                    {
                                        file = new FileStream("..//Debug/Complete/Complete Test/Solvable puzzles/Manhattan & Hamming/99 Puzzle - 2.txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);

                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                                case "4":
                                    {
                                        file = new FileStream("..//Debug/Complete/Complete Test/Solvable puzzles/Manhattan & Hamming/9999 Puzzle.txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);

                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                                case "5":
                                    {
                                        file = new FileStream("..//Debug/Complete/Complete Test/Solvable puzzles/Manhattan Only/15 Puzzle 1.txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);

                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                                case "6":
                                    {
                                        file = new FileStream("..//Debug/Complete/Complete Test/Solvable puzzles/Manhattan Only/15 Puzzle 3.txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);

                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                                case "7":
                                    {
                                        file = new FileStream("..//Debug/Complete/Complete Test/Solvable puzzles/Manhattan Only/15 Puzzle 4.txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);

                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                                case "8":
                                    {
                                        file = new FileStream("..//Debug/Complete/Complete Test/Solvable puzzles/Manhattan Only/15 Puzzle 5.txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);

                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                                case "9":
                                    {
                                        file = new FileStream("..//Debug/Complete/Complete Test/Unsolvable puzzles/15 Puzzle 1 - Unsolvable.txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);

                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                                case "10":
                                    {
                                        file = new FileStream("..//Debug/Complete/Complete Test/Unsolvable puzzles/99 Puzzle - Unsolvable Case 1.txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);

                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                                case "11":
                                    {
                                        file = new FileStream("..//Debug/Complete/Complete Test/Unsolvable puzzles/99 Puzzle - Unsolvable Case 2.txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);

                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                                case "12":
                                    {
                                        file = new FileStream("..//Debug/Complete/Complete Test/Unsolvable puzzles/9999 Puzzle.txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);

                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                                case "13":
                                    {
                                        file = new FileStream("..//Complete/Complete Test/V. Large test case/TEST.txt", FileMode.Open, FileAccess.Read);
                                        s = new StreamReader(file);

                                        Reading_file_and_check_it(file, s);
                                        break;
                                    }
                            }
                            break;
                        }

                }
                Console.WriteLine("Do you want to coniu?.. ");
                rr = (char)Console.ReadLine()[0];
            } while (rr == 'y');

        }
    }
}
