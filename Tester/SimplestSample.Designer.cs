namespace Tester
{
    partial class SimplestSample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.autoBracketsTextBox1 = new AutoBracketsTextBox.AutoBracketsTextBox();
            this.SuspendLayout();
            // 
            // autoBracketsTextBox1
            // 
            this.autoBracketsTextBox1.BracketsList = new string[] {
        "(",
        ")",
        "[",
        "]",
        "{",
        "}",
        "\'",
        "\'",
        "\"",
        "\""};
            this.autoBracketsTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoBracketsTextBox1.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.autoBracketsTextBox1.Location = new System.Drawing.Point(0, 0);
            this.autoBracketsTextBox1.Multiline = true;
            this.autoBracketsTextBox1.Name = "autoBracketsTextBox1";
            this.autoBracketsTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.autoBracketsTextBox1.Size = new System.Drawing.Size(405, 267);
            this.autoBracketsTextBox1.TabIndex = 0;
            this.autoBracketsTextBox1.WordWrap = false;
            // 
            // SimplestSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 267);
            this.Controls.Add(this.autoBracketsTextBox1);
            this.Name = "SimplestSample";
            this.Text = "SimplestSample";
            this.Load += new System.EventHandler(this.SimplestSample_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutoBracketsTextBox.AutoBracketsTextBox autoBracketsTextBox1;
    }
}