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
    public partial class UserControl_Course : UserControl
    {
        public UserControl_Course()
        {
            InitializeComponent();
        }

        public void AddToList()
        {
            string outputStrinug;
            string sqlCodeStart = "INSERT INTO COMM_COURSE VALUES (";
            string sqlCodeEnd = ");";

            outputStrinug = $"'{course_textBox_ID.Text}', '{course_textBox_PID.Text}', '{course_textBox_Name.Text}', '{course_textBox_Desc.Text}', '{course_textBox_Course_Credit.Text}', '{course_textBox_Course_Level.Text}'";
            Form1.courseList.Add($"{sqlCodeStart}{outputStrinug}{sqlCodeEnd}");
        }

        public void CleanAll()
        {
            course_textBox_ID.Text = "";
            course_textBox_PID.Text = "";
            course_textBox_Name.Text = "";
            course_textBox_Desc.Text = "";
            course_textBox_Course_Credit.SelectedIndex = -1;
            course_textBox_Course_Level.SelectedIndex = -1;
        }

        private void userBtn_Reset_Click(object sender, EventArgs e)
        {
            CleanAll();
        
        }
    }
}
