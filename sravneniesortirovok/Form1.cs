using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace prv1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BubbleSorter mBubble;
        Perestanovki mPerest;
        ShellSorter mShell;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            int[] m = new int[Convert.ToInt32(comboBox1.Text)];
            int[] m1 = new int[Convert.ToInt32(comboBox1.Text)];
            int[] m2 = new int[Convert.ToInt32(comboBox1.Text)];

            for (int i = 0; i < m.Length; i++)
            {
                m[i] = rnd.Next(0, 1000);
                m1[i] = m[i];
                m2[i] = m[i];
            }

            mBubble = new BubbleSorter(m);
            mPerest = new Perestanovki(m1);
            mShell = new ShellSorter(m2);

            if (SuccessivelyRButtom.Checked)
            {
                
                mBubble.Sort();
                lbuble.Text = "comp. = " + mBubble.Compares + " \n sw = " + mBubble.Swaps + " \n time = " + mBubble.Time;
                
                mPerest.Sort();
                lPerest.Text = "comp. = " + mPerest.Compares + " \n sw = " + mPerest.Swaps + " \n time = " + mPerest.Time;
                
                mShell.Sort();
                lShell.Text = "comp. = " + mShell.Compares + " \n sw = " + mShell.Swaps + " \n time = " + mShell.Time;

            }
            else
            {
                Thread thread1 = new Thread(mBubble.Sort);
                Thread thread2 = new Thread(mPerest.Sort);
                Thread thread3 = new Thread(mShell.Sort);

                thread1.Start();
                thread2.Start();
                thread3.Start();


                
            }

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            lbuble.Text = "comp. = " + mBubble.Compares + " \n sw = " + mBubble.Swaps + " \n time = " + mBubble.Time;

            listVBubble.Items.Clear();
            for (int i = 0; i < mBubble.mas.Length; i++)
                listVBubble.Items.Add(Convert.ToString(mBubble.mas[i]));

        }

        private void bPerest_Click(object sender, EventArgs e)
        {
            lPerest.Text = "comp. = " + mPerest.Compares + " \n sw = " + mPerest.Swaps + " \n time = " + mPerest.Time;

            listVPerest.Items.Clear();
            for (int i = 0; i < mPerest.mas.Length; i++)
                listVPerest.Items.Add(Convert.ToString(mPerest.mas[i]));


        }

        private void button3_Click(object sender, EventArgs e)
        {
            lShell.Text = "comp. = " + mShell.Compares + " \n sw = " + mShell.Swaps + " \n time = " + mShell.Time;

            listVShell.Items.Clear();
            for (int i = 0; i < mShell.mas.Length; i++)
                listVShell.Items.Add(Convert.ToString(mShell.mas[i]));

        }
    }
}
