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
    public partial class Copyfile : Form
    {
        public Copyfile()
        {
            InitializeComponent();
        }

        private void Copyfile_Load(object sender, EventArgs e)
        {
            comboBox6.Items.Add("C:\\");
            comboBox6.Items.Add("E:\\");
            comboBox6.Items.Add("D:\\");

            comboBox9.Items.Add("C:\\");
            comboBox9.Items.Add("E:\\");
            comboBox9.Items.Add("D:\\");
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox6.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo df in d)
            {
                comboBox7.Items.Add(df);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fpath = comboBox6.Text + comboBox7.Text + "\\";
            FileInfo info = new FileInfo(fpath);
            FileInfo[] f = info.Directory.GetFiles();
            foreach (FileInfo inf in f)
            {
                comboBox8.Items.Add(inf);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string fspath = comboBox6.Text + comboBox7.Text + "\\" + comboBox8.Text;
            string fpath = comboBox9.Text + comboBox10.Text + "\\" + textBox4.Text;
            if (!File.Exists(fpath))
            {
                File.Copy(fspath, fpath);
                MessageBox.Show("File is copied");
            }
            else
            {
                MessageBox.Show("there is issue");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox9.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo df in d)
            {
                comboBox10.Items.Add(df);
            }
        }
    }
}
