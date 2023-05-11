using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary<string, Premier> premiers;
        public Form1()
        {
            InitializeComponent();
            InitializeGui();
        }

        //function for initializing the GUI (when the form load) 
        public void InitializeGui()
        {
            //create new dictionary
            premiers = new Dictionary<string, Premier>();
            //create a Premier object list and store data in it using GetPremiers()
            List<Premier> premierList = Premier.GetPremiers();
            //use GenerateKey() and loop through the premierList, add the key(string) and value(Premier object) to premiers Dictionary
            foreach (Premier nameKey in premierList)
            {
                string key = nameKey.GenerateKey();
                premiers.Add(key, nameKey);
            }
            //create a string list contain all the key value in premiers Dictionary
            List<string> keyList = new List<string>(premiers.Keys);
            listBox_name.DataSource = keyList;
        }

        //function for updating the GUI base on the selected listBox item 
        public void UpdateGUI(string key)
        {
            //get the value(Premier) by key
            Premier premier = premiers[key];
            //changing 3 label near the image box
            label_Name.Text = premier.Name;
            label_life.Text = premier.Life;
            label_start_end.Text = $"{premier.Start} - {premier.End}";

            //setting the image path location
            string image_folder = "images";
            //the images file is locate in the same file as the .exe file; therefore using relative path. Otherwise, use the format of: @"c:\Images\test.jpg"
            string imagePath = $"{image_folder}\\{key}.jpg";
            pictureBox1.ImageLocation = $"{imagePath}";
        }

        //function for the listBox value change event
        private void ListBox_selectValueChanged(object sender, EventArgs e)
        {
            //get the selected value and transfer it to string type
            string selectedValue = listBox_name.SelectedValue.ToString();
            //use the selectedValue as parameter to update the GUI
            UpdateGUI(selectedValue);
        }
    }
}