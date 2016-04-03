using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new SimplestSample();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form from  = new SimpleTextEditor();
            from.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new PowerulTextEditor();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm  = new StringsAutoComplete();
            frm.Show();
        }
    }
}
