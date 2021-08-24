using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar las temperaturas de la semana
             informar la mayor, la menor, el promedio
            Mostrar las temperaturas
            Mostrar con un asterisco aquellas superiores al promedio
             */
            var arrayTemperaturas = new int[7];
            int contador10 = 0;
            IngresoDeTemperaturas(arrayTemperaturas);
            ImprimirArray(arrayTemperaturas);
            AnalizarArray(arrayTemperaturas);
            AnalizarAlternativa(arrayTemperaturas);
            OrdenarArray(arrayTemperaturas);
            Console.ReadLine();
        }

        private static void OrdenarArray(int[] arrayTemperaturas)
        {
            var arrayTempBackup = new int[7];
            Array.Copy(arrayTemperaturas,arrayTempBackup,arrayTemperaturas.Length);
            BubbleSort(arrayTempBackup);
            ImprimirArray(arrayTempBackup);
        }

        private static void BubbleSort(int[] arrayTempBackup)
        {
            for (int i = 0; i < arrayTempBackup.Length-1; i++)
            {
                for (int j = i+1; j < arrayTempBackup.Length; j++)
                {
                    if (arrayTempBackup[i]>arrayTempBackup[j])
                    {
                        var auxiliar = arrayTempBackup[i];
                        arrayTempBackup[i] = arrayTempBackup[j];
                        arrayTempBackup[j] = auxiliar;
                    }
                }
            }
        }

        private static void AnalizarAlternativa(int[] arrayTemperaturas)
        {
            Console.WriteLine($"Mayor temp:{arrayTemperaturas.Max()}");
            Console.WriteLine($"Menor temp:{arrayTemperaturas.Min()}");
            
            Console.WriteLine($"Promedio:{arrayTemperaturas.Average()}");

        }

        private static void AnalizarArray(int[] arrayTemperaturas)
        {
            Console.WriteLine($"Cantidad de elementos:{arrayTemperaturas.Length}");
            
            var maxValue = MayorTemperatura(arrayTemperaturas);
            Console.WriteLine($"Mayor temp:{maxValue}");
            int minValue = MenorTemperatura(arrayTemperaturas);
            Console.WriteLine($"Menor temp:{minValue}");
            double promedio = CalcularPromedio(arrayTemperaturas);

            Console.WriteLine($"Promedio:{promedio}");
            MarcarTemperaturasSuperioresPromedio(arrayTemperaturas, promedio);

            //Console.WriteLine($"Cant. temp entre 0 y 10:{contador10}");

        }

        private static void MarcarTemperaturasSuperioresPromedio(int[] arrayTemperaturas, double promedio)
        {
            foreach (var temperatura in arrayTemperaturas)
            {
                if (temperatura>promedio)
                {
                    Console.WriteLine($"{temperatura} *");
                }
                else
                {
                    Console.WriteLine($"{temperatura}");
                }
            }
        }

        private static double CalcularPromedio(int[] arrayTemperaturas)
        {
            double promedio = 0;
            foreach (var temperatura in arrayTemperaturas)
            {
                promedio += temperatura;
            }

            promedio = promedio / arrayTemperaturas.Length;
            return promedio;
        }

        private static int MenorTemperatura(int[] arrayTemperaturas)
        {
            int minTemperatura = 100;
            foreach (var temperatura in arrayTemperaturas)
            {
                if (temperatura<minTemperatura)
                {
                    minTemperatura = temperatura;
                }
            }

            return minTemperatura;
        }

        private static int MayorTemperatura(int[] arrayTemperaturas)
        {
             int maxTemperatura = -100;
             foreach (var temperatura in arrayTemperaturas)
             {
                 if (temperatura>maxTemperatura)
                 {
                     maxTemperatura = temperatura;
                 }
             }

             return maxTemperatura;

        }

        private static void IngresoDeTemperaturas(int[] arrayTemperaturas)
        {
            Random r = new Random();
            for (int i = 0; i < 7; i++)
            {
               arrayTemperaturas[i] = r.Next(-2, 25);
            }

            //arrayTemperaturas[6] =int.Parse("123");
        }

        private static void ImprimirArray(int[] arrayTemperaturas)
        {
            for (int i = 0; i < arrayTemperaturas.Length; i++)
            {
                Console.WriteLine(arrayTemperaturas[i]);   
            }
        }
    }
}
