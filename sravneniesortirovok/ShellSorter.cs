using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prv1
{
    public class ShellSorter : Sorter
    {
        public ShellSorter(int[] mas) : base(mas) { }
    
        public void Sort(){
            Swaps = 0;
            Compares = 0;
            DateTime start = DateTime.Now;
            int i, j, step;
            int tmp;

            for (step = itemCount / 2; step > 0; step /= 2)
                for (i = step; i < itemCount; i++)
                {
                    tmp = mas[i];
                    for (j = i; j >= step; j -= step)
                    {
                        Compares++;
                        if (tmp < mas[j - step])
                        {
                            mas[j] = mas[j - step];
                            Swaps++;
                        }
                        else
                            break;
                    }
                    Swaps++;
                    mas[j] = tmp;
                }

            DateTime end = DateTime.Now;
            Time = end - start;
        }

        
    }
}
