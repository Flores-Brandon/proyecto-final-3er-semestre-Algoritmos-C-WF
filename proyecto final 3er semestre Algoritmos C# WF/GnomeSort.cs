using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_3er_semestre_Algoritmos_C__WF
{
    internal class GnomeSort
    {
        public void Sort(int[] arr)
        {
            int n = arr.Length;
            int index = 0;

            while (index < n)
            {
                if (index == 0)
                {
                    index++;
                }
                if (arr[index] >= arr[index - 1])
                {
                    index++;
                }
                else
                {
                    Swap(ref arr[index], ref arr[index - 1]);
                    index--;
                }
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
