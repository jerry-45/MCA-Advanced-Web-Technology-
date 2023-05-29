using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringConcatenation
{
    public partial class StringConcatenation : Form
    {
        public StringConcatenation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string concate = textBox1.Text + " " + textBox2.Text;
            textBox3.Text = concate;
        }
    }
}
