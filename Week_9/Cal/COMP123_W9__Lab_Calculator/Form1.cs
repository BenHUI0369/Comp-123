using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;

namespace COMP123_W9__Lab_Calculator
{
    public partial class Form1 : Form
    {
        string operatorType = "";
        public Fraction result;
        int fileVersion = 0;
        public Form1()
        {
            InitializeComponent(); 
        }

        private void DoCalculation()
        {
            bool isInput_1 = textBoxFirst1.Text.Length != 0;
            bool isInput_2 = textBoxFirst2.Text.Length != 0;
            bool isInput_3 = textBoxSec1.Text.Length != 0;
            bool isInput_4 = textBoxSec2.Text.Length != 0;
            if (isInput_1 && isInput_2 && isInput_3 && isInput_4)
            {
                int firstAbove = Convert.ToInt32(textBoxFirst1.Text);
                int firstBottom = Convert.ToInt32(textBoxFirst2.Text);
                int secondAbove = Convert.ToInt32(textBoxSec1.Text);
                int secondBottom = Convert.ToInt32(textBoxSec2.Text);
                string f1_top = textBoxFirst1.Text;
                string f1_bottom = textBoxFirst2.Text;
                string f2_top = textBoxSec1.Text;
                string f2_Bottom = textBoxSec2.Text;
                Fraction f1 = new Fraction(f1_top, f1_bottom);
                Fraction f2 = new Fraction(f2_top, f2_Bottom);
                //Fraction f1 = new Fraction(firstAbove, firstBottom);
                //Fraction f2 = new Fraction(secondAbove, secondBottom);
                //Fraction result;
                switch (operatorType)
                {
                    case "+":
                        result = f1 + f2;
                        textBoxResult1.Text = result.Top.ToString();
                        textBoxResult2.Text = result.Bottom.ToString();
                        Console.WriteLine(result);
                        break;
                    case "-":
                        result = f1 - f2;
                        textBoxResult1.Text = result.Top.ToString();
                        textBoxResult2.Text = result.Bottom.ToString();
                        break;
                    case "*":
                        result = f1 * f2;
                        textBoxResult1.Text = result.Top.ToString();
                        textBoxResult2.Text = result.Bottom.ToString();
                        break;
                    case "/":
                        result = f1 / f2;
                        textBoxResult1.Text = result.Top.ToString();
                        textBoxResult2.Text = result.Bottom.ToString();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please fill in all text box!");
            }
        }

        private void SaveFile()
        {
            if (textBoxResult1.Text.Length != 0)
            {
                string jsonFile = JsonSerializer.Serialize<Fraction>(result);
                File.WriteAllText($"Result_History_{fileVersion}.json", jsonFile);
                fileVersion++;
            }
            else
            {
                MessageBox.Show("Please Finished the calculation!");
            }
        }

        private void CheckDigit(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                return;
            else
                e.Handled = true;
        }

        private void button_Cal_Click(object sender, EventArgs e)
        {
            DoCalculation();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckDigit(e);
        }

        private void radionBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(((RadioButton)sender).Checked)
            {
                operatorType = ((RadioButton)sender).Text;
            }
        }

        private void radioBtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            operatorType = "+";
        }

        private void radioBtnSub_CheckedChanged(object sender, EventArgs e)
        {
            operatorType = "-";
        }

        private void radioBtnMulti_CheckedChanged(object sender, EventArgs e)
        {
            operatorType = "*";
        }

        private void radioBtnDev_CheckedChanged(object sender, EventArgs e)
        {
            operatorType = "/";
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            operatorType = "";
            textBoxFirst1.Text = null;
            textBoxFirst2.Text = null;
            textBoxSec1.Text = null;
            textBoxSec2.Text = null;
            textBoxResult1.Text = null;
            textBoxResult2.Text = null;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
    }
}