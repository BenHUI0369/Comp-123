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
    public partial class UserControl_Ser_Request : UserControl
    {
        public UserControl_Ser_Request()
        {
            InitializeComponent();
        }

        public void AddToList()
        {
            string outputStrinug;
            string sqlCodeStart = "INSERT INTO COMM_SER_REQUEST VALUES (";
            string sqlCodeEnd = ");";

            outputStrinug = $"'{req_textBox_ID.Text}', '{req_textBox_Type.Text}', TO_DATE('{req_textBox_DD.Text}-{req_textBox_MM.Text}-{req_textBox_YYYY.Text}','DD-MON-YYYY'), '{req_textBox_Desc.Text}', '{req_textBox_Status.Text}', {reqtor_textBox_ID.Text}";
            Form1.serRequestList.Add($"{sqlCodeStart}{outputStrinug}{sqlCodeEnd}");

        }

        public void CleanAll()
        {
            req_textBox_ID.Text = "";
            req_textBox_Type.Text = "";
            req_textBox_DD.SelectedIndex = -1;
            req_textBox_MM.SelectedIndex = -1;
            req_textBox_YYYY.SelectedIndex = -1;
            req_textBox_Desc.Text = "";
            req_textBox_Status.SelectedIndex = -1;
            reqtor_textBox_ID.Text = "";
        }

        private void userBtn_Reset_Click(object sender, EventArgs e)
        {
            CleanAll();
        }
    }
}
