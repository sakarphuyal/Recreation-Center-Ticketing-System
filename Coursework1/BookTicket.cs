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
            Data.Ticket ticket = new Data.Ticket();
            List<Ticket> mTicketList = Utils.getTicketBookingListFromFile();
            bool weekDay()
            {
                string todaysDay = datePicker.Value.ToString("ddd");

                return (todaysDay != "Sun" || todaysDay != "Sat");
            }
    
            string name = nameTextField.Text;
            if (!(name.Length < 1))
            {
                ticket.ticket_auto_incresed_id = mTicketList.Count > 0 ? mTicketList.Max(t => t.ticket_auto_incresed_id) + 1 : 1;
                ticketAutoIncresedId.Text = ticket.ticket_auto_incresed_id.ToString();
                ticket.name = name;
                DateTime inTime = timePicker.Value;
                ticket.in_time = inTime;
                DateTime todayDate = datePicker.Value;
                ticket.date = todayDate;
                ticket.below_three = Constants.numberHolder.below_three;
                ticket.three_to_sixteen = Constants.numberHolder.three_to_sixteen;
                ticket.sixteen_to_sixty = Constants.numberHolder.sixteen_to_sixty;
                ticket.above_sixty = Constants.numberHolder.above_sixty;
                Constants.numberHolder.resetData();
                MessageBox.Show("Ticket Booked with ticket id " + ticket.ticket_auto_incresed_id.ToString(), "Succcess", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Data.Ticket ticket = new Data.Ticket();
                for (int i = 0; i <= ((ticketList.Count) - 1); i++)
                {
                    bool weekDay()
                    {
                        string todaysDay = datePicker.Value.ToString("ddd");

                        return (todaysDay != "Sun" || todaysDay != "Sat");
                    }
                    if (ticketList[i].ticket_auto_incresed_id == checkOutId)
                    {
                        checkoutTextBoxId.Text = ticketList[i].ticket_auto_incresed_id.ToString();
                        name.Text = ticketList[i].name;
                        int belowThree = ticketList[i].below_three;
                        int threeToSixteen = ticketList[i].three_to_sixteen;
                        int sixteeToSixty = ticketList[i].sixteen_to_sixty;
                        int aboveSixty = ticketList[i].above_sixty;
                        DateTime outTime = checkOut.Value;
                       /* ticketList[i].check_out = outTime;
                        Utils.setOnFile((ticket.check_out).toJson(), Constants.TICKETBOOKING_FILE);*/
                        int totalPeople = (belowThree+threeToSixteen+sixteeToSixty+aboveSixty);
                        bool isWeekDay = weekDay();
                        if (isWeekDay == true)
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
                            int wholeSixtyPlus = weekPrice[0].week_individual_sixty_plus_whole_day;
                            int twoToFiveDiscount = weekPrice[0].week_group_two_to_five_discount;
                            int fiveToTenDiscount = weekPrice[0].week_group_five_to_ten_discount;
                            int tenToFifteenDiscount = weekPrice[0].week_group_ten_to_fifteen_discount;
                            int fifteenPlusDiscount = weekPrice[0].week_group_fifteen_plus_discount;
                            //Individual total amount Calculation Without Discount
                            int totalHour = 1;
                            if (totalPeople == 1) {
                                if (belowThree == 1) {
                                    if (totalHour <= 1)
                                    {
                                        totalCostTextBox.Text = (totalHour * oneThreeYear).ToString();
                                        
                                    }
                                    else if (totalHour > 1 && totalHour <= 2)
                                    {
                                        totalCostTextBox.Text = (totalHour * twoThreeYear).ToString();
                                        
                                        
                                    }
                                    else if (totalHour > 2 && totalHour <= 3)
                                    {
                                        totalCostTextBox.Text = (totalHour * threeThreeYear).ToString();
                                        
                                       
                                    }
                                    else if (totalHour > 3 && totalHour <= 4)
                                    {
                                        totalCostTextBox.Text = (totalHour * fourThreeYear).ToString();
                                        
                                        
                                    }
                                    else {
                                        totalCostTextBox.Text = (totalHour * wholeThreeYear).ToString();
                                        
                                        
                                    }
                                }
                                else if (threeToSixteen == 1) {
                                    if (totalHour <= 1)
                                    {
                                        totalCostTextBox.Text = (totalHour * oneThreeToSixteen).ToString();

                                    }
                                    else if (totalHour > 1 && totalHour <= 2)
                                    {
                                        totalCostTextBox.Text = (totalHour * twoThreeTosixteen).ToString();


                                    }
                                    else if (totalHour > 2 && totalHour <= 3)
                                    {
                                        totalCostTextBox.Text = (totalHour * threeThreeToSixteen).ToString();


                                    }
                                    else if (totalHour > 3 && totalHour <= 4)
                                    {
                                        totalCostTextBox.Text = (totalHour * fourThreeToSixteenYear).ToString();


                                    }
                                    else
                                    {
                                        totalCostTextBox.Text = (totalHour * wholeThreeToSixteenYear).ToString();


                                    }
                                }
                                else if (sixteeToSixty == 1) {
                                    if (totalHour <= 1)
                                    {
                                        totalCostTextBox.Text = (totalHour * oneSixteenToSixty).ToString();

                                    }
                                    else if (totalHour > 1 && totalHour <= 2)
                                    {
                                        totalCostTextBox.Text = (totalHour * twoSixteenToSixty).ToString();


                                    }
                                    else if (totalHour > 2 && totalHour <= 3)
                                    {
                                        totalCostTextBox.Text = (totalHour * threeSixteenToSixty).ToString();


                                    }
                                    else if (totalHour > 3 && totalHour <= 4)
                                    {
                                        totalCostTextBox.Text = (totalHour * fourSixteenToSixtyYear).ToString();


                                    }
                                    else
                                    {
                                        totalCostTextBox.Text = (totalHour * wholeSixteenToSixtyYear).ToString();


                                    }

                                }
                                else if (aboveSixty == 1) {
                                    if (totalHour <= 1)
                                    {
                                        totalCostTextBox.Text = (totalHour * oneSixtyPlus).ToString();

                                    }
                                    else if (totalHour > 1 && totalHour <= 2)
                                    {
                                        totalCostTextBox.Text = (totalHour * twoSixtyPlus).ToString();


                                    }
                                    else if (totalHour > 2 && totalHour <= 3)
                                    {
                                        totalCostTextBox.Text = (totalHour * threeSixtyPlus).ToString();


                                    }
                                    else if (totalHour > 3 && totalHour <= 4)
                                    {
                                        totalCostTextBox.Text = (totalHour * fourSixtyPlus).ToString();


                                    }
                                    else
                                    {
                                        totalCostTextBox.Text = (totalHour * wholeSixtyPlus).ToString();


                                    }
                                }
                                else {
                                    MessageBox.Show("Number Of people is not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            //Group total amount calculation With Discount
                            else {
                                int totalamount = 0;
                                /*int belowThree = ticketList[i].below_three;
                                int threeToSixteen = ticketList[i].three_to_sixteen;
                                int sixteeToSixty = ticketList[i].sixteen_to_sixty;
                                int aboveSixty = ticketList[i].above_sixty;*/
                                if (belowThree != 0) { 

                                }
                                
                            }

                        }
                        else {
                            List<TicketPriceForHolidays> weekPrice = Utils.getHolidayPriceFromFile();
                            int oneThreeYear = weekPrice[0].holiday_individual_less_than_three_one_hour;
                            int oneThreeToSixteen = weekPrice[0].holiday_individual_three_to_sixteen_one_hour;
                            int oneSixteenToSixty = weekPrice[0].holiday_individual_sixteen_to_sixty_one_hour;
                            int oneSixtyPlus = weekPrice[0].holiday_individual_sixty_plus_one_hour;
                            int twoThreeYear = weekPrice[0].holiday_individual_less_than_three_two_hour;
                            int twoThreeTosixteen = weekPrice[0].holiday_individual_three_to_sixteen_two_hour;
                            int twoSixteenToSixty = weekPrice[0].holiday_individual_sixteen_to_sixty_two_hour;
                            int twoSixtyPlus = weekPrice[0].holiday_individual_sixty_plus_two_hour;
                            int threeThreeYear = weekPrice[0].holiday_individual_less_than_three_three_hour;
                            int threeThreeToSixteen = weekPrice[0].holiday_individual_three_to_sixteen_three_hour;
                            int threeSixteenToSixty = weekPrice[0].holiday_individual_sixteen_to_sixty_three_hour;
                            int threeSixtyPlus = weekPrice[0].holiday_individual_sixty_plus_three_hour;
                            int fourThreeYear = weekPrice[0].holiday_individual_less_than_three_four_hour;
                            int fourThreeToSixteenYear = weekPrice[0].holiday_individual_three_to_sixteen_four_hour;
                            int fourSixteenToSixtyYear = weekPrice[0].holiday_individual_sixteen_to_sixty_four_hour;
                            int fourSixtyPlus = weekPrice[0].holiday_individual_sixty_plus_four_hour;
                            int wholeThreeYear = weekPrice[0].holiday_individual_less_than_three_whole_day;
                            int wholeThreeToSixteenYear = weekPrice[0].holiday_individual_three_to_sixteen_whole_day;
                            int wholeSixteenToSixtyYear = weekPrice[0].holiday_individual_sixteen_to_sixty_whole_day;
                            int twoToFiveDiscount = weekPrice[0].holiday_group_two_to_five_Discount;
                            int fiveToTenDiscount = weekPrice[0].holiday_group_five_to_ten_Discount;
                            int tenToFifteenDiscount = weekPrice[0].holiday_group_ten_to_fifteen_Discount;
                            int fifteenPlusDiscount = weekPrice[0].holiday_group_fifteen_plus_Discount;
                        }
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
                List<Ticket> mTicketList = Utils.getTicketBookingListFromFile();
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

        }
    }
}