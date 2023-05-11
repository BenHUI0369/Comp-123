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
    public partial class UserControl_User : UserControl
    {
        public UserControl_User()
        {
            InitializeComponent();
        }
        public void AddToList()
        {
            string outputStrinug;
            string sqlCodeStart = "INSERT INTO CUSTOMERS VALUES (";
            string sqlCodeEnd = ");";

            outputStrinug = $"{user_textBox_ID.Text}, '{user_textBox_Fname.Text}', '{user_textBox_Lname.Text}', TO_DATE('{user_textBox_DD.Text}-{user_textBox_MM.Text}-{user_textBox_YYYY.Text}','DD-MON-YYYY'), '{user_textBox_Gender.Text}', '{user_textBox_Address.Text}', '{user_textBox_Phone.Text}', '{user_textBox_Email.Text}'";
            Form1.userList.Add($"{sqlCodeStart}{outputStrinug}{sqlCodeEnd}");

        }

        public void CleanAll()
        {
            user_textBox_ID.Text = "";
            user_textBox_Fname.Text = "";
            user_textBox_Lname.Text = "";
            user_textBox_DD.SelectedIndex = -1;
            user_textBox_MM.SelectedIndex = -1;
            user_textBox_YYYY.SelectedIndex = -1;
            user_textBox_Gender.SelectedIndex = -1;
            user_textBox_Phone.Text = "";
            user_textBox_Email.Text = "";
            user_textBox_Address.Text = "";
        }

        private void userBtn_Reset_Click(object sender, EventArgs e)
        {
            CleanAll();
        }

        private void User_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && user_textBox_ID.Text.Length < 9 || char.IsControl(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
