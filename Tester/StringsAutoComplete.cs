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
    public partial class StringsAutoComplete : Form
    {
        public StringsAutoComplete()
        {
            InitializeComponent();
            this.autoBracketsTextBox1.BracketsList = new[] { "{" ,  Environment.NewLine + Environment.NewLine + "}" };
        }

        private void StringsAutoComplete_Load(object sender, EventArgs e)
        {

        }
    }
}
