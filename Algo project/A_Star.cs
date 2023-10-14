using System;
using System.Collections.Generic;
using System.Text;



namespace Algo_project
{
    class A_Star
    {
        public void printpath(int[,] arr, int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }



        public bool getpath(node_of_tree start)
        {
            if (start == null)
            {
                return false;
            }



            getpath(start.parent);
            printpath(start.borad, start.N);
            return true;
        }
        static priorityqueue pq;
        public node_of_tree astar(node_of_tree s)
        {
            pq = new priorityqueue();
            node_of_tree root = s;
            pq.enqueue(root);
            while (!pq.empty())
            {
                node_of_tree top = pq.dequeue();
                if (top.H == 0)
                {
                    Console.WriteLine(top.Level);
                    return top;
                }
                top.getadj();



                for (int i = 0; i < top.adj.Count; i++)
                {
                    node_of_tree front = top.adj[i];
                    front.F = front.Level + front.H;
                    pq.enqueue(front);
                }



            }
            return null;
        }
    }
}