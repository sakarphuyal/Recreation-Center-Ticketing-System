using Coursework1.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework1
{
    
    public partial class BookTicket : UserControl
    {
        public BookTicket()
        {
            InitializeComponent();
        }

        public static bool Visisble { get; internal set; }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void numberKeyDown(object sender, KeyEventArgs e)
        {
            Utils.validateForStringPress(sender, e, false);
        }

        private void clearBtnTicketBooking_Click(object sender, EventArgs e)
        {
            
        }

        private void saveBtnTicketBooking_Click(object sender, EventArgs e)
        {
            Data.Ticket ticketList = new Data.Ticket();

            //string id = ticketAutoIncresedId.Text;
            //if (!(id.Length < 1))
            //{
            //ticketList.ticket_auto_incresed_id = id;
            //}
            

            string name = nameTextField.Text;
            if (!(name.Length < 1))
            {
                ticketList.name = name;
            }
            else
            {
                MessageBox.Show("Enter Name Please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string id = ticketAutoIncresedId.Text;
            int numb;
            string Id;
            Random rnd = new Random();
            for (int i = 0; i <= 4; i++) {
                numb = (rnd.Next(100));
                if (!(string.IsNullOrEmpty(name)))
                {
                    Id = name + numb;
                    ticketAutoIncresedId.Text = Id;
                    ticketList.ticket_auto_incresed_id = id;
                }
            }
            string ageGroup = ageGroupComboBox.Text;
            {
                if (!(ageGroupComboBox.SelectedItem == null))
                {
                    ageGroup = ageGroupComboBox.SelectedItem.ToString();
                    ticketList.age_group = ageGroup;
                }
            }
            DateTime todayDate = datePicker.Value.Date;
            {
                ticketList.date = todayDate;
            }
            DateTime inTime = timePicker.Value.Date;
            {
                ticketList.date = inTime;
            }
            string numberOfPeople = numberOfPeopleComboBox.Text;
            {
                if (numberOfPeopleComboBox.SelectedItem != null)
                {
                    numberOfPeople = numberOfPeopleComboBox.SelectedItem.ToString();
                    ticketList.number_of_people = numberOfPeople;
                }
            }
            if (!((numberOfPeopleComboBox.SelectedItem == null) ^ (ageGroupComboBox.SelectedItem == null)))
            {
                MessageBox.Show("Please Select Either Age Group Or Number of People", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
            Utils.setOnFile(ticketList.toJson(), Constants.TICKETBOOKING_FILE);

        }

        private void nameTextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back ||e.KeyChar == (char)Keys.Space);
        }

        private void ticketIdTextField_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string checkOutId= checkoutTextBoxId.Text;
            //System.Diagnostics.Debug.WriteLine(checkOutId);
            //Utils.getHolidayPriceFromFile();
            //Utils.getWeekDayPriceFromFile();
            List <TicketPriceForWeekDays> weekPrice = Utils.getWeekDayPriceFromFile();
            System.Diagnostics.Debug.WriteLine(weekPrice[0].week_group_ten_to_fifteen_three_hour);
        }

        private void ageGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            numberOfPeopleComboBox.Enabled = false;
            /*if (ageGroupComboBox.SelectedItem == null) {
                numberOfPeopleComboBox.Enabled = true;
            }*/
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberOfPeopleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ageGroupComboBox.Enabled = false;
            /*if (numberOfPeopleComboBox.SelectedItem == null){
                ageGroupComboBox.Enabled = true;
            }*/
        }

        private void clearBtnTicketBooking_Click_1(object sender, EventArgs e)
        {
            nameTextField.Text = Properties.Settings.Default.TextBoxDefaultValue;
            ageGroupComboBox.Text = Properties.Settings.Default.ComboBoxDefaultvalue;
            numberOfPeopleComboBox.Text = Properties.Settings.Default.ComboBoxDefaultvalue;
            checkoutTextBoxId.Text = Properties.Settings.Default.TextBoxDefaultValue;
            totalCostTextBox.Text = Properties.Settings.Default.TextBoxDefaultValue;
        }
        

        private void nameTextField_TextChanged(object sender, EventArgs e)
        {

        }
        //ticketAutoIncresedId
    }
}
