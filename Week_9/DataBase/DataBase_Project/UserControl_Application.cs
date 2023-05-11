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
    public partial class UserControl_Application : UserControl
    {
        public UserControl_Application()
        {
            InitializeComponent();
        }

        public void AddToList()
        {
            string outputStrinug;
            string sqlCodeStart = "INSERT INTO COMM_APPLICATION VALUES (";
            string sqlCodeEnd = ");";

            outputStrinug = $"'{app_textBox_ID.Text}', {app_textBox_UID.Text}, TO_DATE('{app_textBox_DD.Text}-{app_textBox_MM.Text}-{app_textBox_YYYY.Text}','DD-MON-YYYY')";
            Form1.applicationList.Add($"{sqlCodeStart}{outputStrinug}{sqlCodeEnd}");
        }

        public void CleanAll()
        {
            app_textBox_ID.Text = "";
            app_textBox_UID.Text = "";
            app_textBox_DD.SelectedIndex = -1;
            app_textBox_MM.SelectedIndex = -1;
            app_textBox_YYYY.SelectedIndex = -1;
        }

        private void userBtn_Reset_Click(object sender, EventArgs e)
        {
            CleanAll();
        }
    }
}
