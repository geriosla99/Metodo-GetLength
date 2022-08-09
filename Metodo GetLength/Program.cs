using System;

namespace Metodo_GetLength
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables 
            int i;
            int j;

            double[,] ventas2D = new double[4, 3] { { 100, 120, 205},
                                                    { 115, 196, 300},
                                                    { 130, 180, 281},
                                                    { 157, 172, 245}};

            //Mostramos los valores

            //Console.WriteLine(ventas2D.GetLength(1));

            for (i = 0; i < ventas2D.GetLength(0); i++)
            {
                Console.WriteLine("fila {0}", i);
                for (j = 0; j < ventas2D.GetLength(1); j++)
                {
                    Console.WriteLine(ventas2D[i, j]);
                }
            }
        }
    }
}
