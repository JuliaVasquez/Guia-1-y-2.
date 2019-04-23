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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario, passwd;
            usuario = textBox1.Text.TrimEnd();
            passwd = textBox2.Text.TrimEnd();
            if ((usuario=="UTEC")&(passwd=="programacion1"))
            {
                MessageBox.Show("Bienvenidos al sistema");
            }else
            {
                MessageBox.Show("Verifique su usuario y contraseña");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
