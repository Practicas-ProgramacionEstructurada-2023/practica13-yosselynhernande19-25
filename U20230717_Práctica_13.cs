using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Arreglo bidimencional
            int[,] matrizBidimencional = new int [3, 4];

            //Inicializacion de arreglo bidimensional
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    matrizBidimencional[fila, columna] = fila * 4 + columna + 1;
                }
            }

            //Imprimir el arreglo bidimensional
            Console.WriteLine("\nArreglo Bidimencional: ");
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    Console.Write(matrizBidimencional[fila, columna] + "\t");
                }
                Console.WriteLine();
            }

            ////////////////////////////////////////////////////////////////////////////////////////
            
            //Areglo tridimensional
            int[,,] matrizTridimencional = new int[3, 3, 4];

            //Inicializacion del arreglo tridimensional
            for (int caja = 0; caja < 3; caja++)
            {
                for (int fila = 0; fila < 3; fila++)
                {
                    for (int columna = 0; columna < 4; columna++)
                    {
                      matrizTridimencional[caja, fila, columna] = caja * 12 + fila * 4 + columna + 1;  
                    }
                }
            }

            //Imprimir el arreglo tridimensional
            Console.WriteLine("\nArrelo Tridimencional: ");
              for (int caja = 0; caja < 3; caja++)
            {
                for (int fila = 0; fila < 3; fila++)
                {
                    for (int columna = 0; columna < 4; columna++)
                    {
                        Console.Write(matrizTridimencional[caja, fila, columna] + "\t");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}