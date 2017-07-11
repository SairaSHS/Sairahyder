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
    public partial class Createfolder : Form
    {
        public Createfolder()
        {
            InitializeComponent();
        }

        private void Createfolder_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("C:\\");
            comboBox1.Items.Add("E:\\");
            comboBox1.Items.Add("D:\\");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fpath = comboBox1.Text + comboBox2.Text + "\\" + textBox1.Text;
            if (!File.Exists(fpath))
            {
                Directory.CreateDirectory(fpath);
                MessageBox.Show("Folder Has Been Created!");
            }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
