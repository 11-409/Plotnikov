using FiboMatrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FiboMatrix
{
    class Matrix
    {
        public static int FibbMatrix(int deg)
        {
            int[,] defaultMatrix = { { 1, 1 }, { 1, 0 } };

            if (deg == 0)
            {
                return 0;
            }
            if (deg == 1)
            {
                return 1;
            }

            int[,] finalMatrix = FindMatrix(deg - 1, defaultMatrix);

            return finalMatrix[0, 0];
        }

        public static int[,] FindMatrix(int deg, int[,] randomMatrix)
        {
            int[,] finalMatrix = { { 1, 0 }, { 0, 1 } }; //Единичная матрица
            while (deg > 0)
            {
                if (deg % 2 == 1)
                {
                    finalMatrix = Multiplication(finalMatrix, randomMatrix);
                }

                deg = deg / 2;
                randomMatrix = PowMatrixOnce(randomMatrix);
            }

            return finalMatrix;
        }

        public static int[,] Multiplication(int[,] firstMatrix, int[,] secondMatrix)
        {
            int[,] finalMatrix = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int n = 0; n < 2; n++)
                    {
                        finalMatrix[i, j] += firstMatrix[i, n] * secondMatrix[n, j];
                    }
                }
            }
            return finalMatrix;
        }
        public static int[,] PowMatrixOnce(int[,] matrix)
        {
            int[,] finalMatrix = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int n = 0; n < 2; n++)
                    {
                        finalMatrix[i, j] += matrix[i, n] * matrix[n, j];
                    }
                }
            }
            return finalMatrix;
        }
    }
}