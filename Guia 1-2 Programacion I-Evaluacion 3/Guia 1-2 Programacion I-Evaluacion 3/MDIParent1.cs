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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void helpMenu_Click(object sender, EventArgs e)
        {

        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio1 obj1 = new Ejercicio1();
            obj1.MdiParent = this;
            obj1.Show();
        }

        private void tareaN1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio2 obj2 = new Ejercicio2();
            obj2.MdiParent = this;
            obj2.Show();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio3 obj3 = new Ejercicio3();
            obj3.MdiParent = this;
            obj3.Show();
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio4 obj4 = new Ejercicio4();
            obj4.MdiParent = this;
            obj4.Show();
        }

        private void ejercicio1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ejercicio5 obj5 = new Ejercicio5();
            obj5.MdiParent = this;
            obj5.Show();
        }

        private void ejercicio2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ejercicio6 obj6 = new Ejercicio6();
            obj6.MdiParent = this;
            obj6.Show();
        }

        private void ejercicio3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ejercicio7 obj7 = new Ejercicio7();
            obj7.MdiParent = this;
            obj7.Show();
        }

        private void ejercicio4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ejercicio8 obj8 = new Ejercicio8();
            obj8.MdiParent = this;
            obj8.Show();
        }
    }
}
