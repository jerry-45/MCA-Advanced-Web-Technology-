using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbackForm
{
    public partial class StudentFeedbackForm : Form
    {
        public StudentFeedbackForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentFeedbackResponse form = new StudentFeedbackResponse();
            String instructor = textBox1.Text;
            String subName = textBox2.Text;
            String subCode = textBox3.Text;
            String courseReason = textBox4.Text;
            String knowledgeAtStart = textBox5.Text;
            String knowledgeAtEnd = textBox6.Text;
            form.Show();
        }
    }
}
