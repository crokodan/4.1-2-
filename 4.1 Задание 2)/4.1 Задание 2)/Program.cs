using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_Задание_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int size = 10;
            int[] array = new int[size];
            int[] B = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Введите " + (i + 1) + " элемент матрицы: ");
                array[i] = int.Parse(Console.ReadLine());
                B[i] = (array[i] / 10) - (array[i] % 10);
            }
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine((i + 1) + "-й элемент массива:\t" + array[i]);
                Console.WriteLine("Разность цифр, составляющих это число, равна:\t" + B[i] + "\n");
            }
        }
    }
}
