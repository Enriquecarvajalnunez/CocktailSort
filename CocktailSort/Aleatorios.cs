using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailSort
{
    class Aleatorios
    {
        private Random _random;
        public Aleatorios()
        {
            this._random = new Random();
        }

        public int GenerarNumeroAleatorio(int min, int max)
        {
            if (min > max)
            {
                int aux = min;
                min = max;
                max = min;
            }

            return this._random.Next(min, max + 1);
        }

        public int[] GenerarNumerosAleatorios(int longitud, int min, int max)
        {
            if (longitud <= 0)
            {
                return null;
            }

            int[] numeros = new int[longitud];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = GenerarNumeroAleatorio(min, max);
            }

            return numeros;
        }

        //Funcion para generar arreglo con n Numeros
        public int[] NumerosNorepetidos(int longitud, int min, int max)
        {
            if (min > max)
            {
                int aux = min;
                min = max;
                max = aux;
            }

            if (longitud <= 0 || (max - min) < longitud - 1)
            {
                return null;
            }

            int[] numeros = new int[longitud];

            bool repetido;
            int numero;
            int indice = 0;

            while (indice < numeros.Length)
            {
                repetido = false;
                numero = GenerarNumeroAleatorio(min,max);

                for (int i = 0; i < indice; i++)
                {
                    if (numeros[i] == numero) 
                    {
                        repetido = true;
                    }
                }

                if (!repetido)
                {
                    numeros[indice] = numero;
                    indice++;
                }
            }

            return numeros;
        }
    }
}
