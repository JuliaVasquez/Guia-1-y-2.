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
    public partial class Ejercicio6 : Form
    {
        private MessageBoxButtons tipoDeBoton = MessageBoxButtons.OK;
        private MessageBoxIcon tipoDeIcono = MessageBoxIcon.Error;

        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void tipoDeBoton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == radioButton1)
                tipoDeBoton = MessageBoxButtons.OK;
            else if (sender == radioButton2)
                tipoDeBoton = MessageBoxButtons.OKCancel;
            else if (sender == radioButton3)
                tipoDeBoton = MessageBoxButtons.YesNo;
            else if (sender == radioButton4)
                tipoDeBoton = MessageBoxButtons.YesNoCancel;
            else if (sender == radioButton5)
                tipoDeBoton = MessageBoxButtons.RetryCancel;
            else
                tipoDeBoton = MessageBoxButtons.AbortRetryIgnore;
        }

        private void tipoDeIcono_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == radioButton7) // display error icon
                tipoDeIcono = MessageBoxIcon.Information;
            else if (sender == radioButton8)

                tipoDeIcono = MessageBoxIcon.Exclamation;
            else if (sender == radioButton9)
                tipoDeIcono = MessageBoxIcon.Question;
            else // only one option left--display question mark
                tipoDeIcono = MessageBoxIcon.Error;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result =
           MessageBox.Show("Mensaje a desplegar",

           "Título de la Ventana", tipoDeBoton, tipoDeIcono);

            switch (result)
            {
                case DialogResult.OK:
                    label2.Text = "Seleccionó OK.";
                    break;
                case DialogResult.Cancel:
                    label2.Text = "Seleccionó Cancel.";
                    break;
                case DialogResult.Yes:
                    label2.Text = "Seleccionó Yes.";
                    break;
                case DialogResult.No:
                    label2.Text = "Seleccionó No.";
                    break;
                case DialogResult.Ignore:
                    label2.Text = "Seleccionó  Ignore.";
                    break;
                case DialogResult.Abort:
                    label2.Text = "Seleccionó Abort.";
                    break;
                case DialogResult.Retry:
                    label2.Text = "Seleccionó Retry.";
                    break;
            }
        }
    }
}
