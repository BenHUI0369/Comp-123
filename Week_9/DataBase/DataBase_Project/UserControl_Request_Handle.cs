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
    public partial class UserControl_Request_Handle : UserControl
    {
        public UserControl_Request_Handle()
        {
            InitializeComponent();
        }

        public void AddToList()
        {
            string outputStrinug;
            string sqlCodeStart = "INSERT INTO COMM_REQUEST_HANDLE VALUES (";
            string sqlCodeEnd = ");";

            outputStrinug = $"'{handle_textBox_ID.Text}', '{handle_textBox_Request_ID.Text}', TO_DATE('{handle_textBox_DD.Text}-{handle_textBox_MM.Text}-{handle_textBox_YYYY.Text}','DD-MON-YYYY'), '{handle_textBox_Status.Text}', {handle_textBox_SID.Text}";
            Form1.requestHandleList.Add($"{sqlCodeStart}{outputStrinug}{sqlCodeEnd}");
        }

        public void CleanAll()
        {
            handle_textBox_ID.Text = "";
            handle_textBox_Request_ID.Text = "";
            handle_textBox_SID.Text = "";
            handle_textBox_DD.SelectedIndex = -1;
            handle_textBox_MM.SelectedIndex = -1;
            handle_textBox_YYYY.SelectedIndex = -1;
            handle_textBox_Status.Text = "";
        }

        private void userBtn_Reset_Click(object sender, EventArgs e)
        {
            CleanAll();
        }
    }
}

