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
        private void stringKeyDown(object sender, KeyEventArgs e)
        {
            Utils.validateForNumberPress(sender, e, true);
        }
        private void saveBtnTicketBooking_Click(object sender, EventArgs e)
        {
            Data.Ticket ticketList = new Data.Ticket();
            List<Ticket> mTicketList = Utils.getTicketBookingListFromFile();
            if (radioNoButton.Checked)
            {
                string name = nameTextField.Text;
                if (!(name.Length < 1))
                {
                    if (ageGroupComboBox.SelectedItem != null)
                    {
                        ticketList.name = name;
                        int id;
                        if (mTicketList.Count < 1)
                        {
                            id = 0;
                            System.Diagnostics.Debug.WriteLine(id);
                            ticketList.ticket_auto_incresed_id = id;
                            ticketAutoIncresedId.Text = id.ToString();
                        }
                        else
                        {
                            int generatedId = mTicketList.Max(x => x.ticket_auto_incresed_id);
                            generatedId++; id = generatedId;
                            ticketList.ticket_auto_incresed_id = id;
                            ticketAutoIncresedId.Text = id.ToString();
                        }
                        string ageGroup = (ageGroupComboBox.SelectedItem).ToString();
                        System.Diagnostics.Debug.WriteLine(ageGroup);
                        if (ageGroup == "0-3 years")
                        {
                            ticketList.below_three = 1;
                        }
                        else if (ageGroup == "3-16 years")
                        {
                            ticketList.three_to_sixteen = 1;
                        }
                        else if (ageGroup == "16-60 years")
                        {
                            ticketList.sixteen_to_sixty = 1;
                        }
                        else
                        { //60 + years
                            ticketList.above_sixty = 1;
                        }
                        DateTime todayDate = datePicker.Value.Date;
                        {
                            ticketList.date = todayDate;
                        }
                        DateTime inTime = timePicker.Value.Date;
                        {
                            ticketList.in_time = inTime;
                        }
                        Utils.setOnFile(ticketList.toJson(), Constants.TICKETBOOKING_FILE);
                        MessageBox.Show("Ticket Booked with ticket id  " + id, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please Select age Group", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Enter Name Please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (radioYesButton.Checked)
            {
                string name = nameTextField.Text;
                if (!(name.Length < 1))
                {
                    if (ageGroupComboBox.SelectedItem == null)
                    {
                        ticketList.name = name;
                        int id;
                        if (mTicketList.Count < 1)
                        {
                            id = 0;
                            ticketList.ticket_auto_incresed_id = id;
                            ticketAutoIncresedId.Text = id.ToString();
                        }
                        else
                        {
                            int generatedId = mTicketList.Max(x => x.ticket_auto_incresed_id);
                            generatedId++; id = generatedId;
                            ticketList.ticket_auto_incresed_id = id;
                            ticketAutoIncresedId.Text = id.ToString();
                        }
                        ticketList.below_three = Constants.numberHolder.below_three;
                        ticketList.three_to_sixteen = Constants.numberHolder.three_to_sixteen;
                        ticketList.sixteen_to_sixty = Constants.numberHolder.sixteen_to_sixty;
                        ticketList.above_sixty = Constants.numberHolder.above_sixty;
                        Constants.numberHolder.resetData();

                        DateTime todayDate = datePicker.Value.Date;
                        {
                            ticketList.date = todayDate;
                        }
                        DateTime inTime = timePicker.Value.Date;
                        {
                            ticketList.in_time = inTime;
                        }
                        ticketList.is_group = true;
                        Utils.setOnFile(ticketList.toJson(), Constants.TICKETBOOKING_FILE);
                        MessageBox.Show("Ticket Booked with ticket id " + (id), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Enter Name Please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Select 'Yes' if in group 'No' for single Vistor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            ageGroupComboBox.Text = null;
            // numberOfPeopleComboBox.Text = null;
            ageGroupComboBox.Enabled = true;
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
            bool weekDay()
            {
                string todaysDay = datePicker.Value.ToString("ddd");

                return (todaysDay != "Sun" || todaysDay != "Sat");
            }
            string id = checkoutTextBoxId.Text;
            if (!(String.IsNullOrEmpty(id)))
            {
                int checkOutId = int.Parse(checkoutTextBoxId.Text);
                List<Ticket> ticketList = Utils.getTicketBookingListFromFile();
                
                for (int i = 0; i <= ((ticketList.Count) - 1); i++)
                {
                    if (ticketList[i].ticket_auto_incresed_id == checkOutId)
                    {
                        System.Diagnostics.Debug.WriteLine(ticketList[i].name);
                        if (ticketList[i].check_out == null)
                        {
                            ticketAutoIncresedId.Text = (ticketList[i].ticket_auto_incresed_id.ToString());
                            name.Text = (ticketList[i].name);
                            date.Text = (ticketList[i].in_time).ToString();
                            datePicker.Text = (ticketList[i].date.ToString());
                            // numberOfPeopleComboBox.Text = (ticketList[i].number_of_people);
                            /*if (!(string.IsNullOrEmpty(ticketList[i].age_group)))
                            {
                                bool isWeekDay = weekDay();
                                if ((isWeekDay) == true)
                                {
                                    List<TicketPriceForWeekDays> weekPrice = Utils.getWeekDayPriceFromFile();
                                    int oneThreeYear = weekPrice[0].week_individual_less_than_three_one_hour;
                                    int oneThreeToSixteen = weekPrice[0].week_individual_three_to_sixteen_one_hour;
                                    int oneSixteenToSixty = weekPrice[0].week_individual_sixteen_to_sixty_one_hour;
                                    int oneSixtyPlus = weekPrice[0].week_individual_sixty_plus_one_hour;
                                    int twoThreeYear = weekPrice[0].week_individual_less_than_three_two_hour;
                                    int twoThreeTosixteen = weekPrice[0].week_individual_three_to_sixteen_two_hour;
                                    int twoSixteenToSixty = weekPrice[0].week_individual_sixteen_to_sixty_two_hour;
                                    int twoSixtyPlus = weekPrice[0].week_individual_sixty_plus_two_hour;
                                    int threeThreeYear = weekPrice[0].week_individual_less_than_three_three_hour;
                                    int threeThreeToSixteen = weekPrice[0].week_individual_three_to_sixteen_three_hour;
                                    int threeSixteenToSixty = weekPrice[0].week_individual_sixteen_to_sixty_three_hour;
                                    int threeSixtyPlus = weekPrice[0].week_individual_sixty_plus_three_hour;
                                    int fourThreeYear = weekPrice[0].week_individual_less_than_three_four_hour;
                                    int fourThreeToSixteenYear = weekPrice[0].week_individual_three_to_sixteen_four_hour;
                                    int fourSixteenToSixtyYear = weekPrice[0].week_individual_sixteen_to_sixty_four_hour;
                                    int fourSixtyPlus = weekPrice[0].week_individual_sixty_plus_four_hour;
                                    int wholeThreeYear = weekPrice[0].week_individual_less_than_three_whole_day;
                                    int wholeThreeToSixteenYear = weekPrice[0].week_individual_three_to_sixteen_whole_day;
                                    int wholeSixteenToSixtyYear = weekPrice[0].week_individual_sixteen_to_sixty_whole_day;
                                    int twoToFiveDiscount = weekPrice[0].week_group_two_to_five_discount;
                                    int fiveToTenDiscount = weekPrice[0].week_group_five_to_ten_discount;
                                    int tenToFifteenDiscount = weekPrice[0].week_group_ten_to_fifteen_discount;
                                    int fifteenPlusDiscount = weekPrice[0].week_group_fifteen_plus_discount;
                                }
                            }
                            else
                            {

                            }*/
                        }
                        else {
                            MessageBox.Show("This Ticket_Id is already Checked-Out at  " + (ticketList[i].check_out), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine(ticketList[i].name);
                        MessageBox.Show("This Ticket Id is not registered", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Enter Ticket ID, Ticket Id Field is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void radioNoButton_CheckedChanged(object sender, EventArgs e)
        {
            continueBtn.Enabled = false;
            ageGroupComboBox.Enabled = true;
            saveBtnTicketBooking.Enabled = true;
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            PopUpWindow newWindow = new PopUpWindow();
            newWindow.Show();
            newWindow.Enabled = true;
            saveBtnTicketBooking.Enabled = true;
        }

        private void radioYesButton_CheckedChanged(object sender, EventArgs e)
        {
            saveBtnTicketBooking.Enabled = false;
            ageGroupComboBox.Enabled = false;
            continueBtn.Enabled = true;
        }
    }
}