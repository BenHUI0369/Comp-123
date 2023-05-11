namespace WinFormsApp1
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
            this.listBox_name = new System.Windows.Forms.ListBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_life = new System.Windows.Forms.Label();
            this.label_start_end = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_name
            // 
            this.listBox_name.FormattingEnabled = true;
            this.listBox_name.ItemHeight = 15;
            this.listBox_name.Location = new System.Drawing.Point(220, 6);
            this.listBox_name.Name = "listBox_name";
            this.listBox_name.Size = new System.Drawing.Size(120, 214);
            this.listBox_name.TabIndex = 0;
            this.listBox_name.SelectedValueChanged += new System.EventHandler(this.ListBox_selectValueChanged);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(7, 6);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(39, 15);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label_life
            // 
            this.label_life.AutoSize = true;
            this.label_life.Location = new System.Drawing.Point(7, 160);
            this.label_life.Name = "label_life";
            this.label_life.Size = new System.Drawing.Size(23, 15);
            this.label_life.TabIndex = 3;
            this.label_life.Text = "life";
            // 
            // label_start_end
            // 
            this.label_start_end.AutoSize = true;
            this.label_start_end.Location = new System.Drawing.Point(7, 181);
            this.label_start_end.Name = "label_start_end";
            this.label_start_end.Size = new System.Drawing.Size(50, 15);
            this.label_start_end.TabIndex = 4;
            this.label_start_end.Text = "startEnd";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 244);
            this.Controls.Add(this.label_start_end);
            this.Controls.Add(this.label_life);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.listBox_name);
            this.Name = "Form1";
            this.Text = "Ontario\'s Premiers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox_name;
        private Label label_Name;
        private PictureBox pictureBox1;
        private Label label_life;
        private Label label_start_end;
    }
}