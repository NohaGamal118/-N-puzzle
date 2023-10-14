using System;
using System.Collections.Generic;
using System.Text;



namespace Algo_project
{
    class node_of_tree
    {
        public int[,] borad;
        public List<node_of_tree> adj;
        public int index0i;
        public int index0j;
        public node_of_tree parent;

        public int Level;
        public int F;
        public int H;
        public int N;
        public node_of_tree(int[,] tmp, int N, int ii, int jj, int H, int Level)
        {
            borad = tmp;
            this.N = N;
            this.H = H;
            this.Level = Level;
            this.index0i = ii;
            this.index0j = jj;
            parent = null;
            adj = new List<node_of_tree>();
        }
        public node_of_tree(int[,] tmp, int N, int ii, int jj, int H, int indexPi, int indexPj, int Level, node_of_tree parent)
        {
            borad = tmp;
            this.N = N;
            this.parent = parent;
            this.index0i = ii;
            this.index0j = jj;
            this.Level = Level;
            this.H = H;
            adj = new List<node_of_tree>();
        }
        int ham(node_of_tree tmp, int n, int iOfLastCell, int jOfLastCell)
        {
            int hamming = tmp.H;
            if (((tmp.index0i * tmp.N + tmp.index0j) + 1) == n)
            {
                hamming--;
            }
            if (((iOfLastCell * tmp.N + jOfLastCell) + 1) == n)
            {
                hamming++;
            }
            return hamming;
        }
        int manhatten(node_of_tree tmp, int n, int iOfLastCell, int jOfLastCell)
        {
            int remainder = (n - 1) % tmp.N;
            int quotient = (n - 1) / tmp.N;
            int Manhatten = tmp.H,
            right_colume = remainder,
            right_row = quotient;
            if (((iOfLastCell * tmp.N + jOfLastCell) + 1) == n)
            {
                Manhatten++;
            }
            else
            {
                Manhatten -= Math.Abs(right_row - iOfLastCell) + Math.Abs(right_colume - jOfLastCell);
                Manhatten += Math.Abs(right_row - tmp.index0i) + Math.Abs(right_colume - tmp.index0j);
            }
            return Manhatten;
        }
        void swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }
        public bool issame(node_of_tree tmp, int i, int j)
        {
            if (tmp.parent != null && i == tmp.parent.index0i && j == tmp.parent.index0j)
            {
                return true;
            }
            return false;
        }



        public void getadj()
        {
            node_of_tree parent = this;
            int hamming = 0;
            int Manhatten = 0;
            int heuristic_value = 0;



            if (index0i > 0)
            {
                int[,] temp = new int[N, N];
                Array.Copy(borad, temp, borad.Length);
                int nn = temp[index0i - 1, index0j];
                hamming = ham(parent, nn, index0i - 1, index0j);
                Manhatten = manhatten(parent, nn, index0i - 1, index0j);
                // heuristic_value = hamming;
                heuristic_value = Manhatten;
                swap(ref temp[index0i, index0j], ref temp[index0i - 1, index0j]);
                node_of_tree t1 = new node_of_tree(temp, N, index0i - 1, index0j, heuristic_value, index0i, index0j, parent.Level + 1, parent);
                if (!issame(parent, index0i - 1, index0j))
                {
                    adj.Add(t1);
                }
            }



            if (index0i + 1 < N)
            {
                int[,] temp = new int[N, N];
                Array.Copy(borad, temp, borad.Length);
                int nn = temp[index0i + 1, index0j];
                hamming = ham(parent, nn, index0i + 1, index0j);
                Manhatten = manhatten(parent, nn, index0i + 1, index0j);
                //heuristic_value = hamming;
                heuristic_value = Manhatten;



                swap(ref temp[index0i + 1, index0j], ref temp[index0i, index0j]);



                node_of_tree t2 = new node_of_tree(temp, N, index0i + 1, index0j, heuristic_value, index0i, index0j, parent.Level + 1, parent);



                if (!issame(parent, index0i + 1, index0j))
                {
                    adj.Add(t2);
                }



            }



            if (index0j > 0)
            {
                int[,] temp = new int[N, N];
                Array.Copy(borad, temp, borad.Length);
                int nn = temp[index0i, index0j - 1];
                hamming = ham(parent, nn, index0i, index0j - 1);
                Manhatten = manhatten(parent, nn, index0i, index0j - 1);
                // heuristic_value = hamming;
                heuristic_value = Manhatten;
                swap(ref temp[index0i, index0j], ref temp[index0i, index0j - 1]);



                node_of_tree t3 = new node_of_tree(temp, N, index0i, index0j - 1, heuristic_value, index0i, index0j, parent.Level + 1, parent);



                if (!issame(parent, index0i, index0j - 1))
                {
                    adj.Add(t3);
                }



            }
            if (index0j + 1 < N)
            {
                int[,] temp = new int[N, N];
                Array.Copy(borad, temp, borad.Length);
                int nn = temp[index0i, index0j + 1];
                hamming = ham(parent, nn, index0i, index0j + 1);
                Manhatten = manhatten(parent, nn, index0i, index0j + 1);
                // heuristic_value = hamming;
                heuristic_value = Manhatten;
                swap(ref temp[index0i, index0j], ref temp[index0i, index0j + 1]);



                node_of_tree t4 = new node_of_tree(temp, N, index0i, index0j + 1, heuristic_value, index0i, index0j, parent.Level + 1, parent);
                if (!issame(parent, index0i, index0j + 1))
                {
                    adj.Add(t4);
                }



            }
        }



    }
}