namespace DataBase_Project
{
    partial class UserControl_Course
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
            this.course_textBox_Course_Level = new System.Windows.Forms.ComboBox();
            this.course_textBox_PID = new System.Windows.Forms.TextBox();
            this.course_textBox_ID = new System.Windows.Forms.TextBox();
            this.course_Level = new System.Windows.Forms.Label();
            this.course_Credit = new System.Windows.Forms.Label();
            this.course_Desc = new System.Windows.Forms.Label();
            this.course_Name = new System.Windows.Forms.Label();
            this.course_PID = new System.Windows.Forms.Label();
            this.course_ID = new System.Windows.Forms.Label();
            this.course_textBox_Name = new System.Windows.Forms.TextBox();
            this.course_textBox_Desc = new System.Windows.Forms.TextBox();
            this.course_textBox_Course_Credit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // userBtn_Reset
            // 
            this.userBtn_Reset.Location = new System.Drawing.Point(136, 333);
            this.userBtn_Reset.Name = "userBtn_Reset";
            this.userBtn_Reset.Size = new System.Drawing.Size(228, 23);
            this.userBtn_Reset.TabIndex = 57;
            this.userBtn_Reset.Text = "Reset";
            this.userBtn_Reset.UseVisualStyleBackColor = true;
            this.userBtn_Reset.Click += new System.EventHandler(this.userBtn_Reset_Click);
            // 
            // course_textBox_Course_Level
            // 
            this.course_textBox_Course_Level.FormattingEnabled = true;
            this.course_textBox_Course_Level.Items.AddRange(new object[] {
            "HIGH",
            "NORMAL",
            "LOW"});
            this.course_textBox_Course_Level.Location = new System.Drawing.Point(137, 201);
            this.course_textBox_Course_Level.Name = "course_textBox_Course_Level";
            this.course_textBox_Course_Level.Size = new System.Drawing.Size(100, 20);
            this.course_textBox_Course_Level.TabIndex = 55;
            // 
            // course_textBox_PID
            // 
            this.course_textBox_PID.Location = new System.Drawing.Point(136, 57);
            this.course_textBox_PID.Name = "course_textBox_PID";
            this.course_textBox_PID.Size = new System.Drawing.Size(228, 22);
            this.course_textBox_PID.TabIndex = 52;
            // 
            // course_textBox_ID
            // 
            this.course_textBox_ID.Location = new System.Drawing.Point(136, 21);
            this.course_textBox_ID.Name = "course_textBox_ID";
            this.course_textBox_ID.Size = new System.Drawing.Size(100, 22);
            this.course_textBox_ID.TabIndex = 51;
            // 
            // course_Level
            // 
            this.course_Level.AutoSize = true;
            this.course_Level.Location = new System.Drawing.Point(45, 204);
            this.course_Level.Name = "course_Level";
            this.course_Level.Size = new System.Drawing.Size(70, 12);
            this.course_Level.TabIndex = 50;
            this.course_Level.Text = "Course Level:";
            // 
            // course_Credit
            // 
            this.course_Credit.AutoSize = true;
            this.course_Credit.Location = new System.Drawing.Point(42, 168);
            this.course_Credit.Name = "course_Credit";
            this.course_Credit.Size = new System.Drawing.Size(73, 12);
            this.course_Credit.TabIndex = 49;
            this.course_Credit.Text = "Course Credit:";
            // 
            // course_Desc
            // 
            this.course_Desc.AutoSize = true;
            this.course_Desc.Location = new System.Drawing.Point(54, 132);
            this.course_Desc.Name = "course_Desc";
            this.course_Desc.Size = new System.Drawing.Size(61, 12);
            this.course_Desc.TabIndex = 48;
            this.course_Desc.Text = "Description:";
            // 
            // course_Name
            // 
            this.course_Name.AutoSize = true;
            this.course_Name.Location = new System.Drawing.Point(44, 96);
            this.course_Name.Name = "course_Name";
            this.course_Name.Size = new System.Drawing.Size(71, 12);
            this.course_Name.TabIndex = 47;
            this.course_Name.Text = "Course Name:";
            // 
            // course_PID
            // 
            this.course_PID.AutoSize = true;
            this.course_PID.Location = new System.Drawing.Point(52, 60);
            this.course_PID.Name = "course_PID";
            this.course_PID.Size = new System.Drawing.Size(63, 12);
            this.course_PID.TabIndex = 46;
            this.course_PID.Text = "Program ID:";
            // 
            // course_ID
            // 
            this.course_ID.AutoSize = true;
            this.course_ID.Location = new System.Drawing.Point(59, 24);
            this.course_ID.Name = "course_ID";
            this.course_ID.Size = new System.Drawing.Size(56, 12);
            this.course_ID.TabIndex = 45;
            this.course_ID.Text = "Course ID:";
            this.course_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // course_textBox_Name
            // 
            this.course_textBox_Name.Location = new System.Drawing.Point(137, 93);
            this.course_textBox_Name.Name = "course_textBox_Name";
            this.course_textBox_Name.Size = new System.Drawing.Size(228, 22);
            this.course_textBox_Name.TabIndex = 58;
            // 
            // course_textBox_Desc
            // 
            this.course_textBox_Desc.Location = new System.Drawing.Point(137, 129);
            this.course_textBox_Desc.Name = "course_textBox_Desc";
            this.course_textBox_Desc.Size = new System.Drawing.Size(228, 22);
            this.course_textBox_Desc.TabIndex = 59;
            // 
            // course_textBox_Course_Credit
            // 
            this.course_textBox_Course_Credit.FormattingEnabled = true;
            this.course_textBox_Course_Credit.Items.AddRange(new object[] {
            "2.0",
            "2.5",
            "3.0",
            "3.5",
            "4.0"});
            this.course_textBox_Course_Credit.Location = new System.Drawing.Point(137, 165);
            this.course_textBox_Course_Credit.Name = "course_textBox_Course_Credit";
            this.course_textBox_Course_Credit.Size = new System.Drawing.Size(100, 20);
            this.course_textBox_Course_Credit.TabIndex = 60;
            // 
            // UserControl_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.course_textBox_Course_Credit);
            this.Controls.Add(this.course_textBox_Desc);
            this.Controls.Add(this.course_textBox_Name);
            this.Controls.Add(this.userBtn_Reset);
            this.Controls.Add(this.course_textBox_Course_Level);
            this.Controls.Add(this.course_textBox_PID);
            this.Controls.Add(this.course_textBox_ID);
            this.Controls.Add(this.course_Level);
            this.Controls.Add(this.course_Credit);
            this.Controls.Add(this.course_Desc);
            this.Controls.Add(this.course_Name);
            this.Controls.Add(this.course_PID);
            this.Controls.Add(this.course_ID);
            this.Name = "UserControl_Course";
            this.Size = new System.Drawing.Size(861, 523);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userBtn_Reset;
        private System.Windows.Forms.ComboBox course_textBox_Course_Level;
        private System.Windows.Forms.TextBox course_textBox_PID;
        private System.Windows.Forms.TextBox course_textBox_ID;
        private System.Windows.Forms.Label course_Level;
        private System.Windows.Forms.Label course_Credit;
        private System.Windows.Forms.Label course_Desc;
        private System.Windows.Forms.Label course_Name;
        private System.Windows.Forms.Label course_PID;
        private System.Windows.Forms.Label course_ID;
        private System.Windows.Forms.TextBox course_textBox_Name;
        private System.Windows.Forms.TextBox course_textBox_Desc;
        private System.Windows.Forms.ComboBox course_textBox_Course_Credit;
    }
}
