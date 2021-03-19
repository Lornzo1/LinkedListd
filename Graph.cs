using System;
using System.Collections.Generic;
using System.Text;
// Goal: error messages implemented
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
    }
}
