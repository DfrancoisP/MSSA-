using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixZeros
{
 

        class Program
        {
            static void Main(string[] args)
            {

                int[,] arr = new int[3, 3] {
                                {1,2,1},
                                {3,0,2},
                                {5,6,8}
                                };

                SetZero(arr);

                PrintArr(arr);

            }
            public static void PrintArr(int[,] arr)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

            static int[,] SetZero(int[,] matrix)
            {
                int rows = matrix.GetLength(1);
                int col = matrix.GetLength(0);
                bool[] rowHasZero = new bool[rows];
                bool[] colHasZero = new bool[col];

            //check the whole array and see if a zero exists
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        rowHasZero[i] = true;
                        colHasZero[j] = true;
                    }
                }

            }

            //check to see if the is a zero in any row 
            for (int i = 0; i < rows; i++)
                {
                    if (rowHasZero[i])
                    {
                        for (int j = 0; j < col; j++)
                        {
                            matrix[i, j] = 0;
                        }

                    }

                }
                //check is first column has has a zero

                for (int j = 0; j < col; j++)
                {
                    if (colHasZero[j])
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            matrix[i, j] = 0;
                        }

                    }

                }



                return matrix;
            }




        
    }
}

