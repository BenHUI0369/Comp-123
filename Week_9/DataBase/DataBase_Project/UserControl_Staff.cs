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
    public partial class UserControl_Staff : UserControl
    {
        public UserControl_Staff()
        {
            InitializeComponent();
        }

        public void AddToList()
        {
            string outputStrinug;
            string sqlCodeStart = "INSERT INTO COMM_STAFF VALUES (";
            string sqlCodeEnd = ");";

            outputStrinug = $"{staff_textBox_ID.Text}, '{staff_textBox_Fname.Text}', '{staff_textBox_Lname.Text}', TO_DATE('{staff_textBox_DD.Text}-{staff_textBox_MM.Text}-{staff_textBox_YYYY.Text}','DD-MON-YYYY'), '{staff_textBox_Gender.Text}', '{staff_textBox_Address.Text}', '{staff_textBox_Phone.Text}', '{staff_textBox_Email.Text}', '{staff_textBox_Position.Text}'";
            Form1.staffList.Add($"{sqlCodeStart}{outputStrinug}{sqlCodeEnd}");

        }

        public void CleanAll()
        {
            staff_textBox_ID.Text = "";
            staff_textBox_Fname.Text = "";
            staff_textBox_Lname.Text = "";
            staff_textBox_DD.SelectedIndex = -1;
            staff_textBox_MM.SelectedIndex = -1;
            staff_textBox_YYYY.SelectedIndex = -1;
            staff_textBox_Gender.SelectedIndex = -1;
            staff_textBox_Phone.Text = "";
            staff_textBox_Email.Text = "";
            staff_textBox_Address.Text = "";
            staff_textBox_Position.Text = "";
        }

        private void userBtn_Reset_Click(object sender, EventArgs e)
        {
            CleanAll();
        }
    }
}
