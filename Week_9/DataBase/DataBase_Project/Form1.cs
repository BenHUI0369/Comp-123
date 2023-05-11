using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Project
{
    public partial class Form1 : Form
    {
        public static string radioBtnSelection = "";
        public static string sqlString = "";
        public static List<string> userList = new List<string>();
        public static List<string> serRequestList = new List<string>();
        public static List<string> paymentList = new List<string>();
        public static List<string> applicationList = new List<string>();
        public static List<string> admissionList = new List<string>();
        public static List<string> requestHandleList = new List<string>();
        public static List<string> programList = new List<string>();
        public static List<string> courseList = new List<string>();
        public static List<string> staffList = new List<string>();
        public static List<string> collegeList = new List<string>();
        public static List<string> LocationList = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void HidePage()
        {
            foreach (Control control in Controls)
            {
                if (control is UserControl userControl)
                {
                    userControl.Visible = false;
                }
            }
        }

        public void ShowListItemNumber(List<string> inputList)
        {
            show_List_Item_Number.Text = inputList.Count.ToString();
        }

        private void UserControl_User_SaveButtonClicked(object sender, EventArgs e)
        {
            // Run the method in the form
            switch (radioBtnSelection)
            {
                case "radioBtn_user":
                    ShowListItemNumber(userList);
                    break;
                case "radioBtn_Ser_Request":
                    ShowListItemNumber(serRequestList);
                    break;
                case "radioBtn_Payment":
                    ShowListItemNumber(paymentList);
                    break;
                case "radioBtn_Application":
                    ShowListItemNumber(applicationList);
                    break;
                case "radioBtn_Admission":
                    ShowListItemNumber(admissionList);
                    break;
                case "radioBtn_Request_Handle":
                    ShowListItemNumber(requestHandleList);
                    break;
                case "radioBtn_Program":
                    ShowListItemNumber(programList);
                    break;
                case "radioBtn_Course":
                    ShowListItemNumber(courseList);
                    break;
                case "radioBtn_Staff":
                    ShowListItemNumber(staffList);
                    break;
                case "radioBtn_College":
                    ShowListItemNumber(collegeList);
                    break;
                case "radioBtn_Location":

                    ShowListItemNumber(LocationList);
                    break;
            }
        }

        private void SwitchPage()
        {
            switch (radioBtnSelection)
            {
                case "radioBtn_user":
                    HidePage();
                    userControl_User1.Show();
                    userControl_User1.BringToFront();
                    show_Selected_List.Text = "USER";
                    ShowListItemNumber(userList);
                    break;
                case "radioBtn_Ser_Request":
                    HidePage();
                    userControl_Ser_Request1.Show();
                    userControl_Ser_Request1.BringToFront();
                    show_Selected_List.Text = "Ser_Request";
                    ShowListItemNumber(serRequestList);
                    break;
                case "radioBtn_Payment":
                    HidePage();
                    userControl_Payment1.Show();
                    userControl_Payment1.BringToFront();
                    show_Selected_List.Text = "Ser_Request";
                    ShowListItemNumber(paymentList);
                    break;
                case "radioBtn_Application":
                    HidePage();
                    userControl_Application1.Show();
                    userControl_Application1.BringToFront();
                    show_Selected_List.Text = "Application";
                    ShowListItemNumber(applicationList);
                    break;
                case "radioBtn_Admission":
                    HidePage();
                    userControl_Admission1.Show();
                    userControl_Admission1.BringToFront();
                    show_Selected_List.Text = "Admission";
                    ShowListItemNumber(admissionList);
                    break;
                case "radioBtn_Request_Handle":
                    HidePage();
                    userControl_Request_Handle1.Show();
                    userControl_Request_Handle1.BringToFront();
                    show_Selected_List.Text = "Request_Handle";
                    ShowListItemNumber(requestHandleList);
                    break;
                case "radioBtn_Program":
                    HidePage();
                    userControl_Program1.Show();
                    userControl_Program1.BringToFront();
                    show_Selected_List.Text = "Program";
                    ShowListItemNumber(programList);
                    break;
                case "radioBtn_Course":
                    HidePage();
                    userControl_Course1.Show();
                    userControl_Course1.BringToFront();
                    show_Selected_List.Text = "Course";
                    ShowListItemNumber(courseList);
                    break;
                case "radioBtn_Staff":
                    HidePage();
                    userControl_Staff1.Show();
                    userControl_Staff1.BringToFront();
                    show_Selected_List.Text = "Staff";
                    ShowListItemNumber(staffList);
                    break;
                case "radioBtn_College":
                    HidePage();
                    userControl_College1.Show();
                    userControl_College1.BringToFront();
                    show_Selected_List.Text = "College";
                    ShowListItemNumber(collegeList);
                    break;
                case "radioBtn_Location":
                    HidePage();
                    userControl_Location1.Show();
                    userControl_Location1.BringToFront();
                    show_Selected_List.Text = "Location";
                    ShowListItemNumber(LocationList);
                    break;
            }
        }
        
        private void AddListItem()
        {
            switch (radioBtnSelection)
            {
                case "radioBtn_user":
                    userControl_User1.AddToList();
                    ShowListItemNumber(userList);
                    break;
                case "radioBtn_Ser_Request":
                    userControl_Ser_Request1.AddToList();
                    ShowListItemNumber(serRequestList);
                    break;
                case "radioBtn_Payment":
                    userControl_Payment1.AddToList();
                    ShowListItemNumber(paymentList);
                    break;
                case "radioBtn_Application":
                    userControl_Application1.AddToList();
                    ShowListItemNumber(applicationList);
                    break;
                case "radioBtn_Admission":
                    userControl_Admission1.AddToList();
                    ShowListItemNumber(admissionList);
                    break;
                case "radioBtn_Request_Handle":
                    userControl_Request_Handle1.AddToList();
                    ShowListItemNumber(requestHandleList);
                    break;
                case "radioBtn_Program":
                    userControl_Program1.AddToList();
                    ShowListItemNumber(programList);
                    break;
                case "radioBtn_Course":
                    userControl_Course1.AddToList();
                    ShowListItemNumber(courseList);
                    break;
                case "radioBtn_Staff":
                    userControl_Staff1.AddToList();
                    ShowListItemNumber(staffList);
                    break;
                case "radioBtn_College":
                    userControl_College1.AddToList();
                    ShowListItemNumber(collegeList);
                    break;
                case "radioBtn_Location":
                    userControl_Location1.AddToList();
                    ShowListItemNumber(LocationList);
                    break;
            }
        }

        public void SQLCodeDtring(List<string> inputList)
        {
            sqlString = "";
            foreach (string str in inputList)
            {
                sqlString += str + '\n';
            }
        }

        public void SQLToFile(string fileName)
        {
            File.WriteAllText($"{fileName}.txt", sqlString);
        }

        public void SaveToFile()
        {
            switch (radioBtnSelection)
            {
                case "radioBtn_user":
                    SQLCodeDtring(userList);
                    SQLToFile("USER");
                    break;
                case "radioBtn_Ser_Request":
                    SQLCodeDtring(serRequestList);
                    SQLToFile("Ser_Request");
                    break;
                case "radioBtn_Payment":
                    SQLCodeDtring(paymentList);
                    SQLToFile("Payment");
                    break;
                case "radioBtn_Application":
                    SQLCodeDtring(applicationList);
                    SQLToFile("Application");
                    break;
                case "radioBtn_Admission":
                    SQLCodeDtring(admissionList);
                    SQLToFile("Admission");
                    break;
                case "radioBtn_Request_Handle":
                    SQLCodeDtring(requestHandleList);
                    SQLToFile("Request_Handle");
                    break;
                case "radioBtn_Program":
                    SQLCodeDtring(programList);
                    SQLToFile("Program");
                    break;
                case "radioBtn_Course":
                    SQLCodeDtring(courseList);
                    SQLToFile("Course");
                    break;
                case "radioBtn_Staff":
                    SQLCodeDtring(staffList);
                    SQLToFile("Staff");
                    break;
                case "radioBtn_College":
                    SQLCodeDtring(collegeList);
                    SQLToFile("College");
                    break;
                case "radioBtn_Location":
                    SQLCodeDtring(LocationList);
                    SQLToFile("Location");
                    break;
            }
        }

        private void RadioBtnCheckedChanged(object sender, EventArgs e)
        {
            //pass the selected radio button name to variable radioBtnSelection
            if (((RadioButton)sender).Checked)
            {
                radioBtnSelection = ((RadioButton)sender).Name;
            }
            //run the switch page function according to the selected radio button
            SwitchPage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HidePage();
        }

        private void button_Show_List_Item_Click(object sender, EventArgs e)
        {
            AddListItem();
        }

        private void button_Save_As_File_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }
    }
}
