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
    using System.Drawing.Printing;
    using System.IO;

    using AutoBracketsTextBox;

    public partial class PowerulTextEditor : Form
    {
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();
        public PowerulTextEditor()
        {
            InitializeComponent();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);

        }
        public AutoBracketsTextBox CurrentTB
        {
            get
            {
                if (this.Tabs.SelectedTab == null)
                    return null;
                return this.Tabs.SelectedTab.Controls[0] as AutoBracketsTextBox;
            }

            set
            {
               this.Tabs.SelectedTab = value.Parent as TabPage;
                value.Focus();
            }
        }
        private void CreateTAB(string Name)
        {
            AutoBracketsTextBox ABTB = new AutoBracketsTextBox();
            TabPage Page = new TabPage();
            if (Name != null)
            {
                Page.Text = Path.GetFileName(Name);
                ABTB.Text = File.ReadAllText(Name);
            }
            else Page.Text = "[New]";
             ABTB.BracketsList = new[] { "(", ")", "[", "]", "{", "}", "'", "'", @"""", @"""" };
            ABTB.Dock = DockStyle.Fill;
            Page.Controls.Add(ABTB);
            this.Tabs.TabPages.Add(Page);
        }
        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.CurrentTB.Text, new Font("Consolas",9.75f), Brushes.Black, 20, 20);
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTAB(null);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
          
            if (open.ShowDialog()== DialogResult.OK)
                CreateTAB(open.FileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
             if (save.ShowDialog() == DialogResult.OK)
                File.WriteAllText(save.FileName, this.CurrentTB.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CurrentTB.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CurrentTB.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CurrentTB.Paste();
        }

        private void unroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CurrentTB.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colors = new ColorDialog();
            colors.ShowDialog();
            this.CurrentTB.ForeColor = colors.Color;
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colors = new ColorDialog();
            colors.ShowDialog();
            this.CurrentTB.BackColor = colors.Color;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialog.Document = document;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }
    }
}
