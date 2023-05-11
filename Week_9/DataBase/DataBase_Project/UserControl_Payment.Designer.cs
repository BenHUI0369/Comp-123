namespace DataBase_Project
{
    partial class UserControl_Payment
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
            this.user_DateOFBirth_YYYY = new System.Windows.Forms.Label();
            this.user_DateOFBirth_MM = new System.Windows.Forms.Label();
            this.user_DateOFBirth_DD = new System.Windows.Forms.Label();
            this.pay_textBox_PID = new System.Windows.Forms.TextBox();
            this.pay_textBox_Account = new System.Windows.Forms.TextBox();
            this.pay_textBox_Status = new System.Windows.Forms.ComboBox();
            this.pay_textBox_MM = new System.Windows.Forms.ComboBox();
            this.pay_textBox_YYYY = new System.Windows.Forms.ComboBox();
            this.pay_textBox_DD = new System.Windows.Forms.ComboBox();
            this.pay_textBox_ID = new System.Windows.Forms.TextBox();
            this.pay_Status = new System.Windows.Forms.Label();
            this.pay_Account = new System.Windows.Forms.Label();
            this.pay_Program_ID = new System.Windows.Forms.Label();
            this.pay_Date = new System.Windows.Forms.Label();
            this.pay_User_ID = new System.Windows.Forms.Label();
            this.pay_ID = new System.Windows.Forms.Label();
            this.pay_textBox_UID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userBtn_Reset
            // 
            this.userBtn_Reset.Location = new System.Drawing.Point(136, 333);
            this.userBtn_Reset.Name = "userBtn_Reset";
            this.userBtn_Reset.Size = new System.Drawing.Size(228, 23);
            this.userBtn_Reset.TabIndex = 62;
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
            this.user_DateOFBirth_YYYY.TabIndex = 61;
            this.user_DateOFBirth_YYYY.Text = "Year";
            // 
            // user_DateOFBirth_MM
            // 
            this.user_DateOFBirth_MM.AutoSize = true;
            this.user_DateOFBirth_MM.Location = new System.Drawing.Point(351, 96);
            this.user_DateOFBirth_MM.Name = "user_DateOFBirth_MM";
            this.user_DateOFBirth_MM.Size = new System.Drawing.Size(39, 12);
            this.user_DateOFBirth_MM.TabIndex = 60;
            this.user_DateOFBirth_MM.Text = "Month/";
            // 
            // user_DateOFBirth_DD
            // 
            this.user_DateOFBirth_DD.AutoSize = true;
            this.user_DateOFBirth_DD.Location = new System.Drawing.Point(191, 96);
            this.user_DateOFBirth_DD.Name = "user_DateOFBirth_DD";
            this.user_DateOFBirth_DD.Size = new System.Drawing.Size(27, 12);
            this.user_DateOFBirth_DD.TabIndex = 59;
            this.user_DateOFBirth_DD.Text = "Day/";
            // 
            // pay_textBox_PID
            // 
            this.pay_textBox_PID.Location = new System.Drawing.Point(136, 129);
            this.pay_textBox_PID.Name = "pay_textBox_PID";
            this.pay_textBox_PID.Size = new System.Drawing.Size(381, 22);
            this.pay_textBox_PID.TabIndex = 58;
            // 
            // pay_textBox_Account
            // 
            this.pay_textBox_Account.Location = new System.Drawing.Point(136, 165);
            this.pay_textBox_Account.Name = "pay_textBox_Account";
            this.pay_textBox_Account.Size = new System.Drawing.Size(145, 22);
            this.pay_textBox_Account.TabIndex = 57;
            // 
            // pay_textBox_Status
            // 
            this.pay_textBox_Status.FormattingEnabled = true;
            this.pay_textBox_Status.Items.AddRange(new object[] {
            "IN-PROGRESS",
            "HANDLED",
            "CANCEL",
            "SUBMITTED"});
            this.pay_textBox_Status.Location = new System.Drawing.Point(136, 201);
            this.pay_textBox_Status.Name = "pay_textBox_Status";
            this.pay_textBox_Status.Size = new System.Drawing.Size(145, 20);
            this.pay_textBox_Status.TabIndex = 56;
            // 
            // pay_textBox_MM
            // 
            this.pay_textBox_MM.FormattingEnabled = true;
            this.pay_textBox_MM.Items.AddRange(new object[] {
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
            this.pay_textBox_MM.Location = new System.Drawing.Point(224, 93);
            this.pay_textBox_MM.Name = "pay_textBox_MM";
            this.pay_textBox_MM.Size = new System.Drawing.Size(121, 20);
            this.pay_textBox_MM.TabIndex = 55;
            // 
            // pay_textBox_YYYY
            // 
            this.pay_textBox_YYYY.FormattingEnabled = true;
            this.pay_textBox_YYYY.Items.AddRange(new object[] {
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
            this.pay_textBox_YYYY.Location = new System.Drawing.Point(396, 93);
            this.pay_textBox_YYYY.Name = "pay_textBox_YYYY";
            this.pay_textBox_YYYY.Size = new System.Drawing.Size(121, 20);
            this.pay_textBox_YYYY.TabIndex = 54;
            // 
            // pay_textBox_DD
            // 
            this.pay_textBox_DD.FormattingEnabled = true;
            this.pay_textBox_DD.Items.AddRange(new object[] {
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
            this.pay_textBox_DD.Location = new System.Drawing.Point(136, 93);
            this.pay_textBox_DD.Name = "pay_textBox_DD";
            this.pay_textBox_DD.Size = new System.Drawing.Size(49, 20);
            this.pay_textBox_DD.TabIndex = 53;
            // 
            // pay_textBox_ID
            // 
            this.pay_textBox_ID.Location = new System.Drawing.Point(136, 21);
            this.pay_textBox_ID.Name = "pay_textBox_ID";
            this.pay_textBox_ID.Size = new System.Drawing.Size(145, 22);
            this.pay_textBox_ID.TabIndex = 52;
            // 
            // pay_Status
            // 
            this.pay_Status.AutoSize = true;
            this.pay_Status.Location = new System.Drawing.Point(35, 204);
            this.pay_Status.Name = "pay_Status";
            this.pay_Status.Size = new System.Drawing.Size(78, 12);
            this.pay_Status.TabIndex = 51;
            this.pay_Status.Text = "Payment Status:";
            // 
            // pay_Account
            // 
            this.pay_Account.AutoSize = true;
            this.pay_Account.Location = new System.Drawing.Point(30, 168);
            this.pay_Account.Name = "pay_Account";
            this.pay_Account.Size = new System.Drawing.Size(90, 12);
            this.pay_Account.TabIndex = 50;
            this.pay_Account.Text = "Payment Account:";
            // 
            // pay_Program_ID
            // 
            this.pay_Program_ID.AutoSize = true;
            this.pay_Program_ID.Location = new System.Drawing.Point(44, 132);
            this.pay_Program_ID.Name = "pay_Program_ID";
            this.pay_Program_ID.Size = new System.Drawing.Size(63, 12);
            this.pay_Program_ID.TabIndex = 49;
            this.pay_Program_ID.Text = "Program ID:";
            // 
            // pay_Date
            // 
            this.pay_Date.AutoSize = true;
            this.pay_Date.Location = new System.Drawing.Point(36, 96);
            this.pay_Date.Name = "pay_Date";
            this.pay_Date.Size = new System.Drawing.Size(72, 12);
            this.pay_Date.TabIndex = 48;
            this.pay_Date.Text = "Payment Date:";
            // 
            // pay_User_ID
            // 
            this.pay_User_ID.AutoSize = true;
            this.pay_User_ID.Location = new System.Drawing.Point(51, 60);
            this.pay_User_ID.Name = "pay_User_ID";
            this.pay_User_ID.Size = new System.Drawing.Size(44, 12);
            this.pay_User_ID.TabIndex = 47;
            this.pay_User_ID.Text = "User ID:";
            // 
            // pay_ID
            // 
            this.pay_ID.AutoSize = true;
            this.pay_ID.Location = new System.Drawing.Point(39, 24);
            this.pay_ID.Name = "pay_ID";
            this.pay_ID.Size = new System.Drawing.Size(63, 12);
            this.pay_ID.TabIndex = 46;
            this.pay_ID.Text = "Payment ID:";
            this.pay_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pay_textBox_UID
            // 
            this.pay_textBox_UID.Location = new System.Drawing.Point(136, 57);
            this.pay_textBox_UID.Name = "pay_textBox_UID";
            this.pay_textBox_UID.Size = new System.Drawing.Size(145, 22);
            this.pay_textBox_UID.TabIndex = 64;
            // 
            // UserControl_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pay_textBox_UID);
            this.Controls.Add(this.userBtn_Reset);
            this.Controls.Add(this.user_DateOFBirth_YYYY);
            this.Controls.Add(this.user_DateOFBirth_MM);
            this.Controls.Add(this.user_DateOFBirth_DD);
            this.Controls.Add(this.pay_textBox_PID);
            this.Controls.Add(this.pay_textBox_Account);
            this.Controls.Add(this.pay_textBox_Status);
            this.Controls.Add(this.pay_textBox_MM);
            this.Controls.Add(this.pay_textBox_YYYY);
            this.Controls.Add(this.pay_textBox_DD);
            this.Controls.Add(this.pay_textBox_ID);
            this.Controls.Add(this.pay_Status);
            this.Controls.Add(this.pay_Account);
            this.Controls.Add(this.pay_Program_ID);
            this.Controls.Add(this.pay_Date);
            this.Controls.Add(this.pay_User_ID);
            this.Controls.Add(this.pay_ID);
            this.Name = "UserControl_Payment";
            this.Size = new System.Drawing.Size(861, 523);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button userBtn_Reset;
        private System.Windows.Forms.Label user_DateOFBirth_YYYY;
        private System.Windows.Forms.Label user_DateOFBirth_MM;
        private System.Windows.Forms.Label user_DateOFBirth_DD;
        private System.Windows.Forms.TextBox pay_textBox_PID;
        private System.Windows.Forms.TextBox pay_textBox_Account;
        private System.Windows.Forms.ComboBox pay_textBox_Status;
        private System.Windows.Forms.ComboBox pay_textBox_MM;
        private System.Windows.Forms.ComboBox pay_textBox_YYYY;
        private System.Windows.Forms.ComboBox pay_textBox_DD;
        private System.Windows.Forms.TextBox pay_textBox_ID;
        private System.Windows.Forms.Label pay_Status;
        private System.Windows.Forms.Label pay_Account;
        private System.Windows.Forms.Label pay_Program_ID;
        private System.Windows.Forms.Label pay_Date;
        private System.Windows.Forms.Label pay_User_ID;
        private System.Windows.Forms.Label pay_ID;
        private System.Windows.Forms.TextBox pay_textBox_UID;
    }
}
