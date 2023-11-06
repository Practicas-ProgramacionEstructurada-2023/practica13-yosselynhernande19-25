using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Poblado de arreglos
            string[] nombres = {"Juan", "Manuel", "Kevin", "Maria", "Zulma", "Kenia"};

            double[] notas_primercomputo = new double[6];

            notas_primercomputo[0] = 7.5;
            notas_primercomputo[1] = 9.5;
            notas_primercomputo[2] = 6.5;
            notas_primercomputo[3] = 10;
            notas_primercomputo[4] = 5.6;
            notas_primercomputo[5] = 8.9;


            //Lectura de arreglos
            string PrimeraPosicion = nombres[0]; //Juan
            string SegundaPosicion = nombres[1]; //Manuel
            string TerceraPosicion = nombres[2]; //Kevin
            string CuartaPosicion = nombres[3]; //Maria
            string QuintaPosicion = nombres[4]; //Zulma
            string UltimaPosicion = nombres[5]; //Kenia

            double NotaPrimeraPosicion = notas_primercomputo[0]; //7.5
            double NotaSegundaPosicion = notas_primercomputo[1]; //9.5
            double NotaTerceraPosicion = notas_primercomputo[2]; //6.5
            double NotaCuartaPosicion = notas_primercomputo[3]; //10
            double NotaQuintaPosicion = notas_primercomputo[4]; //5.6
            double NotaUltimaPosicion = notas_primercomputo[5]; //8.9


            //Ordenamiento de arreglos
            Console.WriteLine("\n-----Mostrando los 6 alumnos de forma ascendente-----");
            Array.Sort(nombres);
            foreach(string Nombre in nombres)
            {
                Console.WriteLine(Nombre);
            }

            Console.WriteLine("\n-----Mostrando los 6 alumnos de forma descendente-----");
            Array.Reverse(nombres);
            foreach(string Nombre in nombres)
            {
                Console.WriteLine(Nombre);
            }

            Console.WriteLine("\n-----Mostrando los 6 alumnos de forma ascendente-----");
            Array.Sort(notas_primercomputo);
            foreach(double Notas1 in notas_primercomputo)
            {
                Console.WriteLine(Notas1);
            }

            Console.WriteLine("\n-----Mostrando los 6 alumnos de forma descendente-----");
            Array.Reverse(notas_primercomputo);
            foreach(double Notas1 in notas_primercomputo)
            {
                Console.WriteLine(Notas1);
            }


            //Impresion de resultados de los arreglos
            Console.WriteLine("\n-----Mostrando los 6 alumnos con sus notas del primer computo-----");
            Console.WriteLine(PrimeraPosicion + " tiene la siguiente nota: " + NotaPrimeraPosicion);
            Console.WriteLine(SegundaPosicion + " tiene la siguiente nota: " + NotaSegundaPosicion);
            Console.WriteLine(TerceraPosicion + " tiene la siguiente nota: " + NotaTerceraPosicion);
            Console.WriteLine(CuartaPosicion + " tiene la siguiente nota: " + NotaCuartaPosicion);
            Console.WriteLine(QuintaPosicion + " tiene la siguiente nota: " + NotaQuintaPosicion);
            Console.WriteLine(UltimaPosicion + " tiene la siguiente nota: " + NotaUltimaPosicion);
        }
    }
}