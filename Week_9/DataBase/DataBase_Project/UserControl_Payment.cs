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
    public partial class UserControl_Payment : UserControl
    {
        public UserControl_Payment()
        {
            InitializeComponent();
        }

        public void AddToList()
        {
            string outputStrinug;
            string sqlCodeStart = "INSERT INTO COMM_PAYMENT VALUES (";
            string sqlCodeEnd = ");";

            outputStrinug = $"'{pay_textBox_ID.Text}', {pay_textBox_UID.Text}, '{pay_textBox_PID.Text}', {pay_textBox_Account.Text}, TO_DATE('{pay_textBox_DD.Text}-{pay_textBox_MM.Text}-{pay_textBox_YYYY.Text}','DD-MON-YYYY'), '{pay_textBox_Status.Text}'";
            Form1.paymentList.Add($"{sqlCodeStart}{outputStrinug}{sqlCodeEnd}");
        }

        public void CleanAll()
        {
            pay_textBox_ID.Text = "";
            pay_textBox_UID.Text = "";
            pay_textBox_PID.Text = "";
            pay_textBox_Account.Text = "";
            pay_textBox_DD.SelectedIndex = -1;
            pay_textBox_MM.SelectedIndex = -1;
            pay_textBox_YYYY.SelectedIndex = -1;
            pay_textBox_Status.Text = "";
        }

        private void userBtn_Reset_Click(object sender, EventArgs e)
        {
            CleanAll();
        }
    }
}
