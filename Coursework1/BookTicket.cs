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
            saveBtnTicketBooking.Enabled = false;
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
        private void stringKeyDown(object sender, KeyEventArgs e)
        {
            Utils.validateForNumberPress(sender, e, true);
        }
        private void saveBtnTicketBooking_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
            List<Ticket> mTicketList;
                try
            {
                mTicketList = Utils.getTicketBookingListFromFile();
            }
            catch (Exception)
            {

                mTicketList = new List<Ticket>();
            }
                
            bool weekDay()
            {
                string todaysDay = datePicker.Value.ToString("ddd");

                return (todaysDay != "Sun" || todaysDay != "Sat");
            }
    
            string name = nameTextField.Text;
            if (!(name.Length < 1))
            {
                ticket.ticketId = mTicketList.Count > 0 ? mTicketList.Max(t => t.ticketId) + 1 : 1;
                ticketAutoIncresedId.Text = ticket.ticketId.ToString();
                ticket.name = name;
                DateTime inTime = timePicker.Value;
                ticket.in_time = inTime;
                DateTime todayDate = datePicker.Value;
                ticket.date = todayDate;
                ticket.childCount = Constants.numberHolder.below_three;
                ticket.normalCount = Constants.numberHolder.sixteen_to_sixty;
                ticket.oldCount = Constants.numberHolder.above_sixty;
                Constants.numberHolder.resetData();
                MessageBox.Show("Ticket Booked with ticket id " + ticket.ticketId.ToString(), "Succcess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saveBtnTicketBooking.Enabled = false;
                Utils.setOnFile(ticket.toJson(), Constants.TICKETBOOKING_FILE);
            }
            else {
                MessageBox.Show("Enter Name Please!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void nameTextField_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearBtnTicketBooking_Click_2(object sender, EventArgs e)
        {
            nameTextField.Text = Properties.Settings.Default.TextBoxDefaultValue;
            /*ageGroupComboBox.Text = Properties.Settings.Default.ComboBoxDefaultvalue;
            numberOfPeopleComboBox.Text = Properties.Settings.Default.ComboBoxDefaultvalue;*/
            checkoutTextBoxId.Text = Properties.Settings.Default.TextBoxDefaultValue;
            totalCostTextBox.Text = Properties.Settings.Default.TextBoxDefaultValue;
            ticketAutoIncresedId.Text = null;
            //ageGroupComboBox.Text = null;
            // numberOfPeopleComboBox.Text = null;
            //ageGroupComboBox.Enabled = true;
            //numberOfPeopleComboBox.Enabled = true;
        }

        private void numberOfPeopleComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //ageGroupComboBox.Enabled = false;
        }

        private void ageGroupComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //numberOfPeopleComboBox.Enabled = false;
        }

        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            string id = checkoutTextBoxId.Text;
            if (!(String.IsNullOrEmpty(id)))
            {
                int checkOutId = int.Parse(checkoutTextBoxId.Text);
                List<Ticket> ticketList = Utils.getTicketBookingListFromFile();

                if (ticketList.Count > 0)
                {
                    // Again, assumes that each id is unique
                    var selectedTicket = ticketList.Where(t => t.ticketId == checkOutId);

                    // Make sure that the ticket we are searching for actually exists
                    if (selectedTicket.Count() > 0)
                    {
                        Ticket mTicket = selectedTicket.First();
                        mTicket.check_out = checkOut.Value;
                        int totalPrice = Utils.calculatePrice(mTicket);

                        name.Text = mTicket.name;
                        totalCostTextBox.Text = totalPrice.ToString();

                        

                    }
                    else {
                        // The ticket we're looking for does not exist - Show error message here.
                    }

                }
            }
            else
            {
                MessageBox.Show("Please Enter Ticket Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void radioNoButton_CheckedChanged(object sender, EventArgs e)
        {
            continueBtn.Enabled = false;
            //ageGroupComboBox.Enabled = true;
            saveBtnTicketBooking.Enabled = true;
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            string name = nameTextField.Text;
            if (!(name.Length < 1))
            {
                Data.Ticket ticket = new Data.Ticket();
                //List<Ticket> mTicketList = Utils.getTicketBookingListFromFile();
                PopUpWindow newWindow = new PopUpWindow();
                newWindow.Show();
                newWindow.Enabled = true;
                saveBtnTicketBooking.Enabled = true;
                
            }
            else {
                MessageBox.Show("Enter Name Please!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioYesButton_CheckedChanged(object sender, EventArgs e)
        {
            saveBtnTicketBooking.Enabled = false;
            //ageGroupComboBox.Enabled = false;
            continueBtn.Enabled = true;
        }

        private void checkoutTextBoxId_TextChanged(object sender, EventArgs e)
        {
            name.Text= Properties.Settings.Default.TextBoxDefaultValue;
            totalCostTextBox.Text = "0";
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookTicket_Load(object sender, EventArgs e)
        {
            saveBtnTicketBooking.Enabled = false;
        }

        private void checkOutBtnTicketBooking_Click(object sender, EventArgs e)
        {
            if (checkoutTextBoxId.Text.Length > 0)
            {
                Utils.setCheckoutValues(int.Parse(checkoutTextBoxId.Text), checkOut.Value); // Add the total price after calculation here.
            }
            
        }
    }
}