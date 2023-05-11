namespace COMP123_W9__Lab_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFirst1 = new System.Windows.Forms.TextBox();
            this.textBoxFirst2 = new System.Windows.Forms.TextBox();
            this.textBoxSec1 = new System.Windows.Forms.TextBox();
            this.textBoxSec2 = new System.Windows.Forms.TextBox();
            this.textBoxResult1 = new System.Windows.Forms.TextBox();
            this.textBoxResult2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioBtnAdd = new System.Windows.Forms.RadioButton();
            this.radioBtnSub = new System.Windows.Forms.RadioButton();
            this.radioBtnMulti = new System.Windows.Forms.RadioButton();
            this.radioBtnDev = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Cal = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFirst1
            // 
            this.textBoxFirst1.Location = new System.Drawing.Point(9, 58);
            this.textBoxFirst1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFirst1.Name = "textBoxFirst1";
            this.textBoxFirst1.Size = new System.Drawing.Size(32, 23);
            this.textBoxFirst1.TabIndex = 0;
            this.textBoxFirst1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxFirst2
            // 
            this.textBoxFirst2.Location = new System.Drawing.Point(51, 58);
            this.textBoxFirst2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFirst2.Name = "textBoxFirst2";
            this.textBoxFirst2.Size = new System.Drawing.Size(32, 23);
            this.textBoxFirst2.TabIndex = 1;
            this.textBoxFirst2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxSec1
            // 
            this.textBoxSec1.Location = new System.Drawing.Point(160, 58);
            this.textBoxSec1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSec1.Name = "textBoxSec1";
            this.textBoxSec1.Size = new System.Drawing.Size(32, 23);
            this.textBoxSec1.TabIndex = 7;
            this.textBoxSec1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxSec2
            // 
            this.textBoxSec2.Location = new System.Drawing.Point(201, 58);
            this.textBoxSec2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSec2.Name = "textBoxSec2";
            this.textBoxSec2.Size = new System.Drawing.Size(32, 23);
            this.textBoxSec2.TabIndex = 8;
            this.textBoxSec2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxResult1
            // 
            this.textBoxResult1.Enabled = false;
            this.textBoxResult1.Location = new System.Drawing.Point(298, 58);
            this.textBoxResult1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxResult1.Name = "textBoxResult1";
            this.textBoxResult1.ReadOnly = true;
            this.textBoxResult1.Size = new System.Drawing.Size(32, 23);
            this.textBoxResult1.TabIndex = 11;
            this.textBoxResult1.TabStop = false;
            // 
            // textBoxResult2
            // 
            this.textBoxResult2.Location = new System.Drawing.Point(339, 58);
            this.textBoxResult2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxResult2.Name = "textBoxResult2";
            this.textBoxResult2.ReadOnly = true;
            this.textBoxResult2.Size = new System.Drawing.Size(32, 23);
            this.textBoxResult2.TabIndex = 12;
            this.textBoxResult2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "/";
            // 
            // radioBtnAdd
            // 
            this.radioBtnAdd.AutoSize = true;
            this.radioBtnAdd.Location = new System.Drawing.Point(10, 2);
            this.radioBtnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnAdd.Name = "radioBtnAdd";
            this.radioBtnAdd.Size = new System.Drawing.Size(33, 19);
            this.radioBtnAdd.TabIndex = 3;
            this.radioBtnAdd.TabStop = true;
            this.radioBtnAdd.Text = "+";
            this.radioBtnAdd.UseVisualStyleBackColor = true;
            this.radioBtnAdd.CheckedChanged += new System.EventHandler(this.radionBtn_CheckedChanged);
            // 
            // radioBtnSub
            // 
            this.radioBtnSub.AutoSize = true;
            this.radioBtnSub.Location = new System.Drawing.Point(10, 30);
            this.radioBtnSub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnSub.Name = "radioBtnSub";
            this.radioBtnSub.Size = new System.Drawing.Size(30, 19);
            this.radioBtnSub.TabIndex = 4;
            this.radioBtnSub.TabStop = true;
            this.radioBtnSub.Text = "-";
            this.radioBtnSub.UseVisualStyleBackColor = true;
            this.radioBtnSub.CheckedChanged += new System.EventHandler(this.radionBtn_CheckedChanged);
            // 
            // radioBtnMulti
            // 
            this.radioBtnMulti.AutoSize = true;
            this.radioBtnMulti.Location = new System.Drawing.Point(10, 58);
            this.radioBtnMulti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnMulti.Name = "radioBtnMulti";
            this.radioBtnMulti.Size = new System.Drawing.Size(30, 19);
            this.radioBtnMulti.TabIndex = 5;
            this.radioBtnMulti.TabStop = true;
            this.radioBtnMulti.Text = "*";
            this.radioBtnMulti.UseVisualStyleBackColor = true;
            this.radioBtnMulti.CheckedChanged += new System.EventHandler(this.radionBtn_CheckedChanged);
            // 
            // radioBtnDev
            // 
            this.radioBtnDev.AutoSize = true;
            this.radioBtnDev.Location = new System.Drawing.Point(10, 85);
            this.radioBtnDev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnDev.Name = "radioBtnDev";
            this.radioBtnDev.Size = new System.Drawing.Size(30, 19);
            this.radioBtnDev.TabIndex = 6;
            this.radioBtnDev.TabStop = true;
            this.radioBtnDev.Text = "/";
            this.radioBtnDev.UseVisualStyleBackColor = true;
            this.radioBtnDev.CheckedChanged += new System.EventHandler(this.radionBtn_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "First";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Second";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Result";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "=";
            // 
            // button_Cal
            // 
            this.button_Cal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Cal.Location = new System.Drawing.Point(9, 123);
            this.button_Cal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Cal.Name = "button_Cal";
            this.button_Cal.Size = new System.Drawing.Size(222, 23);
            this.button_Cal.TabIndex = 9;
            this.button_Cal.Text = "Perform Operation";
            this.button_Cal.UseVisualStyleBackColor = false;
            this.button_Cal.Click += new System.EventHandler(this.button_Cal_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Clear.Location = new System.Drawing.Point(236, 123);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(73, 23);
            this.button_Clear.TabIndex = 10;
            this.button_Clear.Text = "Reset";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBtnAdd);
            this.panel1.Controls.Add(this.radioBtnSub);
            this.panel1.Controls.Add(this.radioBtnMulti);
            this.panel1.Controls.Add(this.radioBtnDev);
            this.panel1.Location = new System.Drawing.Point(95, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(49, 109);
            this.panel1.TabIndex = 2;
            this.panel1.TabStop = true;
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_Save.Location = new System.Drawing.Point(312, 123);
            this.button_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(73, 23);
            this.button_Save.TabIndex = 17;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(394, 171);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Cal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResult2);
            this.Controls.Add(this.textBoxResult1);
            this.Controls.Add(this.textBoxSec2);
            this.Controls.Add(this.textBoxSec1);
            this.Controls.Add(this.textBoxFirst2);
            this.Controls.Add(this.textBoxFirst1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Fraction Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxFirst1;
        private TextBox textBoxFirst2;
        private TextBox textBoxSec1;
        private TextBox textBoxSec2;
        private TextBox textBoxResult1;
        private TextBox textBoxResult2;
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton radioBtnAdd;
        private RadioButton radioBtnSub;
        private RadioButton radioBtnMulti;
        private RadioButton radioBtnDev;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button_Cal;
        private Button button_Clear;
        private Panel panel1;
        private Button button_Save;
    }
}