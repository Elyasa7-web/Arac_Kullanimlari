using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimlari
{
    public partial class ödev : Form
    {
        public ödev()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text + " " + textBox3.Text + " " + maskedTextBox1.Text + " " + maskedTextBox2.Text + " " + comboBox1.Text + " " + dateTimePicker1.Text);
        }
    }
}
