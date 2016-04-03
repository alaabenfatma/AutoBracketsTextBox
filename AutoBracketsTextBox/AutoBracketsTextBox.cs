//
//  THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
//  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
//  PURPOSE.
//
//  License: GNU Lesser General Public License (LGPLv3)
//
//  Email: alaabenfatma@yahoo.fr
//  Link : http://www.codeproject.com/Articles/1089834/AutoBracketsTextBox
//  Copyright (C) Alaa Ben Fatma, 2016-2017. 

using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
namespace AutoBracketsTextBox
{


    public class AutoBracketsTextBox : TextBox
    {
        /// <summary>
        /// The list of the brackets
        /// </summary>
        public string[] BracketsList { get; set; }
        public bool AllowAutoComplete { get; set; }

        public AutoBracketsTextBox()
        {
            this.KeyPress += OnKeyPress;
            this.Font = new Font("Consolas", 9.75f);
            this.WordWrap = false;
            this.ScrollBars = ScrollBars.Both;
            this.Multiline = true;
            this.AllowAutoComplete = true;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            //Deletes the bracket and it's alternative.
            if (e.KeyCode == Keys.Back)
            {
                //Checks if the length is more than 1 to avoid going under 0.
                if (this.Text.Length > 1 && SelectedText == string.Empty)
                {
                    //Caret Position
                    int sel = SelectionStart;
                    //Gets the bracket on the right side
                    this.Select(sel, 1);
                    var RightBracket = this.SelectedText;

                    //Gets the bracket on the left side
                    this.Select(sel - 1, 1);
                    var LeftBracket = this.SelectedText;

                    if (this.BracketsList.Contains(RightBracket) && this.BracketsList.Contains(LeftBracket))
                        for (int i = 0; i < this.BracketsList.Length; i++)
                        {
                            if (this.BracketsList[i] == LeftBracket && this.BracketsList[i + 1] == RightBracket)
                            {
                                this.Text = this.Text.Remove(sel - 1, 0).Remove(sel, 1);
                                this.Select(sel, 0);
                                e.Handled = true;
                                break;
                            }
                        }
                   
                }
            }
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.AllowAutoComplete)
            {
                String s, RightBracket, LeftBracket = string.Empty;
                s = e.KeyChar.ToString();

                int sel = SelectionStart;
                int i = 0;
                foreach (string item in this.BracketsList)
                {

                    if (item == s
                        && /*This condition is needed to avoid adding an opening bracket after a closing bracket*/
                        (i % 2 == 0))
                    {
                        //Puts the selected text between brackets
                        if (this.SelectedText != "")
                        {
                            LeftBracket = this.BracketsList[i].ToString();
                            RightBracket = this.BracketsList[i + 1].ToString();
                            int SelLength = this.SelectedText.Length;
                            this.SelectedText = LeftBracket + this.SelectedText + RightBracket;
                            e.Handled = true;
                            this.SelectionStart = sel + SelLength + 1;
                        }
                        else
                        {
                            LeftBracket = this.BracketsList[i].ToString();
                            RightBracket = this.BracketsList[i + 1].ToString();
                            Text = Text.Insert(sel, LeftBracket + RightBracket);
                            this.SelectionStart = sel + 1;
                            e.Handled = true;
                        }
                        break;
                    }
                    i++;
                }

            }
        }
    }
}
