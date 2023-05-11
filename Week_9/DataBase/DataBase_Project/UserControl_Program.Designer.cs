namespace DataBase_Project
{
    partial class UserControl_Program
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
            this.program_textBox_College_ID = new System.Windows.Forms.TextBox();
            this.program_textBox_Coop = new System.Windows.Forms.ComboBox();
            this.program_textBox_Type = new System.Windows.Forms.ComboBox();
            this.program_textBox_Duration = new System.Windows.Forms.ComboBox();
            this.program_textBox_Name = new System.Windows.Forms.TextBox();
            this.program_textBox_ID = new System.Windows.Forms.TextBox();
            this.program_College_ID = new System.Windows.Forms.Label();
            this.program_Coop = new System.Windows.Forms.Label();
            this.program_tDuration = new System.Windows.Forms.Label();
            this.program_Type = new System.Windows.Forms.Label();
            this.program_Name = new System.Windows.Forms.Label();
            this.program_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userBtn_Reset
            // 
            this.userBtn_Reset.Location = new System.Drawing.Point(136, 333);
            this.userBtn_Reset.Name = "userBtn_Reset";
            this.userBtn_Reset.Size = new System.Drawing.Size(228, 23);
            this.userBtn_Reset.TabIndex = 44;
            this.userBtn_Reset.Text = "Reset";
            this.userBtn_Reset.UseVisualStyleBackColor = true;
            this.userBtn_Reset.Click += new System.EventHandler(this.userBtn_Reset_Click);
            // 
            // program_textBox_College_ID
            // 
            this.program_textBox_College_ID.Location = new System.Drawing.Point(136, 201);
            this.program_textBox_College_ID.Name = "program_textBox_College_ID";
            this.program_textBox_College_ID.Size = new System.Drawing.Size(100, 22);
            this.program_textBox_College_ID.TabIndex = 37;
            // 
            // program_textBox_Coop
            // 
            this.program_textBox_Coop.FormattingEnabled = true;
            this.program_textBox_Coop.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.program_textBox_Coop.Location = new System.Drawing.Point(136, 165);
            this.program_textBox_Coop.Name = "program_textBox_Coop";
            this.program_textBox_Coop.Size = new System.Drawing.Size(100, 20);
            this.program_textBox_Coop.TabIndex = 36;
            // 
            // program_textBox_Type
            // 
            this.program_textBox_Type.FormattingEnabled = true;
            this.program_textBox_Type.Items.AddRange(new object[] {
            "CERTIFICATE",
            "DIPLOMA",
            "DEGREE",
            "GRADUATE_CERTIFICATE"});
            this.program_textBox_Type.Location = new System.Drawing.Point(137, 93);
            this.program_textBox_Type.Name = "program_textBox_Type";
            this.program_textBox_Type.Size = new System.Drawing.Size(99, 20);
            this.program_textBox_Type.TabIndex = 35;
            // 
            // program_textBox_Duration
            // 
            this.program_textBox_Duration.FormattingEnabled = true;
            this.program_textBox_Duration.Items.AddRange(new object[] {
            "1-YEAR",
            "2-YEAR",
            "3-YEAR",
            "4-YEAR"});
            this.program_textBox_Duration.Location = new System.Drawing.Point(136, 129);
            this.program_textBox_Duration.Name = "program_textBox_Duration";
            this.program_textBox_Duration.Size = new System.Drawing.Size(100, 20);
            this.program_textBox_Duration.TabIndex = 33;
            // 
            // program_textBox_Name
            // 
            this.program_textBox_Name.Location = new System.Drawing.Point(136, 57);
            this.program_textBox_Name.Name = "program_textBox_Name";
            this.program_textBox_Name.Size = new System.Drawing.Size(228, 22);
            this.program_textBox_Name.TabIndex = 31;
            // 
            // program_textBox_ID
            // 
            this.program_textBox_ID.Location = new System.Drawing.Point(136, 21);
            this.program_textBox_ID.Name = "program_textBox_ID";
            this.program_textBox_ID.Size = new System.Drawing.Size(100, 22);
            this.program_textBox_ID.TabIndex = 30;
            // 
            // program_College_ID
            // 
            this.program_College_ID.AutoSize = true;
            this.program_College_ID.Location = new System.Drawing.Point(45, 204);
            this.program_College_ID.Name = "program_College_ID";
            this.program_College_ID.Size = new System.Drawing.Size(59, 12);
            this.program_College_ID.TabIndex = 28;
            this.program_College_ID.Text = "College ID:";
            // 
            // program_Coop
            // 
            this.program_Coop.AutoSize = true;
            this.program_Coop.Location = new System.Drawing.Point(70, 168);
            this.program_Coop.Name = "program_Coop";
            this.program_Coop.Size = new System.Drawing.Size(34, 12);
            this.program_Coop.TabIndex = 27;
            this.program_Coop.Text = "Coop:";
            // 
            // program_tDuration
            // 
            this.program_tDuration.AutoSize = true;
            this.program_tDuration.Location = new System.Drawing.Point(55, 132);
            this.program_tDuration.Name = "program_tDuration";
            this.program_tDuration.Size = new System.Drawing.Size(49, 12);
            this.program_tDuration.TabIndex = 26;
            this.program_tDuration.Text = "Duration:";
            // 
            // program_Type
            // 
            this.program_Type.AutoSize = true;
            this.program_Type.Location = new System.Drawing.Point(29, 96);
            this.program_Type.Name = "program_Type";
            this.program_Type.Size = new System.Drawing.Size(75, 12);
            this.program_Type.TabIndex = 25;
            this.program_Type.Text = "Program Type:";
            // 
            // program_Name
            // 
            this.program_Name.AutoSize = true;
            this.program_Name.Location = new System.Drawing.Point(26, 60);
            this.program_Name.Name = "program_Name";
            this.program_Name.Size = new System.Drawing.Size(78, 12);
            this.program_Name.TabIndex = 24;
            this.program_Name.Text = "Program Name:";
            // 
            // program_ID
            // 
            this.program_ID.AutoSize = true;
            this.program_ID.Location = new System.Drawing.Point(41, 24);
            this.program_ID.Name = "program_ID";
            this.program_ID.Size = new System.Drawing.Size(63, 12);
            this.program_ID.TabIndex = 23;
            this.program_ID.Text = "Program ID:";
            this.program_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UserControl_Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.userBtn_Reset);
            this.Controls.Add(this.program_textBox_College_ID);
            this.Controls.Add(this.program_textBox_Coop);
            this.Controls.Add(this.program_textBox_Type);
            this.Controls.Add(this.program_textBox_Duration);
            this.Controls.Add(this.program_textBox_Name);
            this.Controls.Add(this.program_textBox_ID);
            this.Controls.Add(this.program_College_ID);
            this.Controls.Add(this.program_Coop);
            this.Controls.Add(this.program_tDuration);
            this.Controls.Add(this.program_Type);
            this.Controls.Add(this.program_Name);
            this.Controls.Add(this.program_ID);
            this.Name = "UserControl_Program";
            this.Size = new System.Drawing.Size(861, 523);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userBtn_Reset;
        private System.Windows.Forms.TextBox program_textBox_College_ID;
        private System.Windows.Forms.ComboBox program_textBox_Coop;
        private System.Windows.Forms.ComboBox program_textBox_Type;
        private System.Windows.Forms.ComboBox program_textBox_Duration;
        private System.Windows.Forms.TextBox program_textBox_Name;
        private System.Windows.Forms.TextBox program_textBox_ID;
        private System.Windows.Forms.Label program_College_ID;
        private System.Windows.Forms.Label program_Coop;
        private System.Windows.Forms.Label program_tDuration;
        private System.Windows.Forms.Label program_Type;
        private System.Windows.Forms.Label program_Name;
        private System.Windows.Forms.Label program_ID;
    }
}
