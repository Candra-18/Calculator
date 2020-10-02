using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallculatorWindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private float Penambahan(float a, float b)
        {
            return a + b;
        }
        private float Pengurangan(float a, float b)
        {
            return a - b;
        }
        private float Perkalian(float a, float b)
        {
            return a * b;
        }
        private float Pembagian(float a, float b)
        {
            return a / b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = float.Parse(TeksA.Text);
            var b = float.Parse(TeksB.Text);

            if (COB1.SelectedIndex == 0)
            {
                Hasil.Items.Clear();
                Hasil.Items.Add(string.Format("{2}", a, b, Penambahan(a, b)));
            }

            if (COB1.SelectedIndex == 1)
            {
                Hasil.Items.Clear();
                Hasil.Items.Add(string.Format("{2}", a, b, Pengurangan(a, b)));
            }
            if (COB1.SelectedIndex == 2)
            {
                Hasil.Items.Clear();
                Hasil.Items.Add(string.Format("{2}", a, b, Perkalian(a, b)));
            }
            if (COB1.SelectedIndex == 3)
            {
                Hasil.Items.Clear();
                Hasil.Items.Add(string.Format("{2}", a, b, Pembagian(a, b)));
            }
        }

        private void COB1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
