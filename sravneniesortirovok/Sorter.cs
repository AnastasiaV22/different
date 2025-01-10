using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prv1
{
    public class Sorter
    {
        public int itemCount;
        public int[] mas;

        public Action OnTerminale;


        public int Compares { get; set; }
        int ItemCount { get; }
        int[] Items { get; }
        public int Swaps { get; set; }
        bool Terminated { get; set; }
        public TimeSpan Time { get; set; }

        void Sort()
        {

        }

        public Sorter()
        {

        }

        public Sorter(int[] mas_)
        {
            mas = mas_;
            itemCount = mas_.Length;
        }
    }
}
