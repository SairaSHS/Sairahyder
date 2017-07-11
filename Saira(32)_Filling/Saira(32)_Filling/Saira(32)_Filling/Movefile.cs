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
    public partial class Movefile : Form
    {
        public Movefile()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Movefile_Load(object sender, EventArgs e)
        {
            comboBox11.Items.Add("C:\\");
            comboBox11.Items.Add("E:\\");
            comboBox11.Items.Add("D:\\");

            comboBox13.Items.Add("C:\\");
            comboBox13.Items.Add("E:\\");
            comboBox13.Items.Add("D:\\");
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string fspath = comboBox11.Text + comboBox12.Text + "\\" + comboBox5.Text;
            string fpath = comboBox13.Text + comboBox14.Text + "\\" + textBox3.Text;
            if (File.Exists(fpath))
            {
                File.Move(fspath, fpath);
                MessageBox.Show("File hes been moved");
            }
            else
            {
                MessageBox.Show("there is an issue");
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox11.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo df in d)
            {
                comboBox12.Items.Add(df);
            }

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fpath = comboBox11.Text + comboBox12.Text + "\\";
            FileInfo info = new FileInfo(fpath);
            FileInfo[] f = info.Directory.GetFiles();
            foreach (FileInfo inf in f)
            {
                comboBox5.Items.Add(inf);
            }
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBox5.Text;

        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox13.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo df in d)
            {
                comboBox14.Items.Add(df);
            }
        }
    }
}
