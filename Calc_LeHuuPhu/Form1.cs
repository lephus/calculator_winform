using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Calc_LeHuuPhu
{
    public partial class frmPhu : Form
    {
        public frmPhu()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonAc_Click(object sender, EventArgs e)
        {
            // click button ac
            cls_Phu.EvenButonAcOnClick();
            RefreshState("0", "");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            cls_Phu.AddPersonInput("9");
            RefreshState("?", cls_Phu.GetPersonInput());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cls_Phu.AddPersonInput("8");
            RefreshState("?", cls_Phu.GetPersonInput());
        }
        private void button7_Click(object sender, EventArgs e)
        {
            // click button 7
            cls_Phu.AddPersonInput("7");
            RefreshState("?", cls_Phu.GetPersonInput());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cls_Phu.AddPersonInput("6");
            RefreshState("?", cls_Phu.GetPersonInput());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cls_Phu.AddPersonInput("5");
            RefreshState("?", cls_Phu.GetPersonInput());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cls_Phu.AddPersonInput("4");
            RefreshState("?", cls_Phu.GetPersonInput());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cls_Phu.AddPersonInput("3");
            RefreshState("?", cls_Phu.GetPersonInput());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cls_Phu.AddPersonInput("2");
            RefreshState("?", cls_Phu.GetPersonInput());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cls_Phu.AddPersonInput("1");
            RefreshState("?", cls_Phu.GetPersonInput());
        }

        private void button0_Click(object sender, EventArgs e)
        {
            cls_Phu.AddPersonInput("0");
            RefreshState("?", cls_Phu.GetPersonInput());
        }

        private void buttonDoc_Click(object sender, EventArgs e)
        {
            cls_Phu.AddPersonInput(".");
            RefreshState("?", cls_Phu.GetPersonInput());
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            cls_Phu.AddPersonInput("%");
            RefreshState("?", cls_Phu.GetPersonInput());
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            cls_Phu.AddPersonInput("/");
            RefreshState("?", cls_Phu.GetPersonInput());
        }

        private void buttonMuilti_Click(object sender, EventArgs e)
        {
            cls_Phu.AddPersonInput("*");
            RefreshState("?", cls_Phu.GetPersonInput());
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            cls_Phu.AddPersonInput("-");
            RefreshState("?", cls_Phu.GetPersonInput());
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            cls_Phu.AddPersonInput("+");
            RefreshState("?", cls_Phu.GetPersonInput());
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            // click button =
            cls_Phu.SpamButtonDone();
            if (cls_Phu.GetPersonInput().Length > 0)
            {
                cls_Phu.SetIputString(cls_Phu.GetPersonInput()); // Infix To Postfix
                cls_Phu.SetResult(cls_Phu.RuningProcess(cls_Phu.InfixToPostfix(cls_Phu.GetInputString()))); // tinh gia tri bieu thuc hau to
                RefreshState(cls_Phu.GetResult().ToString(), cls_Phu.GetPersonInput());
            }
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            // click +/-
            cls_Phu.SetPersonInput(cls_Phu.SwapOperator(cls_Phu.GetPersonInput()));
            RefreshState("?", cls_Phu.GetPersonInput());
        }

        private void RefreshState(String result, String input)
        {
            if (result.Equals("?"))
            {
                textBoxInput.Text = input;
            }
            else
            {
                if (input.Equals("?"))
                {
                    textBoxResult.Text = result;
                }
                else
                {
                    textBoxResult.Text = result;
                    textBoxInput.Text = input;
                }
            }
        }

        private void frmPhu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
            // action onkeypress backspace
            if (e.KeyChar == (char)8)
            {
                cls_Phu.onkeypressBackspace();
                RefreshState("?", cls_Phu.GetPersonInput());
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            cls_Phu.onkeypressBackspace();
            RefreshState("?", cls_Phu.GetPersonInput());
        }
    }
}
