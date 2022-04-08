using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadAgain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void Font_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                Font font = fontDialog1.Font;
                this.textBox1.Text = string.Format("Font is: {0}", font.Name);
                this.textBox1.Font = font;
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string name = saveFileDialog1.FileName;
            File.WriteAllText(name, textBox1.Text);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenu_ItemClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenu_ItemClicked(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
         
        }

        private void openToolStripMenu_ItemClicked(object sender, EventArgs e)
        {
            OpenFileDialog fld = new OpenFileDialog();
            fld.ShowDialog();
        }

        private void printToolStripMenu_ItemClicked(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
    }
}
