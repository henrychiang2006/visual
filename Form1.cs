using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const bool @true = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(
                (((checkBox1.Checked == true) && (comboBox1.Items.IndexOf(comboBox1.Text) == 0)) || ((checkBox1.Checked == true) && (comboBox1.Items.IndexOf(comboBox1.Text) == 1)) || ((checkBox1.Checked == true) && (comboBox1.Items.IndexOf(comboBox1.Text) == 2)) || ((checkBox1.Checked == true) && (comboBox1.Items.IndexOf(comboBox1.Text) == 3)) || ((checkBox1.Checked == true))) && (comboBox1.Items.IndexOf(comboBox1.Text) == 4)) 
                (((checkBox2.Checked == true) && (comboBox2.Items.IndexOf(comboBox2.Text) == 0)) || ((checkBox2.Checked == true) && (comboBox2.Items.IndexOf(comboBox2.Text) == 1)) || ((checkBox2.Checked == true) && (comboBox2.Items.IndexOf(comboBox2.Text) == 2)) || ((checkBox2.Checked == true) && (comboBox2.Items.IndexOf(comboBox2.Text) == 3)) || ((checkBox2.Checked == true))) && (comboBox2.Items.IndexOf(comboBox2.Text) == 4))
                (((checkBox3.Checked == true) && (comboBox3.Items.IndexOf(comboBox3.Text) == 0)) || ((checkBox3.Checked == true) && (comboBox3.Items.IndexOf(comboBox3.Text) == 1)) || ((checkBox3.Checked == true) && (comboBox3.Items.IndexOf(comboBox3.Text) == 2)) || ((checkBox3.Checked == true) && (comboBox3.Items.IndexOf(comboBox3.Text) == 3)) || ((checkBox3.Checked == true))) && (comboBox3.Items.IndexOf(comboBox3.Text) == 4))
                (((checkBox4.Checked == true) && (comboBox4.Items.IndexOf(comboBox4.Text) == 0)) || ((checkBox4.Checked == true) && (comboBox4.Items.IndexOf(comboBox4.Text) == 1)) || ((checkBox4.Checked == true) && (comboBox4.Items.IndexOf(comboBox4.Text) == 2)) || ((checkBox4.Checked == true) && (comboBox4.Items.IndexOf(comboBox4.Text) == 3)) || ((checkBox4.Checked == true)))&& (comboBox4.Items.IndexOf(comboBox4.Text) == 4))
                (((checkBox5.Checked == true) && (comboBox5.Items.IndexOf(comboBox5.Text) == 0)) || ((checkBox5.Checked == true) && (comboBox5.Items.IndexOf(comboBox5.Text) == 1)) || ((checkBox5.Checked == true) && (comboBox5.Items.IndexOf(comboBox5.Text) == 2)) || ((checkBox5.Checked == true) && (comboBox5.Items.IndexOf(comboBox5.Text) == 3)) || (((checkBox5.Checked == true) && (comboBox5.Items.IndexOf(comboBox5.Text) == 4)) 
                ) {
                Form2 frame = new Form2();
                frame.Show();
                    }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
