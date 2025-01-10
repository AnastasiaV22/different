using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prv1
{
    public class Perestanovki : Sorter
    {

        public Perestanovki(int[] mas) : base(mas) { }

        public void Sort()
        {
            Swaps = 0;
            Compares = 0;

            DateTime start = DateTime.Now;

            for (int i = 1; i < mas.Length; i++)
            {
                int cur = mas[i];
                int j = i;
                while (j > 0 && cur < mas[j - 1])
                {
                    Compares++;
                    mas[j] = mas[j - 1];
                    Swaps++;
                    j--;
                }
                mas[j] = cur;
                Swaps++;
            }
       
            DateTime end = DateTime.Now;
            Time = end - start;
        }
    }
}
