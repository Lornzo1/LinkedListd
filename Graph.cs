using Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace LinkedLists
{
    class Graph
    {
        protected readonly int NumVertices;
        protected readonly bool Directed;

        int[,] Matrix;
        public Graph(int Vertices, bool directed = false)
        {
            NumVertices = Vertices;
            Directed = directed;
            GenerateEmptyMatrix(Vertices);
        }

        private void GenerateEmptyMatrix(int numVertices)
        {
            Matrix = new int[numVertices, numVertices];
            for (int row = 0; row < numVertices; row++)
            {
                for (int col = 0; col < numVertices; col++)
                {
                    Matrix[row, col] = 0;
                }
            }
        }
        public void AddEdge(int v1, int v2, int weight = 1)
        {
            if (v1 >= NumVertices || v2 >= NumVertices || v1 < 0 || v2 < 0)
                throw new ArgumentOutOfRangeException("Vertices are out of bounds");

            if (weight < 1) throw new ArgumentException("Weight cannot be less than 1");

            Matrix[v1, v2] = weight;

            if (!Directed) Matrix[v2, v1] = weight;
        }
        public IEnumerable<int> GetAdjacentVertices(int v)
        {
            if (v < 0 || v >= NumVertices) throw new ArgumentOutOfRangeException("Cannot access vertex");

            List<int> adjacentVertices = new List<int>();
            for (int i = 0; i < NumVertices; i++)
            {
                if (Matrix[v, i] > 0)
                    adjacentVertices.Add(i);
            }
            return adjacentVertices;
        }
        public int GetEdgeWeight(int v1, int v2)
        {
            return Matrix[v1, v2];
        }
        // for an unweighted path
        public List<int> BreadthFirstTraversal(int start)
        {
            bool[] visited = new bool[NumVertices];
            for (int i = 0; i < NumVertices; i++)
                visited[i] = false;

            queue<int> myQueue = new queue<int>(NumVertices);
            List<int> path = new List<int>();
            visited[start] = true;
            myQueue.Push(start);

            while (myQueue.head != 0)
            {
                int node = myQueue.Dequeue();

                IEnumerable<int> adj = GetAdjacentVertices(start);

                foreach (var val in adj)
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        myQueue.Push(val);
                        path[val] = node;
                    }
                }
            }
            return path;
        }
        public List<int> DepthFirstTraversal(int start)
        {

        }
    }
}
