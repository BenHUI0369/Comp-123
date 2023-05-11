namespace DataBase_Project
{
    partial class UserControl_Staff
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
            this.staff_textBox_Address = new System.Windows.Forms.TextBox();
            this.staff_Address = new System.Windows.Forms.Label();
            this.user_DateOFBirth_YYYY = new System.Windows.Forms.Label();
            this.user_DateOFBirth_MM = new System.Windows.Forms.Label();
            this.user_DateOFBirth_DD = new System.Windows.Forms.Label();
            this.staff_textBox_Email = new System.Windows.Forms.TextBox();
            this.staff_textBox_Phone = new System.Windows.Forms.TextBox();
            this.staff_textBox_Gender = new System.Windows.Forms.ComboBox();
            this.staff_textBox_MM = new System.Windows.Forms.ComboBox();
            this.staff_textBox_YYYY = new System.Windows.Forms.ComboBox();
            this.staff_textBox_DD = new System.Windows.Forms.ComboBox();
            this.staff_textBox_Lname = new System.Windows.Forms.TextBox();
            this.staff_textBox_Fname = new System.Windows.Forms.TextBox();
            this.staff_textBox_ID = new System.Windows.Forms.TextBox();
            this.staff_Email = new System.Windows.Forms.Label();
            this.staff_Phone = new System.Windows.Forms.Label();
            this.staff_Gender = new System.Windows.Forms.Label();
            this.staff_DateOFBirth = new System.Windows.Forms.Label();
            this.staff_Lname = new System.Windows.Forms.Label();
            this.staff_Fname = new System.Windows.Forms.Label();
            this.staff_ID = new System.Windows.Forms.Label();
            this.staff_textBox_Position = new System.Windows.Forms.TextBox();
            this.staff_Position = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userBtn_Reset
            // 
            this.userBtn_Reset.Location = new System.Drawing.Point(136, 386);
            this.userBtn_Reset.Name = "userBtn_Reset";
            this.userBtn_Reset.Size = new System.Drawing.Size(228, 23);
            this.userBtn_Reset.TabIndex = 44;
            this.userBtn_Reset.Text = "Reset";
            this.userBtn_Reset.UseVisualStyleBackColor = true;
            this.userBtn_Reset.Click += new System.EventHandler(this.userBtn_Reset_Click);
            // 
            // staff_textBox_Address
            // 
            this.staff_textBox_Address.Location = new System.Drawing.Point(136, 324);
            this.staff_textBox_Address.Name = "staff_textBox_Address";
            this.staff_textBox_Address.Size = new System.Drawing.Size(381, 22);
            this.staff_textBox_Address.TabIndex = 43;
            // 
            // staff_Address
            // 
            this.staff_Address.AutoSize = true;
            this.staff_Address.Location = new System.Drawing.Point(71, 327);
            this.staff_Address.Name = "staff_Address";
            this.staff_Address.Size = new System.Drawing.Size(45, 12);
            this.staff_Address.TabIndex = 42;
            this.staff_Address.Text = "Address:";
            // 
            // user_DateOFBirth_YYYY
            // 
            this.user_DateOFBirth_YYYY.AutoSize = true;
            this.user_DateOFBirth_YYYY.Location = new System.Drawing.Point(523, 132);
            this.user_DateOFBirth_YYYY.Name = "user_DateOFBirth_YYYY";
            this.user_DateOFBirth_YYYY.Size = new System.Drawing.Size(27, 12);
            this.user_DateOFBirth_YYYY.TabIndex = 41;
            this.user_DateOFBirth_YYYY.Text = "Year";
            // 
            // user_DateOFBirth_MM
            // 
            this.user_DateOFBirth_MM.AutoSize = true;
            this.user_DateOFBirth_MM.Location = new System.Drawing.Point(351, 132);
            this.user_DateOFBirth_MM.Name = "user_DateOFBirth_MM";
            this.user_DateOFBirth_MM.Size = new System.Drawing.Size(39, 12);
            this.user_DateOFBirth_MM.TabIndex = 40;
            this.user_DateOFBirth_MM.Text = "Month/";
            // 
            // user_DateOFBirth_DD
            // 
            this.user_DateOFBirth_DD.AutoSize = true;
            this.user_DateOFBirth_DD.Location = new System.Drawing.Point(191, 132);
            this.user_DateOFBirth_DD.Name = "user_DateOFBirth_DD";
            this.user_DateOFBirth_DD.Size = new System.Drawing.Size(27, 12);
            this.user_DateOFBirth_DD.TabIndex = 39;
            this.user_DateOFBirth_DD.Text = "Day/";
            // 
            // staff_textBox_Email
            // 
            this.staff_textBox_Email.Location = new System.Drawing.Point(136, 283);
            this.staff_textBox_Email.Name = "staff_textBox_Email";
            this.staff_textBox_Email.Size = new System.Drawing.Size(381, 22);
            this.staff_textBox_Email.TabIndex = 38;
            // 
            // staff_textBox_Phone
            // 
            this.staff_textBox_Phone.Location = new System.Drawing.Point(136, 201);
            this.staff_textBox_Phone.Name = "staff_textBox_Phone";
            this.staff_textBox_Phone.Size = new System.Drawing.Size(100, 22);
            this.staff_textBox_Phone.TabIndex = 37;
            // 
            // staff_textBox_Gender
            // 
            this.staff_textBox_Gender.FormattingEnabled = true;
            this.staff_textBox_Gender.Items.AddRange(new object[] {
            "M",
            "F",
            "O"});
            this.staff_textBox_Gender.Location = new System.Drawing.Point(136, 165);
            this.staff_textBox_Gender.Name = "staff_textBox_Gender";
            this.staff_textBox_Gender.Size = new System.Drawing.Size(49, 20);
            this.staff_textBox_Gender.TabIndex = 36;
            // 
            // staff_textBox_MM
            // 
            this.staff_textBox_MM.FormattingEnabled = true;
            this.staff_textBox_MM.Items.AddRange(new object[] {
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
            this.staff_textBox_MM.Location = new System.Drawing.Point(224, 129);
            this.staff_textBox_MM.Name = "staff_textBox_MM";
            this.staff_textBox_MM.Size = new System.Drawing.Size(121, 20);
            this.staff_textBox_MM.TabIndex = 35;
            // 
            // staff_textBox_YYYY
            // 
            this.staff_textBox_YYYY.FormattingEnabled = true;
            this.staff_textBox_YYYY.Items.AddRange(new object[] {
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
            this.staff_textBox_YYYY.Location = new System.Drawing.Point(396, 129);
            this.staff_textBox_YYYY.Name = "staff_textBox_YYYY";
            this.staff_textBox_YYYY.Size = new System.Drawing.Size(121, 20);
            this.staff_textBox_YYYY.TabIndex = 34;
            // 
            // staff_textBox_DD
            // 
            this.staff_textBox_DD.FormattingEnabled = true;
            this.staff_textBox_DD.Items.AddRange(new object[] {
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
            this.staff_textBox_DD.Location = new System.Drawing.Point(136, 129);
            this.staff_textBox_DD.Name = "staff_textBox_DD";
            this.staff_textBox_DD.Size = new System.Drawing.Size(49, 20);
            this.staff_textBox_DD.TabIndex = 33;
            // 
            // staff_textBox_Lname
            // 
            this.staff_textBox_Lname.Location = new System.Drawing.Point(136, 93);
            this.staff_textBox_Lname.Name = "staff_textBox_Lname";
            this.staff_textBox_Lname.Size = new System.Drawing.Size(100, 22);
            this.staff_textBox_Lname.TabIndex = 32;
            // 
            // staff_textBox_Fname
            // 
            this.staff_textBox_Fname.Location = new System.Drawing.Point(136, 57);
            this.staff_textBox_Fname.Name = "staff_textBox_Fname";
            this.staff_textBox_Fname.Size = new System.Drawing.Size(100, 22);
            this.staff_textBox_Fname.TabIndex = 31;
            // 
            // staff_textBox_ID
            // 
            this.staff_textBox_ID.Location = new System.Drawing.Point(136, 21);
            this.staff_textBox_ID.Name = "staff_textBox_ID";
            this.staff_textBox_ID.Size = new System.Drawing.Size(100, 22);
            this.staff_textBox_ID.TabIndex = 30;
            // 
            // staff_Email
            // 
            this.staff_Email.AutoSize = true;
            this.staff_Email.Location = new System.Drawing.Point(76, 286);
            this.staff_Email.Name = "staff_Email";
            this.staff_Email.Size = new System.Drawing.Size(40, 12);
            this.staff_Email.TabIndex = 29;
            this.staff_Email.Text = "E-Mail:";
            // 
            // staff_Phone
            // 
            this.staff_Phone.AutoSize = true;
            this.staff_Phone.Location = new System.Drawing.Point(38, 204);
            this.staff_Phone.Name = "staff_Phone";
            this.staff_Phone.Size = new System.Drawing.Size(78, 12);
            this.staff_Phone.TabIndex = 28;
            this.staff_Phone.Text = "Phone Number:";
            // 
            // staff_Gender
            // 
            this.staff_Gender.AutoSize = true;
            this.staff_Gender.Location = new System.Drawing.Point(74, 168);
            this.staff_Gender.Name = "staff_Gender";
            this.staff_Gender.Size = new System.Drawing.Size(42, 12);
            this.staff_Gender.TabIndex = 27;
            this.staff_Gender.Text = "Gender:";
            // 
            // staff_DateOFBirth
            // 
            this.staff_DateOFBirth.AutoSize = true;
            this.staff_DateOFBirth.Location = new System.Drawing.Point(47, 132);
            this.staff_DateOFBirth.Name = "staff_DateOFBirth";
            this.staff_DateOFBirth.Size = new System.Drawing.Size(69, 12);
            this.staff_DateOFBirth.TabIndex = 26;
            this.staff_DateOFBirth.Text = "Date of Birth:";
            // 
            // staff_Lname
            // 
            this.staff_Lname.AutoSize = true;
            this.staff_Lname.Location = new System.Drawing.Point(59, 96);
            this.staff_Lname.Name = "staff_Lname";
            this.staff_Lname.Size = new System.Drawing.Size(57, 12);
            this.staff_Lname.TabIndex = 25;
            this.staff_Lname.Text = "Last Name:";
            // 
            // staff_Fname
            // 
            this.staff_Fname.AutoSize = true;
            this.staff_Fname.Location = new System.Drawing.Point(58, 60);
            this.staff_Fname.Name = "staff_Fname";
            this.staff_Fname.Size = new System.Drawing.Size(58, 12);
            this.staff_Fname.TabIndex = 24;
            this.staff_Fname.Text = "First Name:";
            // 
            // staff_ID
            // 
            this.staff_ID.AutoSize = true;
            this.staff_ID.Location = new System.Drawing.Point(71, 24);
            this.staff_ID.Name = "staff_ID";
            this.staff_ID.Size = new System.Drawing.Size(45, 12);
            this.staff_ID.TabIndex = 23;
            this.staff_ID.Text = "Staff ID:";
            this.staff_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // staff_textBox_Position
            // 
            this.staff_textBox_Position.Location = new System.Drawing.Point(136, 241);
            this.staff_textBox_Position.Name = "staff_textBox_Position";
            this.staff_textBox_Position.Size = new System.Drawing.Size(100, 22);
            this.staff_textBox_Position.TabIndex = 46;
            // 
            // staff_Position
            // 
            this.staff_Position.AutoSize = true;
            this.staff_Position.Location = new System.Drawing.Point(71, 244);
            this.staff_Position.Name = "staff_Position";
            this.staff_Position.Size = new System.Drawing.Size(45, 12);
            this.staff_Position.TabIndex = 45;
            this.staff_Position.Text = "Position:";
            // 
            // UserControl_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.staff_textBox_Position);
            this.Controls.Add(this.staff_Position);
            this.Controls.Add(this.userBtn_Reset);
            this.Controls.Add(this.staff_textBox_Address);
            this.Controls.Add(this.staff_Address);
            this.Controls.Add(this.user_DateOFBirth_YYYY);
            this.Controls.Add(this.user_DateOFBirth_MM);
            this.Controls.Add(this.user_DateOFBirth_DD);
            this.Controls.Add(this.staff_textBox_Email);
            this.Controls.Add(this.staff_textBox_Phone);
            this.Controls.Add(this.staff_textBox_Gender);
            this.Controls.Add(this.staff_textBox_MM);
            this.Controls.Add(this.staff_textBox_YYYY);
            this.Controls.Add(this.staff_textBox_DD);
            this.Controls.Add(this.staff_textBox_Lname);
            this.Controls.Add(this.staff_textBox_Fname);
            this.Controls.Add(this.staff_textBox_ID);
            this.Controls.Add(this.staff_Email);
            this.Controls.Add(this.staff_Phone);
            this.Controls.Add(this.staff_Gender);
            this.Controls.Add(this.staff_DateOFBirth);
            this.Controls.Add(this.staff_Lname);
            this.Controls.Add(this.staff_Fname);
            this.Controls.Add(this.staff_ID);
            this.Name = "UserControl_Staff";
            this.Size = new System.Drawing.Size(861, 523);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userBtn_Reset;
        private System.Windows.Forms.TextBox staff_textBox_Address;
        private System.Windows.Forms.Label staff_Address;
        private System.Windows.Forms.Label user_DateOFBirth_YYYY;
        private System.Windows.Forms.Label user_DateOFBirth_MM;
        private System.Windows.Forms.Label user_DateOFBirth_DD;
        private System.Windows.Forms.TextBox staff_textBox_Email;
        private System.Windows.Forms.TextBox staff_textBox_Phone;
        private System.Windows.Forms.ComboBox staff_textBox_Gender;
        private System.Windows.Forms.ComboBox staff_textBox_MM;
        private System.Windows.Forms.ComboBox staff_textBox_YYYY;
        private System.Windows.Forms.ComboBox staff_textBox_DD;
        private System.Windows.Forms.TextBox staff_textBox_Lname;
        private System.Windows.Forms.TextBox staff_textBox_Fname;
        private System.Windows.Forms.TextBox staff_textBox_ID;
        private System.Windows.Forms.Label staff_Email;
        private System.Windows.Forms.Label staff_Phone;
        private System.Windows.Forms.Label staff_Gender;
        private System.Windows.Forms.Label staff_DateOFBirth;
        private System.Windows.Forms.Label staff_Lname;
        private System.Windows.Forms.Label staff_Fname;
        private System.Windows.Forms.Label staff_ID;
        private System.Windows.Forms.TextBox staff_textBox_Position;
        private System.Windows.Forms.Label staff_Position;
    }
}
