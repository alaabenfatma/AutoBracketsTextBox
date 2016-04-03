using System;
using System.Windows.Forms;

namespace Tester
{
    using System.IO;

    public partial class SimpleTextEditor : Form
    {
        public SimpleTextEditor()
        {
            InitializeComponent();
            this.autoBracketsTextBox1.BracketsList = new[] { "(", ")" };
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            this.autoBracketsTextBox1.Text = File.ReadAllText(open.FileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();
            File.WriteAllText(save.FileName,this.autoBracketsTextBox1.Text);
        }

        private void SimpleTextEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
