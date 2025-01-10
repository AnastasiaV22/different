using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace prv1
{
    public class BubbleSorter : Sorter
    {
        public BubbleSorter(int[] mas) : base(mas) { }

        public void Sort() {

            Swaps = 0;
            Compares = 0;
            DateTime start = DateTime.Now;
            for (int i = 0; i < mas.Length; i++)
                for (int j = 0; j < mas.Length - i - 1; j++)
                {
                    Compares++;
                    if (mas[j] > mas[j + 1])
                    {
                        int temp = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = temp;
                        Swaps++;
                    }
                }
            DateTime end = DateTime.Now;

            Time = end - start;
        }


    }
}
