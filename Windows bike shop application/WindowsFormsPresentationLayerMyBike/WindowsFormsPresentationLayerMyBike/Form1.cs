using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryBuslayerMyBike;
using ClassLibraryDataLayerMyBike;

namespace WindowsFormsPresentationLayerMyBike
{
    public partial class Form1 : Form
    {
        List<Bike> bikeList = new List<Bike>();
        List<MountainBike> mountainBikeList = new List<MountainBike>();
        List<RoadBike> roadBikeList = new List<RoadBike>();

        int positionsuspensioncombo = -1;
        int positioncolorcombo = -1;
        int index = -1;//listbox
        private Bike SelectedBike;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            
                int gearNumber;
                long serialNumber;
                double price, warrenty, speed, gheight, sheight, bweight;
                string make, input, msg = "";
                EnumSuspension suspensionType;
                EnumColor color;
                bool correct = false;

                Bike mountainBike = null;
                Bike roadBike = null;
                
                if (bikeType.SelectedIndex == -1)
                {
                    MessageBox.Show("\t Please Select Bike type \n");
                    return;
                }

                input = textBoxSeialNumber.Text;
                correct = RegExValidator.Is12Digit(input) &&
                        RegExValidator.IsEmpty(input);
                if (!correct)
                {
                    MessageBox.Show("\t Serial Number must 12 digit \n");
                    return;
                }
                serialNumber = long.Parse(input);


                correct = false;
                input = textBoxMake.Text;
                correct = RegExValidator.IsAlphabetLetter(input) &&
                        RegExValidator.IsEmpty(input);
                if (!correct)
                {
                    MessageBox.Show("\t  Must be in LETTER(S) and NOT EMPTY  \n");
                    return;
                }
                make = input;

                correct = false;
                input = textBoxSpeed.Text;
                correct = RegExValidator.IsDigit(input) &&
                      RegExValidator.IsEmpty(input);
                if (!correct)
                {
                    MessageBox.Show("\t Speed must not be zero AND Must be degit \n");
                    return;
                }
                speed = Convert.ToDouble(input);


                Date made_date = new Date();
                made_date.Day = Convert.ToInt32(textBoxDay.Text);
                made_date.Month = Convert.ToInt32(textBoxMonth.Text);
                made_date.Year = Convert.ToInt32(textBoxYear.Text);
                suspensionType = (EnumSuspension)positionsuspensioncombo;
                color = (EnumColor)positioncolorcombo;
                price = Convert.ToDouble(textBoxPrice.Text);
                warrenty = Convert.ToDouble(textBoxWarrenty.Text);
                if (bikeType.SelectedIndex == 1)
                {
                    correct = false;
                    input = textBoxSeatHeight.Text;
                    correct = RegExValidator.IsDigit(input) &&
                   RegExValidator.IsEmpty(input);
                    if (!correct)
                    {
                        MessageBox.Show("\t Seat height must not be empty AND Must be degit \n");
                        return;
                    }
                    sheight = Convert.ToDouble(input);
                    bweight = Convert.ToDouble(textBoxWeight.Text);
                    roadBike = new RoadBike(serialNumber, make, speed, color, made_date, warrenty, price, sheight, bweight);
                    bikeList.Add(roadBike);

                    msg = "Bike successfully added as a road bike ";
                }
                else
                {
                    gheight = Convert.ToDouble(textBoxGroundHeight.Text);
                    gearNumber = Convert.ToInt32(textBoxGears.Text);
                    mountainBike = new MountainBike(serialNumber, make, speed, color, made_date, warrenty, price, gheight, suspensionType, gearNumber);
                    bikeList.Add(mountainBike);

                    msg = "Bike successfully added as a mountain bike ";
                }


                msg += "with bikelist";
                MessageBox.Show(msg);

            }



        /*-------------------------------------------------------------*/

