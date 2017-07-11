using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saira_32__Filling
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rEADFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Readfile r = new Readfile();
            r.Show();
        }

        private void createFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Createfolder cf = new Createfolder();
            cf.Show();
        }

        private void createFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Createfile c = new Createfile();
            c.Show();
        }

        private void copyFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Copyfile c = new Copyfile();
            c.Show();
        }

        private void moveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movefile m= new Movefile();
            m.Show();
        }

        private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deletefile d = new Deletefile();
            d.Show();
        }

        private void wRITEFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Writefile w = new Writefile();
            w.Show();
        }

        private void fILESTREAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            filestream fs = new filestream();
            fs.Show();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
