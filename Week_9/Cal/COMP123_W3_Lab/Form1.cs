using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace COMP123_W3_Lab
{
    public partial class Form1 : Form
    {
        private Button testButton = new Button();
        public Form1()
        {
            InitializeComponent();
            //create custome button
            //this.Controls.Add(testButton);
            //testButton.Text = "myButton";
            //testButton.Location = new Point(40, 40);
            //testButton.Size = new Size(100, 40);
            //comboBox1.Items.Add("Item_1");
            //comboBox1.Items.Add("Item_2");
            //comboBox1.Items.Add("Item_3");
            //comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.Id = Convert.ToInt32(idField.Text.Trim());
            stu.Name = Convert.ToString(nameField.Text.Trim());
            stu.Sex = (sexField.SelectedIndex == 1);
            stu.Phone = phoneField.Text.Trim();

            //create json file
            string jsonStr = JsonConvert.SerializeObject(stu, Formatting.Indented);
            File.WriteAllText("StudentInfo.json", jsonStr);
            MessageBox.Show("Data Saved");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("StudentInfo.json");
            JsonReader reader = new JsonTextReader(sr);
            JObject jsonObj = JObject.Load(reader);
            string studentId = (string)jsonObj["Id"];
            string name = (string)jsonObj["Name"];
            bool sex = (bool)jsonObj["Sex"];
            string phone = (string)jsonObj["Phone"];
            idField.Text = studentId;
            nameField.Text = name;
            if (sex)
            {
                sexField.SelectedIndex = 1;
            }
            else
            {
                sexField.SelectedIndex = 0;
            }
            phoneField.Text = phone;
            reader.Close();
            sr.Close();
            Console.WriteLine($"1.{studentId} 2.{name} 3.{sex} 4.{phone}");
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    int index = comboBox1.SelectedIndex;
        //    string str = (string)comboBox1.SelectedItem;
        //    Console.WriteLine($"Selected: {str}");
        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Console.WriteLine($"Selected: {comboBox1.SelectedItem}");
        //}

        //protected override void OnLayout(LayoutEventArgs levent)
        //{
        //    ////1. call the parent class OnLayout
        //    //base.OnLayout(levent);

        //    ////2. get the clientsize
        //    //int width = this.ClientSize.Width;
        //    //int height = this.ClientSize.Height;

        //    ////3. calculate the position and size
        //    //int yoff = 0;
        //    //int btnWidth = 80;
        //    //int btnHeight = 30;


        //    //yoff = 4;
        //    //this.timeField.Location = new Point(0, yoff);
        //    //this.timeField.Size = new Size(width - btnWidth, btnHeight);
        //    //this.button1.Location = new Point(width - btnWidth, yoff);
        //    //this.button1.Size = new Size(btnWidth, btnHeight);

        //    //yoff += 30;//height of line1
        //    //yoff += 4;//spacing
        //    //this.pictureBox1.Location = new Point(0, yoff);
        //    //this.pictureBox1.Size = new Size(width, height - yoff - 4);
        //}

        //private void OnButtenClick(object sender, EventArgs e)
        //{
        //    string timerStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        //    timeField.Text = timerStr;
        //}
    }
}
