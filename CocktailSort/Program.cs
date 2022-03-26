    using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CocktailSort
{
    class Program
    {
        static void Main(String[] args)
        {
            Stopwatch timeMeasure = new Stopwatch();
            timeMeasure.Start();
            /*
                Generar numeros aleatorios no repetidos
             */
            Aleatorios a = new Aleatorios();
            int[] numeros = a.NumerosNorepetidos(10, 0, 10);

            
            int[] myIntArray = new int[] {};

            LeerArchivo l = new LeerArchivo();
            /*
                Se le envia un array vacio para que el metodo Archivo lo contrusya                
            */
            l.Archivo(myIntArray);
            /*
                se pasa el retorno de la función Archivo a un array, con el cual se le envia a el metodo de ordenamiento            
            */
            int[] array = l.Archivo(myIntArray);

            /*
                Instanciación de la clase Sort
             */
            Sort CoktailSort = new Sort();

            /*
                Ejecuta el metodo de ordenamiento
             */            
            CoktailSort.CoktailSort(numeros);
            timeMeasure.Stop();
            Console.WriteLine($"Tiempo: {timeMeasure.Elapsed.TotalMilliseconds} ms");
        }        
    }
}
