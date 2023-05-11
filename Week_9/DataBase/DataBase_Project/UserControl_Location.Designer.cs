namespace DataBase_Project
{
    partial class UserControl_Location
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userBtn_Reset = new System.Windows.Forms.Button();
            this.location_Location = new System.Windows.Forms.Label();
            this.Location_textBox_Location = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userBtn_Reset
            // 
            this.userBtn_Reset.Location = new System.Drawing.Point(136, 333);
            this.userBtn_Reset.Name = "userBtn_Reset";
            this.userBtn_Reset.Size = new System.Drawing.Size(228, 23);
            this.userBtn_Reset.TabIndex = 81;
            this.userBtn_Reset.Text = "Reset";
            this.userBtn_Reset.UseVisualStyleBackColor = true;
            this.userBtn_Reset.Click += new System.EventHandler(this.userBtn_Reset_Click);
            // 
            // location_Location
            // 
            this.location_Location.AutoSize = true;
            this.location_Location.Location = new System.Drawing.Point(48, 24);
            this.location_Location.Name = "location_Location";
            this.location_Location.Size = new System.Drawing.Size(49, 12);
            this.location_Location.TabIndex = 73;
            this.location_Location.Text = "Location:";
            this.location_Location.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Location_textBox_Location
            // 
            this.Location_textBox_Location.Location = new System.Drawing.Point(136, 21);
            this.Location_textBox_Location.Name = "Location_textBox_Location";
            this.Location_textBox_Location.Size = new System.Drawing.Size(228, 22);
            this.Location_textBox_Location.TabIndex = 78;
            // 
            // UserControl_Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.userBtn_Reset);
            this.Controls.Add(this.Location_textBox_Location);
            this.Controls.Add(this.location_Location);
            this.Name = "UserControl_Location";
            this.Size = new System.Drawing.Size(861, 523);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button userBtn_Reset;
        private System.Windows.Forms.Label location_Location;
        private System.Windows.Forms.TextBox Location_textBox_Location;
    }
}
