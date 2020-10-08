using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CallculatorMachine;

namespace CallculatorWindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            var a = float.Parse(TeksA.Text);
            var b = float.Parse(TeksB.Text);
            var cal = new Calculator();

            if (COB1.SelectedIndex == 0)
            {
                Hasil.Items.Clear();
                Hasil.Items.Add(string.Format("{2}", a, b,cal.Penambahan(a, b)));
            }

            if (COB1.SelectedIndex == 1)
            {
                Hasil.Items.Clear();
                Hasil.Items.Add(string.Format("{2}", a, b, cal.Pengurangan(a, b)));
            }
            if (COB1.SelectedIndex == 2)
            {
                Hasil.Items.Clear();
                Hasil.Items.Add(string.Format("{2}", a, b, cal.Perkalian(a, b)));
            }
            if (COB1.SelectedIndex == 3)
            {
                Hasil.Items.Clear();
                Hasil.Items.Add(string.Format("{2}", a, b, Calculator.Pembagian(a, b)));
            }
             else if (COB1.SelectedIndex == 4)
            {
                Hasil.Items.Clear();
                Hasil.Items.Add(string.Format("{2}", a, b, cal.Pangkat(a, b)));

            }
            else if (COB1.SelectedIndex == 5)
            {
                Hasil.Items.Clear();
                Hasil.Items.Add(string.Format("{2}", a, b, Calculator.Modulo(a, b)));
            }
        }

        private void COB1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Hasil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void COB1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
