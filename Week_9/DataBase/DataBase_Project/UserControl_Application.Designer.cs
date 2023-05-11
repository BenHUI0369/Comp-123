namespace DataBase_Project
{
    partial class UserControl_Application
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
            this.app_textBox_UID = new System.Windows.Forms.TextBox();
            this.userBtn_Reset = new System.Windows.Forms.Button();
            this.user_DateOFBirth_YYYY = new System.Windows.Forms.Label();
            this.user_DateOFBirth_MM = new System.Windows.Forms.Label();
            this.user_DateOFBirth_DD = new System.Windows.Forms.Label();
            this.app_textBox_MM = new System.Windows.Forms.ComboBox();
            this.app_textBox_YYYY = new System.Windows.Forms.ComboBox();
            this.app_textBox_DD = new System.Windows.Forms.ComboBox();
            this.app_textBox_ID = new System.Windows.Forms.TextBox();
            this.app_Date = new System.Windows.Forms.Label();
            this.app_User_ID = new System.Windows.Forms.Label();
            this.app_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // app_textBox_UID
            // 
            this.app_textBox_UID.Location = new System.Drawing.Point(136, 57);
            this.app_textBox_UID.Name = "app_textBox_UID";
            this.app_textBox_UID.Size = new System.Drawing.Size(145, 22);
            this.app_textBox_UID.TabIndex = 82;
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
            // user_DateOFBirth_YYYY
            // 
            this.user_DateOFBirth_YYYY.AutoSize = true;
            this.user_DateOFBirth_YYYY.Location = new System.Drawing.Point(523, 96);
            this.user_DateOFBirth_YYYY.Name = "user_DateOFBirth_YYYY";
            this.user_DateOFBirth_YYYY.Size = new System.Drawing.Size(27, 12);
            this.user_DateOFBirth_YYYY.TabIndex = 80;
            this.user_DateOFBirth_YYYY.Text = "Year";
            // 
            // user_DateOFBirth_MM
            // 
            this.user_DateOFBirth_MM.AutoSize = true;
            this.user_DateOFBirth_MM.Location = new System.Drawing.Point(351, 96);
            this.user_DateOFBirth_MM.Name = "user_DateOFBirth_MM";
            this.user_DateOFBirth_MM.Size = new System.Drawing.Size(39, 12);
            this.user_DateOFBirth_MM.TabIndex = 79;
            this.user_DateOFBirth_MM.Text = "Month/";
            // 
            // user_DateOFBirth_DD
            // 
            this.user_DateOFBirth_DD.AutoSize = true;
            this.user_DateOFBirth_DD.Location = new System.Drawing.Point(191, 96);
            this.user_DateOFBirth_DD.Name = "user_DateOFBirth_DD";
            this.user_DateOFBirth_DD.Size = new System.Drawing.Size(27, 12);
            this.user_DateOFBirth_DD.TabIndex = 78;
            this.user_DateOFBirth_DD.Text = "Day/";
            // 
            // app_textBox_MM
            // 
            this.app_textBox_MM.FormattingEnabled = true;
            this.app_textBox_MM.Items.AddRange(new object[] {
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
            this.app_textBox_MM.Location = new System.Drawing.Point(224, 93);
            this.app_textBox_MM.Name = "app_textBox_MM";
            this.app_textBox_MM.Size = new System.Drawing.Size(121, 20);
            this.app_textBox_MM.TabIndex = 74;
            // 
            // app_textBox_YYYY
            // 
            this.app_textBox_YYYY.FormattingEnabled = true;
            this.app_textBox_YYYY.Items.AddRange(new object[] {
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
            this.app_textBox_YYYY.Location = new System.Drawing.Point(396, 93);
            this.app_textBox_YYYY.Name = "app_textBox_YYYY";
            this.app_textBox_YYYY.Size = new System.Drawing.Size(121, 20);
            this.app_textBox_YYYY.TabIndex = 73;
            // 
            // app_textBox_DD
            // 
            this.app_textBox_DD.FormattingEnabled = true;
            this.app_textBox_DD.Items.AddRange(new object[] {
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
            this.app_textBox_DD.Location = new System.Drawing.Point(136, 93);
            this.app_textBox_DD.Name = "app_textBox_DD";
            this.app_textBox_DD.Size = new System.Drawing.Size(49, 20);
            this.app_textBox_DD.TabIndex = 72;
            // 
            // app_textBox_ID
            // 
            this.app_textBox_ID.Location = new System.Drawing.Point(136, 21);
            this.app_textBox_ID.Name = "app_textBox_ID";
            this.app_textBox_ID.Size = new System.Drawing.Size(145, 22);
            this.app_textBox_ID.TabIndex = 71;
            // 
            // app_Date
            // 
            this.app_Date.AutoSize = true;
            this.app_Date.Location = new System.Drawing.Point(36, 96);
            this.app_Date.Name = "app_Date";
            this.app_Date.Size = new System.Drawing.Size(86, 12);
            this.app_Date.TabIndex = 67;
            this.app_Date.Text = "Application Date:";
            // 
            // app_User_ID
            // 
            this.app_User_ID.AutoSize = true;
            this.app_User_ID.Location = new System.Drawing.Point(51, 60);
            this.app_User_ID.Name = "app_User_ID";
            this.app_User_ID.Size = new System.Drawing.Size(44, 12);
            this.app_User_ID.TabIndex = 66;
            this.app_User_ID.Text = "User ID:";
            // 
            // app_ID
            // 
            this.app_ID.AutoSize = true;
            this.app_ID.Location = new System.Drawing.Point(39, 24);
            this.app_ID.Name = "app_ID";
            this.app_ID.Size = new System.Drawing.Size(77, 12);
            this.app_ID.TabIndex = 65;
            this.app_ID.Text = "Application ID:";
            this.app_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UserControl_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.app_textBox_UID);
            this.Controls.Add(this.userBtn_Reset);
            this.Controls.Add(this.user_DateOFBirth_YYYY);
            this.Controls.Add(this.user_DateOFBirth_MM);
            this.Controls.Add(this.user_DateOFBirth_DD);
            this.Controls.Add(this.app_textBox_MM);
            this.Controls.Add(this.app_textBox_YYYY);
            this.Controls.Add(this.app_textBox_DD);
            this.Controls.Add(this.app_textBox_ID);
            this.Controls.Add(this.app_Date);
            this.Controls.Add(this.app_User_ID);
            this.Controls.Add(this.app_ID);
            this.Name = "UserControl_Application";
            this.Size = new System.Drawing.Size(861, 523);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox app_textBox_UID;
        private System.Windows.Forms.Button userBtn_Reset;
        private System.Windows.Forms.Label user_DateOFBirth_YYYY;
        private System.Windows.Forms.Label user_DateOFBirth_MM;
        private System.Windows.Forms.Label user_DateOFBirth_DD;
        private System.Windows.Forms.ComboBox app_textBox_MM;
        private System.Windows.Forms.ComboBox app_textBox_YYYY;
        private System.Windows.Forms.ComboBox app_textBox_DD;
        private System.Windows.Forms.TextBox app_textBox_ID;
        private System.Windows.Forms.Label app_Date;
        private System.Windows.Forms.Label app_User_ID;
        private System.Windows.Forms.Label app_ID;
    }
}
