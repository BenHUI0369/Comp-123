namespace DataBase_Project
{
    partial class UserControl_User
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
            this.user_ID = new System.Windows.Forms.Label();
            this.user_Fname = new System.Windows.Forms.Label();
            this.user_Lname = new System.Windows.Forms.Label();
            this.user_DateOFBirth = new System.Windows.Forms.Label();
            this.user_Gender = new System.Windows.Forms.Label();
            this.user_Phone = new System.Windows.Forms.Label();
            this.user_Email = new System.Windows.Forms.Label();
            this.user_textBox_ID = new System.Windows.Forms.TextBox();
            this.user_textBox_Fname = new System.Windows.Forms.TextBox();
            this.user_textBox_Lname = new System.Windows.Forms.TextBox();
            this.user_textBox_DD = new System.Windows.Forms.ComboBox();
            this.user_textBox_YYYY = new System.Windows.Forms.ComboBox();
            this.user_textBox_MM = new System.Windows.Forms.ComboBox();
            this.user_textBox_Gender = new System.Windows.Forms.ComboBox();
            this.user_textBox_Phone = new System.Windows.Forms.TextBox();
            this.user_textBox_Email = new System.Windows.Forms.TextBox();
            this.user_DateOFBirth_DD = new System.Windows.Forms.Label();
            this.user_DateOFBirth_MM = new System.Windows.Forms.Label();
            this.user_DateOFBirth_YYYY = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.user_textBox_Address = new System.Windows.Forms.TextBox();
            this.userBtn_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_ID
            // 
            this.user_ID.AutoSize = true;
            this.user_ID.Location = new System.Drawing.Point(58, 24);
            this.user_ID.Name = "user_ID";
            this.user_ID.Size = new System.Drawing.Size(55, 12);
            this.user_ID.TabIndex = 0;
            this.user_ID.Text = "USER_ID:";
            this.user_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // user_Fname
            // 
            this.user_Fname.AutoSize = true;
            this.user_Fname.Location = new System.Drawing.Point(55, 60);
            this.user_Fname.Name = "user_Fname";
            this.user_Fname.Size = new System.Drawing.Size(58, 12);
            this.user_Fname.TabIndex = 1;
            this.user_Fname.Text = "First Name:";
            // 
            // user_Lname
            // 
            this.user_Lname.AutoSize = true;
            this.user_Lname.Location = new System.Drawing.Point(56, 96);
            this.user_Lname.Name = "user_Lname";
            this.user_Lname.Size = new System.Drawing.Size(57, 12);
            this.user_Lname.TabIndex = 2;
            this.user_Lname.Text = "Last Name:";
            // 
            // user_DateOFBirth
            // 
            this.user_DateOFBirth.AutoSize = true;
            this.user_DateOFBirth.Location = new System.Drawing.Point(44, 132);
            this.user_DateOFBirth.Name = "user_DateOFBirth";
            this.user_DateOFBirth.Size = new System.Drawing.Size(69, 12);
            this.user_DateOFBirth.TabIndex = 3;
            this.user_DateOFBirth.Text = "Date of Birth:";
            // 
            // user_Gender
            // 
            this.user_Gender.AutoSize = true;
            this.user_Gender.Location = new System.Drawing.Point(71, 168);
            this.user_Gender.Name = "user_Gender";
            this.user_Gender.Size = new System.Drawing.Size(42, 12);
            this.user_Gender.TabIndex = 4;
            this.user_Gender.Text = "Gender:";
            // 
            // user_Phone
            // 
            this.user_Phone.AutoSize = true;
            this.user_Phone.Location = new System.Drawing.Point(35, 204);
            this.user_Phone.Name = "user_Phone";
            this.user_Phone.Size = new System.Drawing.Size(78, 12);
            this.user_Phone.TabIndex = 5;
            this.user_Phone.Text = "Phone Number:";
            // 
            // user_Email
            // 
            this.user_Email.AutoSize = true;
            this.user_Email.Location = new System.Drawing.Point(73, 240);
            this.user_Email.Name = "user_Email";
            this.user_Email.Size = new System.Drawing.Size(40, 12);
            this.user_Email.TabIndex = 6;
            this.user_Email.Text = "E-Mail:";
            // 
            // user_textBox_ID
            // 
            this.user_textBox_ID.Location = new System.Drawing.Point(136, 21);
            this.user_textBox_ID.Name = "user_textBox_ID";
            this.user_textBox_ID.Size = new System.Drawing.Size(100, 22);
            this.user_textBox_ID.TabIndex = 7;
            this.user_textBox_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.User_ID_KeyPress);
            // 
            // user_textBox_Fname
            // 
            this.user_textBox_Fname.Location = new System.Drawing.Point(136, 57);
            this.user_textBox_Fname.Name = "user_textBox_Fname";
            this.user_textBox_Fname.Size = new System.Drawing.Size(100, 22);
            this.user_textBox_Fname.TabIndex = 8;
            // 
            // user_textBox_Lname
            // 
            this.user_textBox_Lname.Location = new System.Drawing.Point(136, 93);
            this.user_textBox_Lname.Name = "user_textBox_Lname";
            this.user_textBox_Lname.Size = new System.Drawing.Size(100, 22);
            this.user_textBox_Lname.TabIndex = 9;
            // 
            // user_textBox_DD
            // 
            this.user_textBox_DD.FormattingEnabled = true;
            this.user_textBox_DD.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.user_textBox_DD.Location = new System.Drawing.Point(136, 129);
            this.user_textBox_DD.Name = "user_textBox_DD";
            this.user_textBox_DD.Size = new System.Drawing.Size(49, 20);
            this.user_textBox_DD.TabIndex = 10;
            // 
            // user_textBox_YYYY
            // 
            this.user_textBox_YYYY.FormattingEnabled = true;
            this.user_textBox_YYYY.Items.AddRange(new object[] {
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.user_textBox_YYYY.Location = new System.Drawing.Point(396, 129);
            this.user_textBox_YYYY.Name = "user_textBox_YYYY";
            this.user_textBox_YYYY.Size = new System.Drawing.Size(121, 20);
            this.user_textBox_YYYY.TabIndex = 11;
            // 
            // user_textBox_MM
            // 
            this.user_textBox_MM.FormattingEnabled = true;
            this.user_textBox_MM.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.user_textBox_MM.Location = new System.Drawing.Point(224, 129);
            this.user_textBox_MM.Name = "user_textBox_MM";
            this.user_textBox_MM.Size = new System.Drawing.Size(121, 20);
            this.user_textBox_MM.TabIndex = 12;
            // 
            // user_textBox_Gender
            // 
            this.user_textBox_Gender.FormattingEnabled = true;
            this.user_textBox_Gender.Items.AddRange(new object[] {
            "M",
            "F",
            "O"});
            this.user_textBox_Gender.Location = new System.Drawing.Point(136, 165);
            this.user_textBox_Gender.Name = "user_textBox_Gender";
            this.user_textBox_Gender.Size = new System.Drawing.Size(49, 20);
            this.user_textBox_Gender.TabIndex = 13;
            // 
            // user_textBox_Phone
            // 
            this.user_textBox_Phone.Location = new System.Drawing.Point(136, 201);
            this.user_textBox_Phone.Name = "user_textBox_Phone";
            this.user_textBox_Phone.Size = new System.Drawing.Size(100, 22);
            this.user_textBox_Phone.TabIndex = 14;
            // 
            // user_textBox_Email
            // 
            this.user_textBox_Email.Location = new System.Drawing.Point(136, 237);
            this.user_textBox_Email.Name = "user_textBox_Email";
            this.user_textBox_Email.Size = new System.Drawing.Size(381, 22);
            this.user_textBox_Email.TabIndex = 15;
            // 
            // user_DateOFBirth_DD
            // 
            this.user_DateOFBirth_DD.AutoSize = true;
            this.user_DateOFBirth_DD.Location = new System.Drawing.Point(191, 132);
            this.user_DateOFBirth_DD.Name = "user_DateOFBirth_DD";
            this.user_DateOFBirth_DD.Size = new System.Drawing.Size(27, 12);
            this.user_DateOFBirth_DD.TabIndex = 16;
            this.user_DateOFBirth_DD.Text = "Day/";
            // 
            // user_DateOFBirth_MM
            // 
            this.user_DateOFBirth_MM.AutoSize = true;
            this.user_DateOFBirth_MM.Location = new System.Drawing.Point(351, 132);
            this.user_DateOFBirth_MM.Name = "user_DateOFBirth_MM";
            this.user_DateOFBirth_MM.Size = new System.Drawing.Size(39, 12);
            this.user_DateOFBirth_MM.TabIndex = 17;
            this.user_DateOFBirth_MM.Text = "Month/";
            // 
            // user_DateOFBirth_YYYY
            // 
            this.user_DateOFBirth_YYYY.AutoSize = true;
            this.user_DateOFBirth_YYYY.Location = new System.Drawing.Point(523, 132);
            this.user_DateOFBirth_YYYY.Name = "user_DateOFBirth_YYYY";
            this.user_DateOFBirth_YYYY.Size = new System.Drawing.Size(27, 12);
            this.user_DateOFBirth_YYYY.TabIndex = 18;
            this.user_DateOFBirth_YYYY.Text = "Year";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(68, 281);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(45, 12);
            this.label_Address.TabIndex = 19;
            this.label_Address.Text = "Address:";
            // 
            // user_textBox_Address
            // 
            this.user_textBox_Address.Location = new System.Drawing.Point(136, 278);
            this.user_textBox_Address.Name = "user_textBox_Address";
            this.user_textBox_Address.Size = new System.Drawing.Size(381, 22);
            this.user_textBox_Address.TabIndex = 20;
            // 
            // userBtn_Reset
            // 
            this.userBtn_Reset.Location = new System.Drawing.Point(136, 333);
            this.userBtn_Reset.Name = "userBtn_Reset";
            this.userBtn_Reset.Size = new System.Drawing.Size(228, 23);
            this.userBtn_Reset.TabIndex = 22;
            this.userBtn_Reset.Text = "Reset";
            this.userBtn_Reset.UseVisualStyleBackColor = true;
            this.userBtn_Reset.Click += new System.EventHandler(this.userBtn_Reset_Click);
            // 
            // UserControl_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.userBtn_Reset);
            this.Controls.Add(this.user_textBox_Address);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.user_DateOFBirth_YYYY);
            this.Controls.Add(this.user_DateOFBirth_MM);
            this.Controls.Add(this.user_DateOFBirth_DD);
            this.Controls.Add(this.user_textBox_Email);
            this.Controls.Add(this.user_textBox_Phone);
            this.Controls.Add(this.user_textBox_Gender);
            this.Controls.Add(this.user_textBox_MM);
            this.Controls.Add(this.user_textBox_YYYY);
            this.Controls.Add(this.user_textBox_DD);
            this.Controls.Add(this.user_textBox_Lname);
            this.Controls.Add(this.user_textBox_Fname);
            this.Controls.Add(this.user_textBox_ID);
            this.Controls.Add(this.user_Email);
            this.Controls.Add(this.user_Phone);
            this.Controls.Add(this.user_Gender);
            this.Controls.Add(this.user_DateOFBirth);
            this.Controls.Add(this.user_Lname);
            this.Controls.Add(this.user_Fname);
            this.Controls.Add(this.user_ID);
            this.Name = "UserControl_User";
            this.Size = new System.Drawing.Size(861, 523);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_ID;
        private System.Windows.Forms.Label user_Fname;
        private System.Windows.Forms.Label user_Lname;
        private System.Windows.Forms.Label user_DateOFBirth;
        private System.Windows.Forms.Label user_Gender;
        private System.Windows.Forms.Label user_Phone;
        private System.Windows.Forms.Label user_Email;
        private System.Windows.Forms.TextBox user_textBox_ID;
        private System.Windows.Forms.TextBox user_textBox_Fname;
        private System.Windows.Forms.TextBox user_textBox_Lname;
        private System.Windows.Forms.ComboBox user_textBox_DD;
        private System.Windows.Forms.ComboBox user_textBox_YYYY;
        private System.Windows.Forms.ComboBox user_textBox_MM;
        private System.Windows.Forms.ComboBox user_textBox_Gender;
        private System.Windows.Forms.TextBox user_textBox_Phone;
        private System.Windows.Forms.TextBox user_textBox_Email;
        private System.Windows.Forms.Label user_DateOFBirth_DD;
        private System.Windows.Forms.Label user_DateOFBirth_MM;
        private System.Windows.Forms.Label user_DateOFBirth_YYYY;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.TextBox user_textBox_Address;
        private System.Windows.Forms.Button userBtn_Reset;
    }
}
