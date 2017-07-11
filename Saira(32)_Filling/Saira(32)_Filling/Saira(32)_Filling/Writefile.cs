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
    public partial class Writefile : Form
    {
        public Writefile()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Writefile_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("C:\\");
            comboBox1.Items.Add("D:\\");
            comboBox1.Items.Add("E:\\");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            DirectoryInfo dir = new DirectoryInfo(comboBox1.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo df in d)
            {
                comboBox2.Items.Add(df);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string fname = comboBox1.Text + comboBox2.Text + "\\" + comboBox3.Text;
            StreamWriter sr = new StreamWriter(fname);
            sr.Write(textBox1.Text);
            MessageBox.Show("YOUR file has been Written");
            sr.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string spath = comboBox1.Text + comboBox2.Text + "\\";
            FileInfo info = new FileInfo(spath);
            FileInfo[] f = info.Directory.GetFiles();
            foreach (FileInfo inf in f)
            {
                comboBox3.Items.Add(inf);
            }

        }
    }
}
