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
            string oneHourTwoToFiveGroupWeekDay = weekGroupTwoToFiveOneHour.Text;
            if (!(oneHourTwoToFiveGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_two_to_five_one_hour = int.Parse(oneHourTwoToFiveGroupWeekDay);
            }
            //6,2
            string oneHourFiveToTenGroupWeekDay = weekGroupFiveToTenOneHour.Text;
            if (!(oneHourFiveToTenGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_five_to_ten_one_hour = int.Parse(oneHourFiveToTenGroupWeekDay);
            }
            //6,3
            string oneHourTenToFifteenGroupWeekDay = weekGroupTenToFifteenOneHour.Text;
            if (!(oneHourTenToFifteenGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_ten_to_fifteen_one_hour = int.Parse(oneHourTenToFifteenGroupWeekDay);
            }
            //6,4
            string oneHourFifteenPlusGroupWeekDay = weekGroupAboveFifteenOneHour.Text;
            if (!(oneHourFifteenPlusGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_fifteen_plus_one_hour = int.Parse(oneHourFifteenPlusGroupWeekDay);
            }
            //7,1
            string twoHourTwoToFiveGroupWeekDay = weekGroupTwoToFiveTwoHour.Text;
            if (!(twoHourTwoToFiveGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_two_to_five_two_hour = int.Parse(twoHourTwoToFiveGroupWeekDay);
            }
            //7,2
            string twoHourFiveToTenGroupWeekDay = weekGroupFiveToTenTwoHour.Text;
            if (!(twoHourFiveToTenGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_five_to_ten_two_hour = int.Parse(twoHourFiveToTenGroupWeekDay);
            }
            //7,3
            string twoHourTenToFifteenGroupWeekDay = weekGroupTenToFifteenTwoHour.Text;
            if (!(twoHourTenToFifteenGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_ten_to_fifteen_two_hour = int.Parse(twoHourTenToFifteenGroupWeekDay);
            }
            //7,4
            string twoHourFifteenPlusGroupWeekDay = weekGroupAboveFifteenTwoHour.Text;
            if (!(twoHourFifteenPlusGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_fifteen_above_two_hour = int.Parse(twoHourFifteenPlusGroupWeekDay);
            }
            //8,1
            string threeHourTwoToFiveGroupWeekDay = weekGroupTwoToFiveThreeHour.Text;
            if (!(threeHourTwoToFiveGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_two_to_five_three_hour = int.Parse(threeHourTwoToFiveGroupWeekDay);
            }
            //8,2
            string threeHourFiveToTenGroupWeekDay = weekGroupFiveToTenThreeHour.Text;
            if (!(threeHourFiveToTenGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_five_to_ten_three_hour = int.Parse(threeHourFiveToTenGroupWeekDay);
            }
            //8,3
            string threeHourTenToFifteenGroupWeekDay = weekGroupTenToFifteenThreeHour.Text;
            if (!(threeHourTenToFifteenGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_ten_to_fifteen_three_hour = int.Parse(threeHourTenToFifteenGroupWeekDay);
            }
            //8,4
            string threeHourFifteenPlusGroupWeekDay = weekGroupAboveFifteenThreeHour.Text;
            if (!(threeHourFifteenPlusGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_fifteen_plus_three_hour = int.Parse(threeHourFifteenPlusGroupWeekDay);
            }
            //9,1
            string fourHourTwoToFiveGroupWeekDay = weekGroupTwoToFiveFourHour.Text;
            if (!(fourHourTwoToFiveGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_two_to_five_four_hour = int.Parse(fourHourTwoToFiveGroupWeekDay);
            }
            //9,2
            string fourHourFiveToTenGroupWeekDay = weekGroupFiveToTenFourHour.Text;
            if (!(fourHourFiveToTenGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_five_to_ten_four_hour = int.Parse(fourHourFiveToTenGroupWeekDay);
            }
            //9,3
            string fourHourTenToFifteenGroupWeekDay = weekGroupTenToFifteenFourHour.Text;
            if (!(fourHourTenToFifteenGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_ten_to_fifteen_four_hour = int.Parse(fourHourTenToFifteenGroupWeekDay);
            }
            //9,4
            string fourHourFifteenPlusGroupWeekDay = weekGroupAboveFifteenFourHour.Text;
            if (!(fourHourFifteenPlusGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_fifteen_plus_four_hour = int.Parse(fourHourFifteenPlusGroupWeekDay);
            }
            //10,1
            string wholeDayTwoToFiveGroupWeekDay = weekGroupTwoToFiveWholeDay.Text;
            if (!(wholeDayTwoToFiveGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_two_to_five_whole_day = int.Parse(wholeDayTwoToFiveGroupWeekDay);
            }
            //10,2
            string wholeDayFiveToTenGroupWeekDay = weekGroupFiveToTenWholeDay.Text;
            if (!(wholeDayFiveToTenGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_five_to_ten_whole_day = int.Parse(wholeDayFiveToTenGroupWeekDay);
            }
            //10,3
            string wholeDayTenToFifteenGroupWeekDay = weekGroupTenToFifteenWholeDay.Text;
            if (!(wholeDayTenToFifteenGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_ten_to_fifteen_whole_day = int.Parse(wholeDayTenToFifteenGroupWeekDay);
            }
            //10,4
            string wholeDayFifteenPlusGroupWeekDay = weekGroupAboveFifteenWholeDay.Text;
            if (!(wholeDayFifteenPlusGroupWeekDay.Length < 1))
            {
                weekDayPrice.week_group_fifteen_plus_whole_day = int.Parse(wholeDayFifteenPlusGroupWeekDay);
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
            weekGroupTwoToFiveOneHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupFiveToTenOneHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupTenToFifteenOneHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupAboveFifteenOneHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupTwoToFiveTwoHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupFiveToTenTwoHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupTenToFifteenTwoHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupAboveFifteenTwoHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupTwoToFiveThreeHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupFiveToTenThreeHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupTenToFifteenThreeHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupAboveFifteenThreeHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupTwoToFiveFourHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupFiveToTenFourHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupTenToFifteenFourHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupAboveFifteenFourHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupTwoToFiveWholeDay.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupFiveToTenWholeDay.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupTenToFifteenWholeDay.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupAboveFifteenWholeDay.Text = Properties.Settings.Default.TextBoxDefaultValue;


        }
    }
}
