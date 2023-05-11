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
    public partial class UserControl_Admission : UserControl
    {
        public UserControl_Admission()
        {
            InitializeComponent();
        }

        public void AddToList()
        {
            string outputStrinug;
            string sqlCodeStart = "INSERT INTO COMM_ADMISSION VALUES (";
            string sqlCodeEnd = ");";

            outputStrinug = $"'{adm_textBox_ID.Text}', '{adm_textBox_App_ID.Text}', '{adm_textBox_Program_ID.Text}', {adm_textBox_UID.Text}, TO_DATE('{adm_textBox_DD.Text}-{adm_textBox_MM.Text}-{adm_textBox_YYYY.Text}','DD-MON-YYYY'), '{adm_textBox_Status.Text}'";
            Form1.admissionList.Add($"{sqlCodeStart}{outputStrinug}{sqlCodeEnd}");
        }

        public void CleanAll()
        {
            adm_textBox_ID.Text = "";
            adm_textBox_App_ID.Text = "";
            adm_textBox_Program_ID.Text = "";
            adm_textBox_UID.Text = "";
            adm_textBox_DD.SelectedIndex = -1;
            adm_textBox_MM.SelectedIndex = -1;
            adm_textBox_YYYY.SelectedIndex = -1;
            adm_textBox_Status.SelectedIndex = -1;
        }

        private void userBtn_Reset_Click(object sender, EventArgs e)
        {
            CleanAll();
        }
    }
}
