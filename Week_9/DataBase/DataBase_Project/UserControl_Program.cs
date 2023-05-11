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
    public partial class UserControl_Program : UserControl
    {
        public UserControl_Program()
        {
            InitializeComponent();
        }

        public void AddToList()
        {
            string outputStrinug;
            string sqlCodeStart = "INSERT INTO COMM_PROGRAM VALUES (";
            string sqlCodeEnd = ");";

            outputStrinug = $"'{program_textBox_ID.Text}', '{program_textBox_Name.Text}', '{program_textBox_Type.Text}', {program_textBox_Duration.Text}, '{program_textBox_Coop.Text}', '{program_textBox_College_ID.Text}'";
            Form1.programList.Add($"{sqlCodeStart}{outputStrinug}{sqlCodeEnd}");
        }
        public void CleanAll()
        {
            program_textBox_ID.Text = "";
            program_textBox_Name.Text = "";
            program_textBox_Type.SelectedIndex = -1;
            program_textBox_Duration.SelectedIndex = -1;
            program_textBox_Coop.SelectedIndex = -1;
            program_textBox_College_ID.Text = "";
        }

        private void userBtn_Reset_Click(object sender, EventArgs e)
        {
            CleanAll();
        }
    }
}
