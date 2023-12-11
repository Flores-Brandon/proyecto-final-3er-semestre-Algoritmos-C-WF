using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_3er_semestre_Algoritmos_C__WF
{
    internal class Shellsort
    {
        private void PrintArray(int[] array, TextBox textBox)
        {
            foreach (var num in array)
            {
                textBox.Text += (num + " ");
            }
            textBox.Text += "\r\n";
        }
        public void Shell_Sort(int[] array, TextBox textBox)
        {
            // se obtiene la longitud del array
            int n = array.Length;
            // se obtiene el tamaño de espacio entre elementos
            int gap = n / 2;

            textBox.Text += ("\nInicio del algoritmo Shell Sort:\r\n");

            // Mientras el espacio entre elementos sea mayor que 0
            while (gap > 0)
            {
                textBox.Text += ($"\nGap actual: {gap}\r\n");

                // Aplicar el algoritmo de inserción para cada "subarray" con el tamaño de gap
                for (int i = gap; i < n; i++)
                {
                    // Guardar el valor actual del elemento en una variable temporal
                    int temp = array[i];
                    int j = i;

                    textBox.Text += ($"\nComparando {temp} con los elementos en su subarray:\r\n");

                    // Realizar la inserción
                    while (j >= gap && array[j - gap] > temp)
                    {
                        // Desplazar elementos hacia la derecha hasta encontrar la posición correcta
                        array[j] = array[j - gap];
                        j -= gap;

                        PrintArray(array, textBox);
                    }

                    // Colocar el valor temporal en la posición correcta en el subarray
                    array[j] = temp;
                    textBox.Text += ($"Insertar {temp} en la posición {j} del subarray:\r\n");
                    PrintArray(array, textBox);
                }

                // Reducir el espacio entre elementos a la mitad en cada iteración
                gap /= 2;
            }

            textBox.Text += ("\nFin del algoritmo Shell Sort:");
        }
    }
}
