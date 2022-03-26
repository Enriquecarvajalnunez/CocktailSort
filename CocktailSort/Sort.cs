using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailSort
{
    class Sort
    {

        //Funcion para ordenar el arreglo
        public void CoktailSort(int[] array)
        {
            bool isSwapped = true;
            int start = 0;
            int end = array.Length;

            while (isSwapped == true)
            {

                isSwapped = false;

                //Haga una clasificación de burbuja en esta matriz de menor a mayor.
                //Si algo cambió, haga que isSwapped sea verdadero
                for (int i = start; i < end - 1; ++i)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        isSwapped = true;
                    }
                }

                //Si no se realizan intercambios, la matriz se ordena.
                if (isSwapped == false)
                    break;

                //Necesitamos restablecer la bandera isSwapped para el pase de mayor a menor
                isSwapped = false;

                /*  El elemento que acabamos de mover está en el lugar que le corresponde,
                    por lo que ya no necesitamos considerarlo sin clasificar.
                */
                end = end - 1;

                //Ahora ordenamos burbujas de mayor a menor
                for (int i = end - 1; i >= start; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        isSwapped = true;
                    }
                }

                /*  Finalmente, necesitamos aumentar el punto de partida
                    para el siguiente paso de bajo a alto.                 
                 */
                start = start + 1;
            }
        }
    }
}
