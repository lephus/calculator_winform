
namespace Calc_LeHuuPhu
{
    partial class frmPhu
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
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonAc = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMuilti = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDoc = new System.Windows.Forms.Button();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxResult.Location = new System.Drawing.Point(11, 12);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(270, 38);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.Text = "0";
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            // 
            // textBoxInput
            // 
            this.textBoxInput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxInput.Location = new System.Drawing.Point(10, 49);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(249, 35);
            this.textBoxInput.TabIndex = 1;
            this.textBoxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            // 
            // buttonAc
            // 
            this.buttonAc.BackColor = System.Drawing.Color.Gold;
            this.buttonAc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAc.Location = new System.Drawing.Point(11, 94);
            this.buttonAc.Name = "buttonAc";
            this.buttonAc.Size = new System.Drawing.Size(63, 56);
            this.buttonAc.TabIndex = 3;
            this.buttonAc.Text = "ac";
            this.buttonAc.UseVisualStyleBackColor = false;
            this.buttonAc.Click += new System.EventHandler(this.buttonAc_Click);
            this.buttonAc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            // 
            // buttonMod
            // 
            this.buttonMod.BackColor = System.Drawing.Color.Gold;
            this.buttonMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMod.Location = new System.Drawing.Point(80, 94);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(63, 56);
            this.buttonMod.TabIndex = 4;
            this.buttonMod.Text = "%";
            this.buttonMod.UseVisualStyleBackColor = false;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            this.buttonMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            // 
            // buttonDiv
            // 
            this.buttonDiv.BackColor = System.Drawing.Color.Gold;
            this.buttonDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiv.Location = new System.Drawing.Point(149, 94);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(63, 56);
            this.buttonDiv.TabIndex = 5;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = false;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            this.buttonDiv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            // 
            // buttonMuilti
            // 
            this.buttonMuilti.BackColor = System.Drawing.Color.Gold;
            this.buttonMuilti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMuilti.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMuilti.Location = new System.Drawing.Point(218, 94);
            this.buttonMuilti.Name = "buttonMuilti";
            this.buttonMuilti.Size = new System.Drawing.Size(63, 56);
            this.buttonMuilti.TabIndex = 6;
            this.buttonMuilti.Text = "*";
            this.buttonMuilti.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMuilti.UseVisualStyleBackColor = false;
            this.buttonMuilti.Click += new System.EventHandler(this.buttonMuilti_Click);
            this.buttonMuilti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            // 
            // Sub
            // 
            this.Sub.BackColor = System.Drawing.Color.Gold;
            this.Sub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sub.Location = new System.Drawing.Point(216, 156);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(63, 56);
            this.Sub.TabIndex = 7;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = false;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            this.Sub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            // 
            // buttonSum
            // 
            this.buttonSum.BackColor = System.Drawing.Color.Gold;
            this.buttonSum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSum.Location = new System.Drawing.Point(216, 218);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(63, 56);
            this.buttonSum.TabIndex = 8;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = false;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            this.buttonSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Gold;
            this.buttonDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDone.Location = new System.Drawing.Point(216, 280);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(63, 116);
            this.buttonDone.TabIndex = 9;
            this.buttonDone.Text = "=";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Fuchsia;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(147, 156);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(63, 56);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            this.button9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Fuchsia;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(78, 156);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(63, 56);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            this.button8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Fuchsia;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(9, 156);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(63, 56);
            this.button7.TabIndex = 11;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Fuchsia;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(147, 218);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 56);
            this.button6.TabIndex = 12;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Fuchsia;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(78, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 56);
            this.button5.TabIndex = 13;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Fuchsia;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(9, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 56);
            this.button4.TabIndex = 14;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Fuchsia;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(147, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 56);
            this.button3.TabIndex = 15;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Fuchsia;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(78, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 56);
            this.button2.TabIndex = 16;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 56);
            this.button1.TabIndex = 17;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Fuchsia;
            this.button0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(9, 340);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(63, 56);
            this.button0.TabIndex = 18;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            this.button0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            // 
            // buttonDoc
            // 
            this.buttonDoc.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDoc.Location = new System.Drawing.Point(78, 340);
            this.buttonDoc.Name = "buttonDoc";
            this.buttonDoc.Size = new System.Drawing.Size(63, 56);
            this.buttonDoc.TabIndex = 19;
            this.buttonDoc.Text = ",";
            this.buttonDoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDoc.UseVisualStyleBackColor = false;
            this.buttonDoc.Click += new System.EventHandler(this.buttonDoc_Click);
            this.buttonDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            // 
            // buttonSwap
            // 
            this.buttonSwap.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonSwap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSwap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSwap.Location = new System.Drawing.Point(147, 340);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(63, 56);
            this.buttonSwap.TabIndex = 20;
            this.buttonSwap.Text = "+/-";
            this.buttonSwap.UseVisualStyleBackColor = false;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            this.buttonSwap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(258, 49);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(23, 35);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // frmPhu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(291, 405);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSwap);
            this.Controls.Add(this.buttonDoc);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.buttonMuilti);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.buttonAc);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.textBoxResult);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPhu";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhu";
            this.Enter += new System.EventHandler(this.buttonDone_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPhu_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonAc;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMuilti;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDoc;
        private System.Windows.Forms.Button buttonSwap;
        private Cls_Phu cls_Phu = new Cls_Phu();
        private System.Windows.Forms.Button buttonBack;
    }
}

