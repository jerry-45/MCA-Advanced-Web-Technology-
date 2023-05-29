using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int add = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            textBox3.Text = add.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sub = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
            textBox3.Text = sub.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mul = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
            textBox3.Text = mul.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double div = double.Parse(textBox1.Text) / double.Parse(textBox2.Text);
            textBox3.Text = div.ToString();
        }

        private void SimpleCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
