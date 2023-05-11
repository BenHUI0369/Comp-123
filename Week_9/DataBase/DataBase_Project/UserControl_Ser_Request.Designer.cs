namespace DataBase_Project
{
    partial class UserControl_Ser_Request
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
            this.req_textBox_Desc = new System.Windows.Forms.TextBox();
            this.reqtor_textBox_ID = new System.Windows.Forms.TextBox();
            this.req_textBox_Status = new System.Windows.Forms.ComboBox();
            this.req_textBox_MM = new System.Windows.Forms.ComboBox();
            this.req_textBox_YYYY = new System.Windows.Forms.ComboBox();
            this.req_textBox_DD = new System.Windows.Forms.ComboBox();
            this.req_textBox_ID = new System.Windows.Forms.TextBox();
            this.Requestor_ID = new System.Windows.Forms.Label();
            this.Request_Status = new System.Windows.Forms.Label();
            this.Request_Desc = new System.Windows.Forms.Label();
            this.Request_Date = new System.Windows.Forms.Label();
            this.Request_Type = new System.Windows.Forms.Label();
            this.Req_ID = new System.Windows.Forms.Label();
            this.req_textBox_Type = new System.Windows.Forms.ComboBox();
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
            // user_DateOFBirth_YYYY
            // 
            this.user_DateOFBirth_YYYY.AutoSize = true;
            this.user_DateOFBirth_YYYY.Location = new System.Drawing.Point(523, 96);
            this.user_DateOFBirth_YYYY.Name = "user_DateOFBirth_YYYY";
            this.user_DateOFBirth_YYYY.Size = new System.Drawing.Size(27, 12);
            this.user_DateOFBirth_YYYY.TabIndex = 41;
            this.user_DateOFBirth_YYYY.Text = "Year";
            // 
            // user_DateOFBirth_MM
            // 
            this.user_DateOFBirth_MM.AutoSize = true;
            this.user_DateOFBirth_MM.Location = new System.Drawing.Point(351, 96);
            this.user_DateOFBirth_MM.Name = "user_DateOFBirth_MM";
            this.user_DateOFBirth_MM.Size = new System.Drawing.Size(39, 12);
            this.user_DateOFBirth_MM.TabIndex = 40;
            this.user_DateOFBirth_MM.Text = "Month/";
            // 
            // user_DateOFBirth_DD
            // 
            this.user_DateOFBirth_DD.AutoSize = true;
            this.user_DateOFBirth_DD.Location = new System.Drawing.Point(191, 96);
            this.user_DateOFBirth_DD.Name = "user_DateOFBirth_DD";
            this.user_DateOFBirth_DD.Size = new System.Drawing.Size(27, 12);
            this.user_DateOFBirth_DD.TabIndex = 39;
            this.user_DateOFBirth_DD.Text = "Day/";
            // 
            // req_textBox_Desc
            // 
            this.req_textBox_Desc.Location = new System.Drawing.Point(136, 129);
            this.req_textBox_Desc.Name = "req_textBox_Desc";
            this.req_textBox_Desc.Size = new System.Drawing.Size(381, 22);
            this.req_textBox_Desc.TabIndex = 38;
            // 
            // reqtor_textBox_ID
            // 
            this.reqtor_textBox_ID.Location = new System.Drawing.Point(136, 201);
            this.reqtor_textBox_ID.Name = "reqtor_textBox_ID";
            this.reqtor_textBox_ID.Size = new System.Drawing.Size(145, 22);
            this.reqtor_textBox_ID.TabIndex = 37;
            // 
            // req_textBox_Status
            // 
            this.req_textBox_Status.FormattingEnabled = true;
            this.req_textBox_Status.Items.AddRange(new object[] {
            "IN-PROGRESS",
            "HANDLED",
            "CANCEL",
            "SUBMITTED"});
            this.req_textBox_Status.Location = new System.Drawing.Point(136, 165);
            this.req_textBox_Status.Name = "req_textBox_Status";
            this.req_textBox_Status.Size = new System.Drawing.Size(145, 20);
            this.req_textBox_Status.TabIndex = 36;
            // 
            // req_textBox_MM
            // 
            this.req_textBox_MM.FormattingEnabled = true;
            this.req_textBox_MM.Items.AddRange(new object[] {
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
            this.req_textBox_MM.Location = new System.Drawing.Point(224, 93);
            this.req_textBox_MM.Name = "req_textBox_MM";
            this.req_textBox_MM.Size = new System.Drawing.Size(121, 20);
            this.req_textBox_MM.TabIndex = 35;
            // 
            // req_textBox_YYYY
            // 
            this.req_textBox_YYYY.FormattingEnabled = true;
            this.req_textBox_YYYY.Items.AddRange(new object[] {
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
            this.req_textBox_YYYY.Location = new System.Drawing.Point(396, 93);
            this.req_textBox_YYYY.Name = "req_textBox_YYYY";
            this.req_textBox_YYYY.Size = new System.Drawing.Size(121, 20);
            this.req_textBox_YYYY.TabIndex = 34;
            // 
            // req_textBox_DD
            // 
            this.req_textBox_DD.FormattingEnabled = true;
            this.req_textBox_DD.Items.AddRange(new object[] {
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
            this.req_textBox_DD.Location = new System.Drawing.Point(136, 93);
            this.req_textBox_DD.Name = "req_textBox_DD";
            this.req_textBox_DD.Size = new System.Drawing.Size(49, 20);
            this.req_textBox_DD.TabIndex = 33;
            // 
            // req_textBox_ID
            // 
            this.req_textBox_ID.Location = new System.Drawing.Point(136, 21);
            this.req_textBox_ID.Name = "req_textBox_ID";
            this.req_textBox_ID.Size = new System.Drawing.Size(145, 22);
            this.req_textBox_ID.TabIndex = 30;
            // 
            // Requestor_ID
            // 
            this.Requestor_ID.AutoSize = true;
            this.Requestor_ID.Location = new System.Drawing.Point(35, 204);
            this.Requestor_ID.Name = "Requestor_ID";
            this.Requestor_ID.Size = new System.Drawing.Size(70, 12);
            this.Requestor_ID.TabIndex = 28;
            this.Requestor_ID.Text = "Requestor ID:";
            // 
            // Request_Status
            // 
            this.Request_Status.AutoSize = true;
            this.Request_Status.Location = new System.Drawing.Point(30, 168);
            this.Request_Status.Name = "Request_Status";
            this.Request_Status.Size = new System.Drawing.Size(75, 12);
            this.Request_Status.TabIndex = 27;
            this.Request_Status.Text = "Request Status:";
            // 
            // Request_Desc
            // 
            this.Request_Desc.AutoSize = true;
            this.Request_Desc.Location = new System.Drawing.Point(44, 132);
            this.Request_Desc.Name = "Request_Desc";
            this.Request_Desc.Size = new System.Drawing.Size(61, 12);
            this.Request_Desc.TabIndex = 26;
            this.Request_Desc.Text = "Description:";
            // 
            // Request_Date
            // 
            this.Request_Date.AutoSize = true;
            this.Request_Date.Location = new System.Drawing.Point(36, 96);
            this.Request_Date.Name = "Request_Date";
            this.Request_Date.Size = new System.Drawing.Size(69, 12);
            this.Request_Date.TabIndex = 25;
            this.Request_Date.Text = "Request Date:";
            // 
            // Request_Type
            // 
            this.Request_Type.AutoSize = true;
            this.Request_Type.Location = new System.Drawing.Point(51, 60);
            this.Request_Type.Name = "Request_Type";
            this.Request_Type.Size = new System.Drawing.Size(54, 12);
            this.Request_Type.TabIndex = 24;
            this.Request_Type.Text = "Req Type:";
            // 
            // Req_ID
            // 
            this.Req_ID.AutoSize = true;
            this.Req_ID.Location = new System.Drawing.Point(39, 24);
            this.Req_ID.Name = "Req_ID";
            this.Req_ID.Size = new System.Drawing.Size(66, 12);
            this.Req_ID.TabIndex = 23;
            this.Req_ID.Text = "Ser_Req_ID:";
            this.Req_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // req_textBox_Type
            // 
            this.req_textBox_Type.FormattingEnabled = true;
            this.req_textBox_Type.Items.AddRange(new object[] {
            "ADMISSION",
            "REGISTRATION",
            "ACCOUNT-RALATED",
            "PAYMENT",
            "OTHERS"});
            this.req_textBox_Type.Location = new System.Drawing.Point(136, 57);
            this.req_textBox_Type.Name = "req_textBox_Type";
            this.req_textBox_Type.Size = new System.Drawing.Size(145, 20);
            this.req_textBox_Type.TabIndex = 45;
            // 
            // UserControl_Ser_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.req_textBox_Type);
            this.Controls.Add(this.userBtn_Reset);
            this.Controls.Add(this.user_DateOFBirth_YYYY);
            this.Controls.Add(this.user_DateOFBirth_MM);
            this.Controls.Add(this.user_DateOFBirth_DD);
            this.Controls.Add(this.req_textBox_Desc);
            this.Controls.Add(this.reqtor_textBox_ID);
            this.Controls.Add(this.req_textBox_Status);
            this.Controls.Add(this.req_textBox_MM);
            this.Controls.Add(this.req_textBox_YYYY);
            this.Controls.Add(this.req_textBox_DD);
            this.Controls.Add(this.req_textBox_ID);
            this.Controls.Add(this.Requestor_ID);
            this.Controls.Add(this.Request_Status);
            this.Controls.Add(this.Request_Desc);
            this.Controls.Add(this.Request_Date);
            this.Controls.Add(this.Request_Type);
            this.Controls.Add(this.Req_ID);
            this.Name = "UserControl_Ser_Request";
            this.Size = new System.Drawing.Size(861, 523);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userBtn_Reset;
        private System.Windows.Forms.Label user_DateOFBirth_YYYY;
        private System.Windows.Forms.Label user_DateOFBirth_MM;
        private System.Windows.Forms.Label user_DateOFBirth_DD;
        private System.Windows.Forms.TextBox req_textBox_Desc;
        private System.Windows.Forms.TextBox reqtor_textBox_ID;
        private System.Windows.Forms.ComboBox req_textBox_Status;
        private System.Windows.Forms.ComboBox req_textBox_MM;
        private System.Windows.Forms.ComboBox req_textBox_YYYY;
        private System.Windows.Forms.ComboBox req_textBox_DD;
        private System.Windows.Forms.TextBox req_textBox_ID;
        private System.Windows.Forms.Label Requestor_ID;
        private System.Windows.Forms.Label Request_Status;
        private System.Windows.Forms.Label Request_Desc;
        private System.Windows.Forms.Label Request_Date;
        private System.Windows.Forms.Label Request_Type;
        private System.Windows.Forms.Label Req_ID;
        private System.Windows.Forms.ComboBox req_textBox_Type;
    }
}
