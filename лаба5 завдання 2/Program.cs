using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба5_завдання_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[20];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 10);
                Console.WriteLine($"array[{i}] = {array[i]}");

            }
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > 0; j--)
                {
                    if ((array[j] < 0) && (array[j] < array[j - 1]))
                    {
                        temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;

                    }
                }

            }
            Console.WriteLine("--------------------------");
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"array[{i}] = {array[i]} ");
        }
    }
}
