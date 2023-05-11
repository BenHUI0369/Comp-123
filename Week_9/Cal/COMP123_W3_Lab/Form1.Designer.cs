namespace COMP123_W3_Lab
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.idField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.phoneField = new System.Windows.Forms.TextBox();
            this.sexField = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idField
            // 
            this.idField.Location = new System.Drawing.Point(195, 64);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(186, 22);
            this.idField.TabIndex = 5;
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(195, 100);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(186, 22);
            this.nameField.TabIndex = 6;
            // 
            // phoneField
            // 
            this.phoneField.Location = new System.Drawing.Point(195, 179);
            this.phoneField.Name = "phoneField";
            this.phoneField.Size = new System.Drawing.Size(186, 22);
            this.phoneField.TabIndex = 7;
            // 
            // sexField
            // 
            this.sexField.FormattingEnabled = true;
            this.sexField.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sexField.Location = new System.Drawing.Point(195, 140);
            this.sexField.Name = "sexField";
            this.sexField.Size = new System.Drawing.Size(186, 20);
            this.sexField.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 325);
            this.Controls.Add(this.sexField);
            this.Controls.Add(this.phoneField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox phoneField;
        private System.Windows.Forms.ComboBox sexField;
    }
}

