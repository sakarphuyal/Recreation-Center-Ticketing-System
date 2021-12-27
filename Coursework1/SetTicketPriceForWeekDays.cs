using Coursework1.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Coursework1
{
    public partial class SetTicketPriceForWeekDays : UserControl
    {
        public SetTicketPriceForWeekDays()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SetTicketPriceForm_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
        private void saveBtnWeek_Click(object sender, EventArgs e)
        {
            Data.TicketPriceForWeekDays weekDayPrice = new Data.TicketPriceForWeekDays();
            //1,1
            string oneHourLessThanThreeIndividualWeekDay = weekIndividualBelowThreeOnehour.Text;
            if (!(oneHourLessThanThreeIndividualWeekDay.Length < 1))
            {
                weekDayPrice.week_individual_less_than_three_one_hour = int.Parse(oneHourLessThanThreeIndividualWeekDay);
            }
            //1,2
            string oneHourThreeToSixteenIndividualWeekDay = weekIndividualThreeToSixteenOnehour.Text;
            if (!(oneHourThreeToSixteenIndividualWeekDay.Length < 1))
            {
                weekDayPrice.week_individual_three_to_sixteen_one_hour = int.Parse(oneHourThreeToSixteenIndividualWeekDay);
            }
            //1,3
            string oneHourSixteenToSixtyIndividualWeekDay = weekIndividualSixteenToSixtyOnehour.Text;
            if (!(oneHourSixteenToSixtyIndividualWeekDay.Length < 1))
            {
                weekDayPrice.week_individual_sixteen_to_sixty_one_hour = int.Parse(oneHourSixteenToSixtyIndividualWeekDay);
            }
            //1,4
            string oneHourSixtyPlusIndividualWeekDay = weekIndividualAboveSixtyOnehour.Text;
            if (!(oneHourSixtyPlusIndividualWeekDay.Length < 1))
            {
                weekDayPrice.week_individual_sixty_plus_one_hour = int.Parse(oneHourSixtyPlusIndividualWeekDay);
            }
            //2,1
            string twoHourLessThanThreeIndividualWeekDay = weekIndividualBelowThreeTwoHour.Text;
            if (!(twoHourLessThanThreeIndividualWeekDay.Length < 1))
            {
                weekDayPrice.week_individual_less_than_three_two_hour = int.Parse(twoHourLessThanThreeIndividualWeekDay);
            }
            //2,2
            string twoHourThreeToSixteenIndividualWeekDay = weekIndividualThreeToSixteenTwoHour.Text;
            if (!(twoHourThreeToSixteenIndividualWeekDay.Length < 1))
            {
                weekDayPrice.week_individual_three_to_sixteen_two_hour = int.Parse(twoHourThreeToSixteenIndividualWeekDay);
            }
            //2,3
            string twoHourSixteenToSixtyIndividualWeekDay = weekIndividualSixteenToSixtyTwoHour.Text;
            if (!(twoHourSixteenToSixtyIndividualWeekDay.Length < 1))
            {
                weekDayPrice.week_individual_sixteen_to_sixty_two_hour = int.Parse(twoHourSixteenToSixtyIndividualWeekDay);
            }
            //2,4
            string twoHourSixtyPlusIndividualWeekDay = weekIndividualAboveSixtyTwoHour.Text;
            if (!(twoHourSixtyPlusIndividualWeekDay.Length < 1))
            {
                weekDayPrice.week_individual_sixty_plus_two_hour = int.Parse(twoHourSixtyPlusIndividualWeekDay);
            }
            //3,1
            string threeHourLessThanThreeIndividualWeekDay = weekIndividualBelowThreeThreeHour.Text;
            if (!(threeHourLessThanThreeIndividualWeekDay.Length < 1))
            {
                weekDayPrice.week_individual_less_than_three_three_hour = int.Parse(threeHourLessThanThreeIndividualWeekDay);
            }
            //3,2
            string threeHourThreeToSixteenIndividualWeekDay = weekIndividualThreeToSixteenThreeHour.Text;
            if (!(threeHourThreeToSixteenIndividualWeekDay.Length < 1))
            {
                weekDayPrice.week_individual_three_to_sixteen_three_hour = int.Parse(threeHourThreeToSixteenIndividualWeekDay);
            }
            //3,3
            string threeHourSixteenToSixtyIndividualWeekDay = weekIndividualSixteenToSixtyThreeHour.Text;
            if (!(threeHourSixteenToSixtyIndividualWeekDay.Length < 1))
            {
                weekDayPrice.week_individual_sixteen_to_sixty_three_hour = int.Parse(threeHourSixteenToSixtyIndividualWeekDay);
            }
            //3,4
            string threeHourSixtyPlusIndividualWeekDay = weekIndividualAboveSixtyThreeHour.Text;
            if (!(threeHourSixtyPlusIndividualWeekDay.Length < 1))
            {
                weekDayPrice.week_individual_sixty_plus_three_hour = int.Parse(threeHourSixtyPlusIndividualWeekDay);
            }
            //4,1
            string fourHourLessThanThreeIndividualWeekDay = weekIndividualBelowThreeFourHour.Text;
            if (!(fourHourLessThanThreeIndividualWeekDay.Length < 1))
            {
                weekDayPrice.week_individual_less_than_three_four_hour = int.Parse(fourHourLessThanThreeIndividualWeekDay);
            }
            //4,2
            string fourHourThreeToSixteenIndividualWeekDay = weekIndividualThreeToSixteenFourHour.Text;
            if (!(fourHourThreeToSixteenIndividualWeekDay.Length < 1))
            {
                weekDayPrice.week_individual_three_to_sixteen_four_hour = int.Parse(fourHourThreeToSixteenIndividualWeekDay);
            }
            //4,3
            string fourHourSixteenToSixtyIndividualWeekDay = weekIndividualSixteenToSixtyFourHour.Text;
            if (!(fourHourSixteenToSixtyIndividualWeekDay.Length < 1))
            {
                weekDayPrice.week_individual_sixteen_to_sixty_four_hour = int.Parse(fourHourSixteenToSixtyIndividualWeekDay);
            }
            //4,4
            string fourHourSixtyPlusIndividualWeekDay = weekIndividualAboveSixtyFourHour.Text;
            if (!(fourHourSixtyPlusIndividualWeekDay.Length < 1))
            {
                weekDayPrice.week_individual_sixty_plus_four_hour = int.Parse(fourHourSixtyPlusIndividualWeekDay);
            }
            //5,1
            string wholeDayLessThanThreeIndividualWeekDay = weekIndividualBelowThreeWholeDay.Text;
            if (!(wholeDayLessThanThreeIndividualWeekDay.Length < 1))
            {
                weekDayPrice.week_individual_less_than_three_whole_day = int.Parse(wholeDayLessThanThreeIndividualWeekDay);
            }
            //5,2
            string wholeDayThreeToSixteenIndividualWeekDay = weekIndividualThreeToSixteenWholeDay.Text;
            if (!(wholeDayThreeToSixteenIndividualWeekDay.Length < 1))
            {
                weekDayPrice.week_individual_three_to_sixteen_whole_day = int.Parse(wholeDayThreeToSixteenIndividualWeekDay);
            }
            //5,3
            string wholeDaySixteenToSixtyIndividualWeekDay = weekIndividualSixteenToSixtyWholeDay.Text;
            if (!(wholeDaySixteenToSixtyIndividualWeekDay.Length < 1))
            {
                weekDayPrice.week_individual_sixteen_to_sixty_whole_day = int.Parse(wholeDaySixteenToSixtyIndividualWeekDay);
            }
            //5,4
            string wholeDaySixtyPlusIndividualWeekDay = weekIndividualAboveSixtyWholeDay.Text;
            if (!(wholeDaySixtyPlusIndividualWeekDay.Length < 1))
            {
                weekDayPrice.week_individual_sixty_plus_whole_day = int.Parse(wholeDaySixtyPlusIndividualWeekDay);
            }

            //6,1
            string discountTwoToFiveGroupWeekDay = weekGroupTwoToFiveDiscount.Text;
            if (!(discountTwoToFiveGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_two_to_five_discount = int.Parse(discountTwoToFiveGroupWeekDay);
            }
            //6,2
            string discountFiveToTenGroupWeekDay = weekGroupFiveToTenDiscount.Text;
            if (!(discountFiveToTenGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_five_to_ten_discount = int.Parse(discountFiveToTenGroupWeekDay);
            }
            //6,3
            string discountTenToFifteenGroupWeekDay = weekGroupTenToFifteenDiscount.Text;
            if (!(discountTenToFifteenGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_ten_to_fifteen_discount = int.Parse(discountTenToFifteenGroupWeekDay);
            }
            //6,4
            string discountFifteenPlusGroupWeekDay = weekGroupAboveFifteenDiscount.Text;
            if (!(discountFifteenPlusGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_fifteen_plus_discount = int.Parse(discountFifteenPlusGroupWeekDay);
            }
            
            Utils.setOnFile(weekDayPrice.toJson(), Constants.WeekDay_FILE);
        }
        private void numberKeyDown(object sender, KeyEventArgs e)
        {
            Utils.validateForStringPress(sender, e, true);
        }

        private void cancelBtnWeek_Click(object sender, EventArgs e)
        {
            weekIndividualBelowThreeOnehour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualThreeToSixteenOnehour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualSixteenToSixtyOnehour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualAboveSixtyOnehour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualBelowThreeTwoHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualThreeToSixteenTwoHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualSixteenToSixtyTwoHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualAboveSixtyTwoHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualBelowThreeThreeHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualThreeToSixteenThreeHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualSixteenToSixtyThreeHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualAboveSixtyThreeHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualBelowThreeFourHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualThreeToSixteenFourHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualSixteenToSixtyFourHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualAboveSixtyFourHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualBelowThreeWholeDay.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualThreeToSixteenWholeDay.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualSixteenToSixtyWholeDay.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualAboveSixtyWholeDay.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupTwoToFiveDiscount.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupFiveToTenDiscount.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupTenToFifteenDiscount.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupAboveFifteenDiscount.Text = Properties.Settings.Default.TextBoxDefaultValue;
        }
    }
}
