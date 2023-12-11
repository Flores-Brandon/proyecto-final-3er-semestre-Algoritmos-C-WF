using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_3er_semestre_Algoritmos_C__WF
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch;
        int[] array = { 10, 5, 1, 2, 7 };
        Random random;

        public Form1()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            random = new Random();

        }

        private int[] ArrayReset(int[] arr)
        {
            arr[0] = 10;
            arr[1] = 5;
            arr[2] = 1;
            arr[3] = 2;
            arr[4] = 7;
            return arr;
        }
        public static void PrintArray(int[] array, TextBox txtBox)
        {
            txtBox.Text += ("[" + string.Join(", ", array) + "]\r\n");
        }

        private void btnInsertionSort_Click_(object sender, EventArgs e)
        {
            Insertionsort insertionSort = new Insertionsort();
            txtInsertionSort.Text = string.Empty;
            stopwatch.Reset();
            txtInsertionSort.Text += ("Arreglo inicial: ");
            PrintArray(array, txtInsertionSort);
            stopwatch.Start();
            insertionSort.InsertionSortAlgorithm(array);
            stopwatch.Stop();
            txtInsertionSort.Text += ("Arreglo ordenado: ");
            PrintArray(array, txtInsertionSort);
            txtInsertionSort.Text += ("Tiempo de ejecucion del metodo InsertionSort() = " + stopwatch.Elapsed);
            ArrayReset(array);
        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            Selectionsort selectionsort = new Selectionsort();
            txtSelectionSort.Text = string.Empty;
            stopwatch.Reset();
            txtSelectionSort.Text += ("Arreglo inicial: ");
            PrintArray(array, txtSelectionSort);
            stopwatch.Start();
            selectionsort.Sort(array);
            stopwatch.Stop();
            txtSelectionSort.Text += ("Arreglo ordenado: ");
            PrintArray(array, txtSelectionSort);
            txtSelectionSort.Text += ("Tiempo de ejecucion del metodo InsertionSort() = " + stopwatch.Elapsed);
            ArrayReset(array);
        }

        private void btnRadixSort_Click(object sender, EventArgs e)
        {
            Radixsort radixsort = new Radixsort();
            txtRadixSort.Text = string.Empty;
            stopwatch.Reset();
            txtRadixSort.Text += ("Arreglo inicial: ");
            PrintArray(array, txtRadixSort);
            stopwatch.Start();
            radixsort.Sort(array);
            stopwatch.Stop();
            txtRadixSort.Text += ("Arreglo ordenado: ");
            PrintArray(array, txtRadixSort);
            txtRadixSort.Text += ("Tiempo de ejecucion del metodo InsertionSort() = " + stopwatch.Elapsed);
            ArrayReset(array);
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            txtQuickSort.Text = string.Empty;
            QuickSort quickSort = new QuickSort();
            stopwatch.Reset();
            txtQuickSort.Text += ("Arreglo inicial: ");
            PrintArray(array, txtQuickSort);
            stopwatch.Start();
            quickSort.quicksort(ref array, 0, 4, txtQuickSort);
            stopwatch.Stop();
            txtQuickSort.Text += ("Arreglo ordenado: ");
            PrintArray(array, txtQuickSort);
            txtQuickSort.Text += ("Tiempo de ejecucion del metodo QuickSort() = " + stopwatch.Elapsed);
            ArrayReset(array);
        }

        private void btnShellSort_Click(object sender, EventArgs e)
        {
            txtShellSort.Text = string.Empty;
            Shellsort shellSort = new Shellsort();
            txtShellSort.Text = string.Empty;
            stopwatch.Reset();
            txtShellSort.Text += ("Arreglo inicial: ");
            PrintArray(array, txtShellSort);
            stopwatch.Start();
            shellSort.Shell_Sort(array, txtShellSort);
            stopwatch.Stop();
            txtShellSort.Text += ("\r\nArreglo ordenado: ");
            PrintArray(array, txtShellSort);
            txtShellSort.Text += ("Tiempo de ejecucion del metodo ShellSort() = " + stopwatch.Elapsed);
            ArrayReset(array);
        }

        private void btnBinaryTreeSort_Click(object sender, EventArgs e)
        {
            txtBinaryTreeSort.Text = string.Empty;
            PrintArray(array, txtBinaryTreeSort);
            BinaryTreeSort binaryTree = new BinaryTreeSort();
            stopwatch.Restart();
            stopwatch.Start();
            binaryTree.Sort(array);
            stopwatch.Stop();
            PrintArray(array, txtBinaryTreeSort);
            txtBinaryTreeSort.Text += ("Tiempo de ejecucion del Metodo Binary Tree Sort = " + stopwatch.Elapsed);
            ArrayReset(array);
        }

        private void btnBucketSort_Click(object sender, EventArgs e)
        {
            Bucketsort bucketSort = new Bucketsort();
            txtBucketSort.Text = string.Empty;
            stopwatch.Reset();
            txtBucketSort.Text += ("Arreglo inicial: ");
            PrintArray(array, txtBucketSort);
            stopwatch.Start();
            bucketSort.BucketSort_int(array, txtBucketSort);
            stopwatch.Stop();
            txtBucketSort.Text += ("Arreglo ordenado: ");
            PrintArray(array, txtBucketSort);
            txtBucketSort.Text += ("Tiempo de ejecucion del metodo BucketSort() = " + stopwatch.Elapsed);
            ArrayReset(array);
        }

        private void btnCombSort_Click(object sender, EventArgs e)
        {
            Combsort combSort = new Combsort();
            txtCombSort.Text = string.Empty;
            stopwatch.Reset();
            txtCombSort.Text += ("Arreglo inicial: ");
            PrintArray(array, txtCombSort);
            stopwatch.Start();
            combSort.Sort(array);
            stopwatch.Stop();
            txtCombSort.Text += ("Arreglo ordenado: ");
            PrintArray(array, txtCombSort);
            txtCombSort.Text += ("Tiempo de ejecucion del metodo CombSort() = " + stopwatch.Elapsed);
            ArrayReset(array);
        }

        private void btnCountingSort_Click(object sender, EventArgs e)
        {
            Countingsort countingSort = new Countingsort();
            txtCountingSort.Text = string.Empty;
            stopwatch.Reset();
            txtCountingSort.Text += ("Arreglo inicial: ");
            PrintArray(array, txtCountingSort);
            stopwatch.Start();
            countingSort.Sort(array);
            stopwatch.Stop();
            txtCountingSort.Text += ("Arreglo ordenado: ");
            PrintArray(array, txtCountingSort);
            txtCountingSort.Text += ("Tiempo de ejecucion del metodo CountingSort() = " + stopwatch.Elapsed);
            ArrayReset(array);
        }

        private void btnPigeonSort_Click(object sender, EventArgs e)
        {
            PigeonHole pigeonHole = new PigeonHole();
            txtPigeonSort.Text = string.Empty;
            stopwatch.Reset();
            txtPigeonSort.Text += ("Arreglo inicial: ");
            PrintArray(array, txtPigeonSort);
            stopwatch.Start();
            pigeonHole.PigeonholeSort(array);
            stopwatch.Stop();
            txtPigeonSort.Text += ("Arreglo ordenado: ");
            PrintArray(array, txtPigeonSort);
            txtPigeonSort.Text += ("Tiempo de ejecucion del metodo PigeonHoleSort() = " + stopwatch.Elapsed);
            ArrayReset(array);
        }

        private void btnCocktailSort_Click(object sender, EventArgs e)
        {
            Cocktailsort cocktailSort = new Cocktailsort();
            txtCocktailSort.Text = string.Empty;
            stopwatch.Reset();
            txtCocktailSort.Text += ("Arreglo inicial: ");
            PrintArray(array, txtCocktailSort);
            stopwatch.Start();
            cocktailSort.cocktailSort(array);
            stopwatch.Stop();
            txtCocktailSort.Text += ("Arreglo ordenado: ");
            PrintArray(array, txtCocktailSort);
            txtCocktailSort.Text += ("Tiempo de ejecucion del metodo CocktailSort() = " + stopwatch.Elapsed);
            ArrayReset(array);
        }

        private void btnHeap_Click(object sender, EventArgs e)
        {
            HeapSort heapSort = new HeapSort();
            txtHeapSort.Text = string.Empty;
            stopwatch.Reset();
            txtHeapSort.Text += ("Arreglo inicial: ");
            PrintArray(array, txtHeapSort);
            stopwatch.Start();
            heapSort.Sort(array);
            stopwatch.Stop();
            txtHeapSort.Text += ("Arreglo ordenado: ");
            PrintArray(array, txtHeapSort);
            txtHeapSort.Text += ("Tiempo de ejecucion del metodo HeapSort() = " + stopwatch.Elapsed);
            ArrayReset(array);
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            MergeSort mergeSort = new MergeSort();
            txtMergeSort.Text = string.Empty;
            stopwatch.Reset();
            txtMergeSort.Text += ("Arreglo inicial: ");
            PrintArray(array, txtMergeSort);
            stopwatch.Start();
            mergeSort.MergeSortt(array);
            stopwatch.Stop();
            txtMergeSort.Text += ("Arreglo ordenado: ");
            PrintArray(array, txtMergeSort);
            txtMergeSort.Text += ("Tiempo de ejecucion del metodo MergeSort() = " + stopwatch.Elapsed);
            ArrayReset(array);
        }

        private void btnSmoothSort_Click(object sender, EventArgs e)
        {
            txtSmooth.Text = string.Empty;
            SmoothSort smoothSort = new SmoothSort();
            txtSmooth.Text = string.Empty;
            stopwatch.Reset();
            txtSmooth.Text += ("Arreglo inicial: ");
            PrintArray(array, txtSmooth);
            stopwatch.Start();
            smoothSort.Sort(array);
            stopwatch.Stop();
            txtSmooth.Text += ("Arreglo ordenado: ");
            PrintArray(array, txtSmooth);
            txtSmooth.Text += ("Tiempo de ejecucion del metodo SmoothSort() = " + stopwatch.Elapsed);
            ArrayReset(array);
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            txtBubbleSort.Text = string.Empty;
            stopwatch.Restart();
            stopwatch.Start();
            BubbleSort(array, txtBubbleSort);
            stopwatch.Stop();
            txtBubbleSort.Text += ("Tiempo de ejecucion del metodo BubbleSort() = " + stopwatch.Elapsed);
            ArrayReset(array);
        }
        public static void BubbleSort(int[] array, TextBox txtBox)
        {
            txtBox.Text = string.Empty;
            txtBox.Text += ("Arreglo inicial: ");
            PrintArray(array, txtBox);

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    // Comparar los elementos adyacentes y intercambiar si el elemento actual es menor que el siguiente
                    if (array[j] > array[j + 1])
                    {
                        // Intercambiar elementos
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        // Mostrar el estado actual del arreglo
                        txtBox.Text += ("Intercambio - [" + string.Join(", ", array) + "]\r\n");
                    }
                }
            }
            txtBox.Text += ("Arreglo ordenado: ");
            PrintArray(array, txtBox);
        }

        private void btnGnomeSort_Click(object sender, EventArgs e)
        {
            GnomeSort gnomeSort = new GnomeSort();
            txtGnomeSort.Text = string.Empty;
            stopwatch.Reset();
            txtGnomeSort.Text += ("Arreglo inicial: ");
            PrintArray(array, txtGnomeSort);
            stopwatch.Start();
            gnomeSort.Sort(array);
            stopwatch.Stop();
            txtGnomeSort.Text += ("Arreglo ordenado: ");
            PrintArray(array, txtGnomeSort);
            txtGnomeSort.Text += ("Tiempo de ejecucion del metodo GnomeSort() = " + stopwatch.Elapsed);
            ArrayReset(array);
        }
    }
}
