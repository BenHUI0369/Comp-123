using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Project
{
    public partial class UserControl_College : UserControl
    {
        public UserControl_College()
        {
            InitializeComponent();
        }

        public void AddToList()
        {
            string outputStrinug;
            string sqlCodeStart = "INSERT INTO COMM_COLLEGE VALUES (";
            string sqlCodeEnd = ");";

            outputStrinug = $"'{college_textBox_ID.Text}', '{college_textBox_Name.Text}', '{college_textBox_Location.Text}', '{college_textBox_Phone.Text}', '{college_textBox_Email.Text}'";
            Form1.collegeList.Add($"{sqlCodeStart}{outputStrinug}{sqlCodeEnd}");
        }

        public void CleanAll()
        {
            college_textBox_ID.Text = "";
            college_textBox_Name.Text = "";
            college_textBox_Location.Text = "";
            college_textBox_Phone.Text = "";
            college_textBox_Email.Text = "";
        }

        private void userBtn_Reset_Click(object sender, EventArgs e)
        {
            CleanAll();
        }
    }
}