        private void bikeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            SelectBikes(combo.Text);
        }
       
        private void SelectBikes(string bike)
        {
            if (bike.Equals("Mountain Bike"))
            {
                comboBoxSuspensionType.Enabled = true;
                textBoxSeatHeight.Enabled = false;
                textBoxWeight.Enabled = false;
                textBoxGears.Enabled = true;
                textBoxGroundHeight.Enabled = true;
            }
            else if (bike.Equals("Road Bike"))
            {
                comboBoxSuspensionType.Enabled = false;
                textBoxSeatHeight.Enabled = true;
                textBoxWeight.Enabled = true;
                textBoxGears.Enabled = false;
                textBoxGroundHeight.Enabled = false;
            }

        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            positioncolorcombo = this.comboBoxColor.SelectedIndex;
        }

        private void comboBoxSuspensionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            positionsuspensioncombo = this.comboBoxSuspensionType.SelectedIndex;

        }


        private void ListBoxDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = this.listBoxDisplay.SelectedIndex;
            if (index >= 0)
            {
                ListBox combo = (ListBox)sender;

                foreach (var items in listBoxDisplay.SelectedItems)
                {
                    showBike((Bike)items);
                    SelectedBike = (Bike)items;
                }
            }
        }
        private void showBike(Bike bike)
        {
            string[] bikeIndex = bike.ToString().Split('\t');
            textBoxSeialNumber.Text = bikeIndex[0];
            textBoxMake.Text = bikeIndex[1];
            textBoxSpeed.Text = bikeIndex[3];
            comboBoxColor.Text = bikeIndex[5];
            textBoxPrice.Text = bikeIndex[7];
            textBoxWarrenty.Text = bikeIndex[9];
            string[] bikeDateIndex = bikeIndex[11].Split('/');
            textBoxDay.Text = bikeDateIndex[0];
            textBoxMonth.Text = bikeDateIndex[1];
            textBoxYear.Text = bikeDateIndex[2];


            if (bike is RoadBike)
            {
                textBoxSeatHeight.Text = bikeIndex[13];
                textBoxWeight.Text = bikeIndex[15];
                bikeType.Text = "Road Bike";
                if (textBoxSeatHeight.Enabled == false)
                    SelectBikes("Road Bike");
            }
            else if (bike is MountainBike)
            {
                comboBoxSuspensionType.Text = bikeIndex[18];
                bikeType.Text = "Mountain Bike";
                if (comboBoxSuspensionType.Enabled == false)
                    SelectBikes("Mountain Bike");
            }
        }
        private int GetIndexOfInList(Bike inptBike, List<Object> inptList)
        {
            int indx = -1;
            for (int i = 0; i < inptList.Count; i++)
                if (inptList[i].ToString().Equals(inptBike.ToString()))
                    indx = i;
            return indx;
        }

        private List<Object> BikeToObject(List<Bike> bikes)
        {
            List<Object> objList = new List<Object>();
            foreach (Bike itrBike in bikes)
                objList.Add((object)itrBike);
            return objList;
        }

        private List<Object> RoadBikeToObject(List<RoadBike> rBikes)
        {
            List<Object> objList = new List<Object>();
            foreach (Bike itrBike in rBikes)
                objList.Add((object)itrBike);
            return objList;
        }

        private List<Object> MountainBikeToObject(List<MountainBike> mBikes)
        {
            List<Object> objList = new List<Object>();
            foreach (Bike itrBike in mBikes)
                objList.Add((object)itrBike);
            return objList;
        }
        private void ComboBoxSuspensionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            positionsuspensioncombo = this.comboBoxSuspensionType.SelectedIndex;
        }

        private void ComboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            positioncolorcombo = this.comboBoxColor.SelectedIndex;
        }

        private void TextBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        


        /*---------------------------------------*/
        private void Form1_Load(object sender, EventArgs e)
        {
                foreach (EnumSuspension susType in Enum.GetValues(typeof(EnumSuspension)))
                {
                    this.comboBoxSuspensionType.Items.Add(susType);
                }
                this.comboBoxSuspensionType.Text = Convert.ToString(EnumSuspension.Front);
                foreach (EnumColor color in Enum.GetValues(typeof(EnumColor)))
                {
                    this.comboBoxColor.Items.Add(color);
                }
                this.comboBoxColor.Text = Convert.ToString(EnumColor.White);
                this.bikeType.Items.Add("Mountain Bike");
                this.bikeType.Items.Add("Road Bike");
                comboBoxSuspensionType.Enabled = false;
                textBoxSeatHeight.Enabled = false;
                textBoxGroundHeight.Enabled = false;
                textBoxGears.Enabled = false;
                textBoxWeight.Enabled = false;
            }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to exit? ", "Exit",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            foreach (Control aControl in Controls)
            {
                if (aControl is TextBox)
                {
                    aControl.Text = "";
                }
            }
            this.listBoxDisplay.Items.Clear();
            this.comboBoxSuspensionType.Text = Convert.ToString(EnumSuspension.Front);
            this.comboBoxColor.Text = Convert.ToString(EnumColor.White);
            this.textBoxGroundHeight.Enabled = true;
            this.textBoxSeatHeight.Enabled = true;
            this.button_Add.Enabled = true;
            this.textBoxSeialNumber.Enabled = true;

        }

        private void button_DisplayAllBike_Click(object sender, EventArgs e)
        {
            this.listBoxDisplay.Items.Clear();
            if (bikeList.Count > 0)
            {
                foreach (Bike element in bikeList)
                {
                    listBoxDisplay.Items.Add(element);
                }
            }
            else
            {
                MessageBox.Show("\n" + "The list is empty");
            }


        }

        private void button_roadbike_Click(object sender, EventArgs e)
        {
            this.listBoxDisplay.Items.Clear();
            foreach (Bike element in bikeList)
            {
                if (element is RoadBike)
                {
                    roadBikeList.Add((RoadBike)element);
                }
            }

            if (roadBikeList.Count > 0)
            {
                foreach (RoadBike element in roadBikeList)
                {
                    listBoxDisplay.Items.Add(element);
                }
            }
            else
            {
                MessageBox.Show("\n" + "The list is empty");
            }
        }

        private void button_mountainbike_Click(object sender, EventArgs e)
        {
            this.listBoxDisplay.Items.Clear();
            foreach (Bike element in bikeList)
            {
                if (element is MountainBike)
                {
                    mountainBikeList.Add((MountainBike)element);
                }
            }
            if (mountainBikeList.Count > 0)
            {
                foreach (MountainBike element in mountainBikeList)
                {
                    listBoxDisplay.Items.Add(element);
                }
            }
            else
            {
                MessageBox.Show("\n" + "The list is empty");
            }

        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
                DialogResult result;
                result = MessageBox.Show("Do you want to delete this bike? ", "Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes && index >= -1)
                {
                    index = this.listBoxDisplay.SelectedIndex;
                    MessageBox.Show("Bike " + this.bikeList[index].SerialNumber + " Removed");
                    this.bikeList.RemoveAt(index);
                }
                else if (result == DialogResult.No) MessageBox.Show("Bike Serial Number " + this.bikeList[index].SerialNumber + " NOT Removed");
            }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (textBoxSeialNumber.Text.Equals("") ||
    !RegExValidator.Is12Digit(textBoxSeialNumber.Text))
            {
                MessageBox.Show("Please enter a valid value for serial number..!!");
                return;
            }
            Boolean found = false;
            listBoxDisplay.Items.Clear();
            if (bikeList.Count > 0)
            {
                foreach (Bike bike in bikeList)
                {
                    if (bike.SerialNumber.Equals(long.Parse(textBoxSearchBike.Text)))
                    {
                        listBoxDisplay.Items.Add(bike);
                        found = true;
                        MessageBox.Show("Bike found, Details");
                    }
                }
            }
            else
            {
                MessageBox.Show("\n" + "The list is empty");
            }
            if (!found)
                MessageBox.Show("No Search Results..!!");
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            int indexInBikes = GetIndexOfInList(SelectedBike,
             BikeToObject(bikeList));
            int indexInType = -1;
            Bike newObj;
            if (SelectedBike is RoadBike)
            {
                indexInType = GetIndexOfInList(SelectedBike, RoadBikeToObject(roadBikeList));
                newObj = new RoadBike(long.Parse(textBoxSeialNumber.Text), textBoxMake.Text,
                    Convert.ToDouble(textBoxSpeed.Text), (EnumColor)Enum.Parse(typeof(EnumColor),
                    comboBoxColor.Text),
                    new Date(Convert.ToInt32(textBoxDay.Text), Convert.ToInt32(textBoxMonth.Text),
                    Convert.ToInt32(textBoxYear.Text)), Convert.ToInt32(textBoxWarrenty.Text), Convert.ToDouble(textBoxPrice.Text), Convert.ToInt32(textBoxSeatHeight.Text), Convert.ToDouble(textBoxWeight.Text));
                roadBikeList.RemoveAt(indexInType);
                roadBikeList.Insert(indexInType, (RoadBike)newObj);
            }
            else
            {
                indexInType = GetIndexOfInList(SelectedBike, MountainBikeToObject(mountainBikeList));
                newObj = new MountainBike(long.Parse(textBoxSeialNumber.Text), textBoxMake.Text,
                    Convert.ToDouble(textBoxSpeed.Text), (EnumColor)Enum.Parse(typeof(EnumColor),
                    comboBoxColor.Text),
                    new Date(Convert.ToInt32(textBoxDay.Text), Convert.ToInt32(textBoxMonth.Text),
                    Convert.ToInt32(textBoxYear.Text)), Convert.ToInt32(textBoxWarrenty.Text), Convert.ToDouble(textBoxPrice.Text), Convert.ToDouble(textBoxGroundHeight.Text),
                    (EnumSuspension)Enum.Parse(typeof(EnumSuspension), comboBoxSuspensionType.Text), Convert.ToInt32(textBoxGears.Text));
                mountainBikeList.RemoveAt(indexInType);
                mountainBikeList.Insert(indexInType, (MountainBike)newObj);
            }
            bikeList.RemoveAt(indexInBikes);
            bikeList.Insert(indexInBikes, newObj);
            if (indexInBikes == -1 || indexInType == -1 || newObj == null)
                MessageBox.Show("Could not Update..!!");
            else
                MessageBox.Show("Updated successfully..!!");
        }

        private void button_Write_Click(object sender, EventArgs e)
        {
            FileHandler.WriteToFile(bikeList);
            MessageBox.Show("added");
        }

        private void button_Read_Click(object sender, EventArgs e)
        {
            if (File.Exists(FileHandler.filePath))
            {
                List<Bike> listFromFile = new List<Bike>();

                listFromFile = FileHandler.ReadFromFile();

                bikeList = listFromFile;
                listBoxDisplay.Items.Add(listFromFile);

                MessageBox.Show("loaded");
            }
            else
            {
                MessageBox.Show("No data found");
            }
        }
    }
}
