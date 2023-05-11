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
    public partial class UserControl_Location : UserControl
    {
        public UserControl_Location()
        {
            InitializeComponent();
        }

        public void AddToList()
        {
            string outputStrinug;
            string sqlCodeStart = "INSERT INTO COMM_LOCATION VALUES (";
            string sqlCodeEnd = ");";

            outputStrinug = $"'{Location_textBox_Location.Text}'";
            Form1.LocationList.Add($"{sqlCodeStart}{outputStrinug}{sqlCodeEnd}");
        }

        public void CleanAll()
        {
            Location_textBox_Location.Text = "";
        }

        private void userBtn_Reset_Click(object sender, EventArgs e)
        {
            CleanAll();
        }
    }
}
