using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;

            if (radioButton1.Checked == true)
            {
                total = total + 50;
            }
            if (radioButton2.Checked == true)
            {
                total = total + 100;
            }
            if (radioButton3.Checked == true)
            {
                total = total + 150;
            }
            if (checkBox1.Checked == true)
            {
                total = total + 5;
            }
            if (checkBox2.Checked == true)
            {
                total = total + 15;
            }
            if (checkBox3.Checked == true)
            {
                total = total + 20;
            }
            MessageBox.Show("El total de gastos es : $ " + total.ToString());
        }
    }
}
