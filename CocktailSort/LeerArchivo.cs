using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailSort
{
    class LeerArchivo
    {
        //Funcion para leer el archivo de texto
        public int[] Archivo(int[] line)
        {
            int counter;
            List<int> miLista = new List<int>();

            foreach (string lines in System.IO.File.ReadLines(@"C:\Users\enunez\Downloads\Temporal\test.txt"))
            {
                System.Console.WriteLine(lines);
                counter = int.Parse(lines);

                miLista.Add(counter);
            }
            int[] arr = miLista.ToArray();

            return arr;
        }

    }
}
