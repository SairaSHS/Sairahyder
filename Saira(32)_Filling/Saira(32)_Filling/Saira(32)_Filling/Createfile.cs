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
    public partial class Createfile : Form
    {
        public Createfile()
        {
            InitializeComponent();
        }

        private void Createfile_Load(object sender, EventArgs e)
        {
            comboBox3.Items.Add("C:\\");
            comboBox3.Items.Add("E:\\");
            comboBox3.Items.Add("D:\\");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string fpath = comboBox3.Text + comboBox4.Text + "\\" + textBox2.Text + ".txt";
            if (!File.Exists(fpath))
            {
                File.Create(fpath);
                MessageBox.Show("File Has Been Created!");
            }
            else
            {
                MessageBox.Show("File Already exits");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox3.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo df in d)
            {
                comboBox4.Items.Add(df);
            }
        }
    }
}
