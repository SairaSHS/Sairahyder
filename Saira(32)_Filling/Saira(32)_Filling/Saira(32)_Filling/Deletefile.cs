using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Saira_32__Filling
{
    public partial class Deletefile : Form
    {
        public Deletefile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            string fpath = comboBox3.Text + comboBox4.Text + "\\" + comboBox1.Text;
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
                MessageBox.Show("File hes been Deleted");
            }
            else
            {
                MessageBox.Show("something went wrong");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* DirectoryInfo dir = new DirectoryInfo(comboBox3.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo df in d)
            {
                comboBox4.Items.Add(df);
            }*/
            DirectoryInfo dir = new DirectoryInfo(comboBox3.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo df in d)
            {
                comboBox4.Items.Add(df);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            string fpath = comboBox3.Text + comboBox4.Text + "\\";
            FileInfo info = new FileInfo(fpath);
            FileInfo[] f = info.Directory.GetFiles();
            foreach (FileInfo inf in f)
            {
                comboBox1.Items.Add(inf);
            }
        }

        private void Deletefile_Load(object sender, EventArgs e)
        {
            comboBox3.Items.Add("C:\\");
            comboBox3.Items.Add("D:\\");
            comboBox3.Items.Add("E:\\");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
