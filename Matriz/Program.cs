using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que muestra el uso de arreglos en dos dimensiones o matrices 
            //Variables de control para el ciclo for

            int m;
            int n;

            double sumatoria = 0;
            double promedio = 0.0;

            //Utilizar la variable random 
            Random rnd = new Random();

            int[,] datos = new int[4, 7];

            for (n = 0; n < 4; n++)// avanzamos renglones
            {
                for(m = 0; m < 7; m++)
                {
                    // Para llevar acabo la asignacion (nombre matriz,indice f y c y el valor 
                    datos[n, m] = rnd.Next(30);
                }
            }

            //imprimir los datos 

            for (n = 0; n < 4; n++)
            {
                Console.WriteLine("Semana {0}", n);
                for (m = 0; m < 7; m++)
                {
                    Console.Write("{0}", datos[n, m]);
                }
            }

            //calcular el promedio por semana 
            for(n=0; n<4;n++)
            {
                sumatoria = 0.0;
                promedio = 0.0;
                for (m = 0; m < 7; m++)
                {
                    sumatoria += datos[n, m];
                }

                promedio = sumatoria / 7.0;
                Console.WriteLine("El promedio de la semana {0} es {1}", n, promedio);
                    
            }
            for (n = 0; n < 4; n++)
            {
                sumatoria = 0.0;
                promedio = 0.0;
                for (m = 0; m < 7; m++)
                {
                    sumatoria += datos[n, m];
                }

                promedio = sumatoria / 28.0;
                Console.WriteLine("El promedio total de la semana {0} es {1}", n, promedio);

            }

            Console.ReadKey();
        }
    }
}
