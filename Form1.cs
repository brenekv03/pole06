using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] pole;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int n = int.Parse(textBox1.Text);
            pole= new int[n];
            Random rnd = new Random();
            int poradiMin = 0;
            int poradiMax = 0;
            int min = 251;
            int max = 49;
            int sc = 0;
            for(int i =0; i < n; i++) 
            {
                int cislo = rnd.Next(50,251);
                pole[i] = cislo;
                if(cislo<min)
                {
                    min = cislo;
                    poradiMin = i;
                }
                if(cislo>max) 
                {
                    max = cislo;
                    poradiMax = i;
                }
                sc += cislo;
            }
            sc -= max + min;
            n -= 2;
            double ap = (double)sc / n;
            MessageBox.Show("Aritmetický průměr bez max a min: " + ap);
            foreach(int i in pole) { listBox1.Items.Add(i); }
            pole[poradiMax] = min;
            pole[poradiMin] = max;
            foreach (int i in pole) { listBox2.Items.Add(i); }

        }
    }
}
