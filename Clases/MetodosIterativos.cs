using System;
using System.Windows.Forms;

namespace MN_U3ProyectoIndividual.Clases
{
    internal class MetodosIterativos
    {
        //El sistema es 
        //    |3x -  y - z =1|
        //    |-x + 3y + z =3|   
        //    |2x + y + 4z =7|
        //    

        ////////Arreglo 3x3 con los coeficientes del sistema
        //int[,] A = new int[3, 3] { { 3, -1, -1 }, { -1, 3, 1 }, { 2, 1, 4 } };
        ////Arreglo con los términos independientes
        //int[] b = new int[3] { 1, 3, 7 };
        ////Arreglo con las soluciones iniciales
        //double[] x = new double[3] { 0, 0, 0 };
        ////arreglo con las soluciones calculadas
        ////double[] XSolved = x;

        //El sistema es 
        //    |6x + 2y + z =22|
        //    |-x + 8y + 2z=30|   
        //    | x - y + 6z =23|
        // 
        // x=2, y=3, z= 4

        //Arreglo 4x4 con los coeficientes del sistema
        //int[,] A = new int[3, 3] { { 6, 2, 1 }, { -1, 8, 2 }, { 1, -1, 6 } };
        ////Arreglo con los términos independientes
        //int[] b = new int[3] { 22, 30, 23 };
        ////Arreglo con las soluciones iniciales
        //double[] x = new double[3] { 0, 0, 0 };

        //El sistema es 
        //    |w - 2x + 2y - 3z =15|
        //    |3w + 4x - y + z=-6|   
        //    | 2w - 3x + 2y  - z=17|
        //    | w + x - 3y - 2z = -7 |
        //// 

        ////Arreglo 4x4 con los coeficientes del sistema
        //int[,] A = new int[4, 4] { { 1, -2, 2, 3 }, { 3, 4, -1, 1 }, { 2, -3, 2, -1 }, { 1, 1, -3, -2 } };
        ////Arreglo con los términos independientes
        //int[] b = new int[4] { 15, -6, 17, -7 };
        ////Arreglo con las soluciones iniciales
        //double[] x = new double[4] { 0, 0, 0, 0 };
        public void Jacobi(double[,] A, double[] b, double[] x, int iteraciones, DataGridView DataGridJacobi)
        {
            //arreglo con las soluciones calculadas
            double[] XSolved = x;

            //double Error = 0.1, ErrorC = 0;
            double Sumatoria;

            x = new double[3] { 0, 0, 0 };
            for (int l = 1; l < iteraciones; l++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Sumatoria = 0;
                    for (int j = 0; j <3; j++)
                    {
                        if (j != i)
                        {
                            Sumatoria += A[i, j] * x[j];
                        }

                    }
                    XSolved[i] = (b[i] - Sumatoria) / A[i, i];
                }
                //Console.Write("\nIteración #" + l + ": [");
                //for (int i = 0; i < XSolved.Length; i++)
                //{
                //    Console.Write(XSolved[i] + ",");
                //}
                //Console.Write("]");
                //Console.WriteLine();
                MostrarTabla(l, XSolved, DataGridJacobi);
                x = XSolved;

            }
        }

        public void GaussSeidel(double[,] a, double[] B, double[] X, int itera, DataGridView DataGridGaussSeidel)
        {
            //arreglo con las soluciones calculadas
            double[] Solved = X;

            //double Error = 0.1, ErrorC = 0;
            double Sumatoria1, Sumatoria2;


            for (int l = 1; l < itera; l++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Sumatoria1 = 0;
                    Sumatoria2 = 0;
                    //for (int j = i+1; j < dim; j++)
                    //{
                    //        Sumatoria2 += A[i, j] * x[j];

                    //}
                    for (int j = 0; j < 3; j++)
                    {
                        if (j != i)
                            Sumatoria1 += a[i, j] * Solved[j];

                    }

                    Solved[i] = (B[i] - Sumatoria1 - Sumatoria2) / a[i, i];

                }
                MostrarTabla(l, Solved, DataGridGaussSeidel);
            }
        }
        public void MostrarTabla(int iteracion, double [] xSolved, DataGridView DataGrid)
        {
            object []rows = new object [] { iteracion, xSolved[0], xSolved[1], xSolved[2] };
            DataGrid.Rows.Add(rows);
        }
    }
      
    
}
