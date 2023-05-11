namespace DataBase_Project
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Save_As_File = new System.Windows.Forms.Button();
            this.button_Add_List_Item = new System.Windows.Forms.Button();
            this.show_List_Item_Number = new System.Windows.Forms.Label();
            this.show_Selected_List = new System.Windows.Forms.Label();
            this.list_Item_Number = new System.Windows.Forms.Label();
            this.selected_List = new System.Windows.Forms.Label();
            this.radioBtn_Location = new System.Windows.Forms.RadioButton();
            this.radioBtn_College = new System.Windows.Forms.RadioButton();
            this.radioBtn_Staff = new System.Windows.Forms.RadioButton();
            this.radioBtn_Course = new System.Windows.Forms.RadioButton();
            this.radioBtn_Program = new System.Windows.Forms.RadioButton();
            this.radioBtn_Request_Handle = new System.Windows.Forms.RadioButton();
            this.radioBtn_Admission = new System.Windows.Forms.RadioButton();
            this.radioBtn_Application = new System.Windows.Forms.RadioButton();
            this.radioBtn_Payment = new System.Windows.Forms.RadioButton();
            this.radioBtn_Ser_Request = new System.Windows.Forms.RadioButton();
            this.radioBtn_user = new System.Windows.Forms.RadioButton();
            this.userControl_Staff1 = new DataBase_Project.UserControl_Staff();
            this.userControl_Ser_Request1 = new DataBase_Project.UserControl_Ser_Request();
            this.userControl_Request_Handle1 = new DataBase_Project.UserControl_Request_Handle();
            this.userControl_Program1 = new DataBase_Project.UserControl_Program();
            this.userControl_Payment1 = new DataBase_Project.UserControl_Payment();
            this.userControl_Location1 = new DataBase_Project.UserControl_Location();
            this.userControl_Course1 = new DataBase_Project.UserControl_Course();
            this.userControl_College1 = new DataBase_Project.UserControl_College();
            this.userControl_Application1 = new DataBase_Project.UserControl_Application();
            this.userControl_Admission1 = new DataBase_Project.UserControl_Admission();
            this.userControl_User1 = new DataBase_Project.UserControl_User();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button_Save_As_File);
            this.panel1.Controls.Add(this.button_Add_List_Item);
            this.panel1.Controls.Add(this.show_List_Item_Number);
            this.panel1.Controls.Add(this.show_Selected_List);
            this.panel1.Controls.Add(this.list_Item_Number);
            this.panel1.Controls.Add(this.selected_List);
            this.panel1.Controls.Add(this.radioBtn_Location);
            this.panel1.Controls.Add(this.radioBtn_College);
            this.panel1.Controls.Add(this.radioBtn_Staff);
            this.panel1.Controls.Add(this.radioBtn_Course);
            this.panel1.Controls.Add(this.radioBtn_Program);
            this.panel1.Controls.Add(this.radioBtn_Request_Handle);
            this.panel1.Controls.Add(this.radioBtn_Admission);
            this.panel1.Controls.Add(this.radioBtn_Application);
            this.panel1.Controls.Add(this.radioBtn_Payment);
            this.panel1.Controls.Add(this.radioBtn_Ser_Request);
            this.panel1.Controls.Add(this.radioBtn_user);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 450);
            this.panel1.TabIndex = 0;
            // 
            // button_Save_As_File
            // 
            this.button_Save_As_File.Location = new System.Drawing.Point(13, 332);
            this.button_Save_As_File.Name = "button_Save_As_File";
            this.button_Save_As_File.Size = new System.Drawing.Size(168, 23);
            this.button_Save_As_File.TabIndex = 16;
            this.button_Save_As_File.Text = "Save As File";
            this.button_Save_As_File.UseVisualStyleBackColor = true;
            this.button_Save_As_File.Click += new System.EventHandler(this.button_Save_As_File_Click);
            // 
            // button_Add_List_Item
            // 
            this.button_Add_List_Item.Location = new System.Drawing.Point(13, 283);
            this.button_Add_List_Item.Name = "button_Add_List_Item";
            this.button_Add_List_Item.Size = new System.Drawing.Size(168, 23);
            this.button_Add_List_Item.TabIndex = 15;
            this.button_Add_List_Item.Text = "Add to List";
            this.button_Add_List_Item.UseVisualStyleBackColor = true;
            this.button_Add_List_Item.Click += new System.EventHandler(this.button_Show_List_Item_Click);
            // 
            // show_List_Item_Number
            // 
            this.show_List_Item_Number.AutoSize = true;
            this.show_List_Item_Number.Location = new System.Drawing.Point(125, 401);
            this.show_List_Item_Number.Name = "show_List_Item_Number";
            this.show_List_Item_Number.Size = new System.Drawing.Size(33, 12);
            this.show_List_Item_Number.TabIndex = 14;
            this.show_List_Item_Number.Text = "label2";
            // 
            // show_Selected_List
            // 
            this.show_Selected_List.AutoSize = true;
            this.show_Selected_List.Location = new System.Drawing.Point(126, 385);
            this.show_Selected_List.Name = "show_Selected_List";
            this.show_Selected_List.Size = new System.Drawing.Size(33, 12);
            this.show_Selected_List.TabIndex = 13;
            this.show_Selected_List.Text = "label1";
            // 
            // list_Item_Number
            // 
            this.list_Item_Number.AutoSize = true;
            this.list_Item_Number.Location = new System.Drawing.Point(6, 401);
            this.list_Item_Number.Name = "list_Item_Number";
            this.list_Item_Number.Size = new System.Drawing.Size(115, 12);
            this.list_Item_Number.TabIndex = 12;
            this.list_Item_Number.Text = "Number of Item in List:";
            // 
            // selected_List
            // 
            this.selected_List.AutoSize = true;
            this.selected_List.Location = new System.Drawing.Point(55, 385);
            this.selected_List.Name = "selected_List";
            this.selected_List.Size = new System.Drawing.Size(66, 12);
            this.selected_List.TabIndex = 11;
            this.selected_List.Text = "Selected List:";
            // 
            // radioBtn_Location
            // 
            this.radioBtn_Location.AutoSize = true;
            this.radioBtn_Location.Location = new System.Drawing.Point(13, 243);
            this.radioBtn_Location.Name = "radioBtn_Location";
            this.radioBtn_Location.Size = new System.Drawing.Size(123, 16);
            this.radioBtn_Location.TabIndex = 10;
            this.radioBtn_Location.TabStop = true;
            this.radioBtn_Location.Text = "COMM_LOCATION";
            this.radioBtn_Location.UseVisualStyleBackColor = true;
            this.radioBtn_Location.CheckedChanged += new System.EventHandler(this.RadioBtnCheckedChanged);
            // 
            // radioBtn_College
            // 
            this.radioBtn_College.AutoSize = true;
            this.radioBtn_College.Location = new System.Drawing.Point(13, 220);
            this.radioBtn_College.Name = "radioBtn_College";
            this.radioBtn_College.Size = new System.Drawing.Size(117, 16);
            this.radioBtn_College.TabIndex = 9;
            this.radioBtn_College.TabStop = true;
            this.radioBtn_College.Text = "COMM_COLLEGE";
            this.radioBtn_College.UseVisualStyleBackColor = true;
            this.radioBtn_College.CheckedChanged += new System.EventHandler(this.RadioBtnCheckedChanged);
            // 
            // radioBtn_Staff
            // 
            this.radioBtn_Staff.AutoSize = true;
            this.radioBtn_Staff.Location = new System.Drawing.Point(13, 197);
            this.radioBtn_Staff.Name = "radioBtn_Staff";
            this.radioBtn_Staff.Size = new System.Drawing.Size(98, 16);
            this.radioBtn_Staff.TabIndex = 8;
            this.radioBtn_Staff.TabStop = true;
            this.radioBtn_Staff.Text = "COMM_STAFF";
            this.radioBtn_Staff.UseVisualStyleBackColor = true;
            this.radioBtn_Staff.CheckedChanged += new System.EventHandler(this.RadioBtnCheckedChanged);
            // 
            // radioBtn_Course
            // 
            this.radioBtn_Course.AutoSize = true;
            this.radioBtn_Course.Location = new System.Drawing.Point(13, 174);
            this.radioBtn_Course.Name = "radioBtn_Course";
            this.radioBtn_Course.Size = new System.Drawing.Size(102, 16);
            this.radioBtn_Course.TabIndex = 7;
            this.radioBtn_Course.TabStop = true;
            this.radioBtn_Course.Text = "COMM_COUSE";
            this.radioBtn_Course.UseVisualStyleBackColor = true;
            this.radioBtn_Course.CheckedChanged += new System.EventHandler(this.RadioBtnCheckedChanged);
            // 
            // radioBtn_Program
            // 
            this.radioBtn_Program.AutoSize = true;
            this.radioBtn_Program.Location = new System.Drawing.Point(13, 151);
            this.radioBtn_Program.Name = "radioBtn_Program";
            this.radioBtn_Program.Size = new System.Drawing.Size(121, 16);
            this.radioBtn_Program.TabIndex = 6;
            this.radioBtn_Program.TabStop = true;
            this.radioBtn_Program.Text = "COMM_PROGRAM";
            this.radioBtn_Program.UseVisualStyleBackColor = true;
            this.radioBtn_Program.CheckedChanged += new System.EventHandler(this.RadioBtnCheckedChanged);
            // 
            // radioBtn_Request_Handle
            // 
            this.radioBtn_Request_Handle.AutoSize = true;
            this.radioBtn_Request_Handle.Location = new System.Drawing.Point(13, 128);
            this.radioBtn_Request_Handle.Name = "radioBtn_Request_Handle";
            this.radioBtn_Request_Handle.Size = new System.Drawing.Size(168, 16);
            this.radioBtn_Request_Handle.TabIndex = 5;
            this.radioBtn_Request_Handle.TabStop = true;
            this.radioBtn_Request_Handle.Text = "COMM_REQUEST_HANDLE";
            this.radioBtn_Request_Handle.UseVisualStyleBackColor = true;
            this.radioBtn_Request_Handle.CheckedChanged += new System.EventHandler(this.RadioBtnCheckedChanged);
            // 
            // radioBtn_Admission
            // 
            this.radioBtn_Admission.AutoSize = true;
            this.radioBtn_Admission.Location = new System.Drawing.Point(13, 105);
            this.radioBtn_Admission.Name = "radioBtn_Admission";
            this.radioBtn_Admission.Size = new System.Drawing.Size(127, 16);
            this.radioBtn_Admission.TabIndex = 4;
            this.radioBtn_Admission.TabStop = true;
            this.radioBtn_Admission.Text = "COMM_ADMISSION";
            this.radioBtn_Admission.UseVisualStyleBackColor = true;
            this.radioBtn_Admission.CheckedChanged += new System.EventHandler(this.RadioBtnCheckedChanged);
            // 
            // radioBtn_Application
            // 
            this.radioBtn_Application.AutoSize = true;
            this.radioBtn_Application.Location = new System.Drawing.Point(13, 82);
            this.radioBtn_Application.Name = "radioBtn_Application";
            this.radioBtn_Application.Size = new System.Drawing.Size(139, 16);
            this.radioBtn_Application.TabIndex = 3;
            this.radioBtn_Application.TabStop = true;
            this.radioBtn_Application.Text = "COMM_APPLICATION";
            this.radioBtn_Application.UseVisualStyleBackColor = true;
            this.radioBtn_Application.CheckedChanged += new System.EventHandler(this.RadioBtnCheckedChanged);
            // 
            // radioBtn_Payment
            // 
            this.radioBtn_Payment.AutoSize = true;
            this.radioBtn_Payment.Location = new System.Drawing.Point(13, 59);
            this.radioBtn_Payment.Name = "radioBtn_Payment";
            this.radioBtn_Payment.Size = new System.Drawing.Size(119, 16);
            this.radioBtn_Payment.TabIndex = 2;
            this.radioBtn_Payment.TabStop = true;
            this.radioBtn_Payment.Text = "COMM_PAYMENT";
            this.radioBtn_Payment.UseVisualStyleBackColor = true;
            this.radioBtn_Payment.CheckedChanged += new System.EventHandler(this.RadioBtnCheckedChanged);
            // 
            // radioBtn_Ser_Request
            // 
            this.radioBtn_Ser_Request.AutoSize = true;
            this.radioBtn_Ser_Request.Location = new System.Drawing.Point(13, 36);
            this.radioBtn_Ser_Request.Name = "radioBtn_Ser_Request";
            this.radioBtn_Ser_Request.Size = new System.Drawing.Size(143, 16);
            this.radioBtn_Ser_Request.TabIndex = 1;
            this.radioBtn_Ser_Request.TabStop = true;
            this.radioBtn_Ser_Request.Text = "COMM_SER_REQUEST";
            this.radioBtn_Ser_Request.UseVisualStyleBackColor = true;
            this.radioBtn_Ser_Request.CheckedChanged += new System.EventHandler(this.RadioBtnCheckedChanged);
            // 
            // radioBtn_user
            // 
            this.radioBtn_user.AutoSize = true;
            this.radioBtn_user.Location = new System.Drawing.Point(13, 13);
            this.radioBtn_user.Name = "radioBtn_user";
            this.radioBtn_user.Size = new System.Drawing.Size(94, 16);
            this.radioBtn_user.TabIndex = 0;
            this.radioBtn_user.TabStop = true;
            this.radioBtn_user.Text = "COMM_USER";
            this.radioBtn_user.UseVisualStyleBackColor = true;
            this.radioBtn_user.CheckedChanged += new System.EventHandler(this.RadioBtnCheckedChanged);
            // 
            // userControl_Staff1
            // 
            this.userControl_Staff1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userControl_Staff1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Staff1.Location = new System.Drawing.Point(201, 0);
            this.userControl_Staff1.Name = "userControl_Staff1";
            this.userControl_Staff1.Size = new System.Drawing.Size(599, 450);
            this.userControl_Staff1.TabIndex = 11;
            // 
            // userControl_Ser_Request1
            // 
            this.userControl_Ser_Request1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userControl_Ser_Request1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Ser_Request1.Location = new System.Drawing.Point(201, 0);
            this.userControl_Ser_Request1.Name = "userControl_Ser_Request1";
            this.userControl_Ser_Request1.Size = new System.Drawing.Size(599, 450);
            this.userControl_Ser_Request1.TabIndex = 10;
            // 
            // userControl_Request_Handle1
            // 
            this.userControl_Request_Handle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userControl_Request_Handle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Request_Handle1.Location = new System.Drawing.Point(201, 0);
            this.userControl_Request_Handle1.Name = "userControl_Request_Handle1";
            this.userControl_Request_Handle1.Size = new System.Drawing.Size(599, 450);
            this.userControl_Request_Handle1.TabIndex = 9;
            // 
            // userControl_Program1
            // 
            this.userControl_Program1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userControl_Program1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Program1.Location = new System.Drawing.Point(201, 0);
            this.userControl_Program1.Name = "userControl_Program1";
            this.userControl_Program1.Size = new System.Drawing.Size(599, 450);
            this.userControl_Program1.TabIndex = 8;
            // 
            // userControl_Payment1
            // 
            this.userControl_Payment1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userControl_Payment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Payment1.Location = new System.Drawing.Point(201, 0);
            this.userControl_Payment1.Name = "userControl_Payment1";
            this.userControl_Payment1.Size = new System.Drawing.Size(599, 450);
            this.userControl_Payment1.TabIndex = 7;
            // 
            // userControl_Location1
            // 
            this.userControl_Location1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userControl_Location1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Location1.Location = new System.Drawing.Point(201, 0);
            this.userControl_Location1.Name = "userControl_Location1";
            this.userControl_Location1.Size = new System.Drawing.Size(599, 450);
            this.userControl_Location1.TabIndex = 6;
            // 
            // userControl_Course1
            // 
            this.userControl_Course1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userControl_Course1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Course1.Location = new System.Drawing.Point(201, 0);
            this.userControl_Course1.Name = "userControl_Course1";
            this.userControl_Course1.Size = new System.Drawing.Size(599, 450);
            this.userControl_Course1.TabIndex = 5;
            // 
            // userControl_College1
            // 
            this.userControl_College1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userControl_College1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_College1.Location = new System.Drawing.Point(201, 0);
            this.userControl_College1.Name = "userControl_College1";
            this.userControl_College1.Size = new System.Drawing.Size(599, 450);
            this.userControl_College1.TabIndex = 4;
            // 
            // userControl_Application1
            // 
            this.userControl_Application1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userControl_Application1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Application1.Location = new System.Drawing.Point(201, 0);
            this.userControl_Application1.Name = "userControl_Application1";
            this.userControl_Application1.Size = new System.Drawing.Size(599, 450);
            this.userControl_Application1.TabIndex = 3;
            // 
            // userControl_Admission1
            // 
            this.userControl_Admission1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userControl_Admission1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Admission1.Location = new System.Drawing.Point(201, 0);
            this.userControl_Admission1.Name = "userControl_Admission1";
            this.userControl_Admission1.Size = new System.Drawing.Size(599, 450);
            this.userControl_Admission1.TabIndex = 2;
            // 
            // userControl_User1
            // 
            this.userControl_User1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userControl_User1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_User1.Location = new System.Drawing.Point(201, 0);
            this.userControl_User1.Name = "userControl_User1";
            this.userControl_User1.Size = new System.Drawing.Size(599, 450);
            this.userControl_User1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl_Staff1);
            this.Controls.Add(this.userControl_Ser_Request1);
            this.Controls.Add(this.userControl_Request_Handle1);
            this.Controls.Add(this.userControl_Program1);
            this.Controls.Add(this.userControl_Payment1);
            this.Controls.Add(this.userControl_Location1);
            this.Controls.Add(this.userControl_Course1);
            this.Controls.Add(this.userControl_College1);
            this.Controls.Add(this.userControl_Application1);
            this.Controls.Add(this.userControl_Admission1);
            this.Controls.Add(this.userControl_User1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBtn_Location;
        private System.Windows.Forms.RadioButton radioBtn_College;
        private System.Windows.Forms.RadioButton radioBtn_Staff;
        private System.Windows.Forms.RadioButton radioBtn_Course;
        private System.Windows.Forms.RadioButton radioBtn_Program;
        private System.Windows.Forms.RadioButton radioBtn_Request_Handle;
        private System.Windows.Forms.RadioButton radioBtn_Admission;
        private System.Windows.Forms.RadioButton radioBtn_Application;
        private System.Windows.Forms.RadioButton radioBtn_Payment;
        private System.Windows.Forms.RadioButton radioBtn_Ser_Request;
        private System.Windows.Forms.RadioButton radioBtn_user;
        private UserControl_User userControl_User1;
        private UserControl_Admission userControl_Admission1;
        private UserControl_Application userControl_Application1;
        private UserControl_College userControl_College1;
        private UserControl_Course userControl_Course1;
        private UserControl_Location userControl_Location1;
        private UserControl_Payment userControl_Payment1;
        private UserControl_Program userControl_Program1;
        private UserControl_Request_Handle userControl_Request_Handle1;
        private UserControl_Ser_Request userControl_Ser_Request1;
        private UserControl_Staff userControl_Staff1;
        private System.Windows.Forms.Label selected_List;
        private System.Windows.Forms.Label list_Item_Number;
        private System.Windows.Forms.Label show_List_Item_Number;
        private System.Windows.Forms.Label show_Selected_List;
        private System.Windows.Forms.Button button_Save_As_File;
        private System.Windows.Forms.Button button_Add_List_Item;
    }
}

