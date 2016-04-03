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
    using AutoBracketsTextBox;

    public partial class SimplestSample : Form
    {
        public SimplestSample()
        {
            InitializeComponent();
        }
       
        private void SimplestSample_Load(object sender, EventArgs e)
        {
            AutoBracketsTextBox ABTB  = new AutoBracketsTextBox();
            ABTB.Dock = DockStyle.Fill;
            ABTB.BracketsList = new[] { "(", ")","'","'" };
            this.Controls.Add(ABTB);
        }
    }
}
