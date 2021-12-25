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
            Utils.getHolidayPriceFromFile();
        }

        private void saveBtnTicketBooking_Click(object sender, EventArgs e)
        {
            Data.Ticket ticketList = new Data.Ticket();

            string id = ticketAutoIncresedId.Text;
            if (!(id.Length < 1))
            {
                ticketList.ticket_auto_incresed_id = id;
            }
            string name = nameTextField.Text;
            if (!(name.Length < 1))
            {
                ticketList.name = name;
            }
            string ageGroup = ageGroupComboBox.Text;
            {
                if  (ageGroupComboBox.SelectedItem != null){
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

        }

        private void ageGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
