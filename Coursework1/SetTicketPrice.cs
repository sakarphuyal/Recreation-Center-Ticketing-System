using Coursework1.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Coursework1
{
    public partial class SetTicketPrice : UserControl
    {
        public SetTicketPrice()
        {
            InitializeComponent();
        }

        private void saveBtnWeek_Click(object sender, EventArgs e)
        {
            Data.TicketPrice weekDayPrice = new TicketPrice();
            //1,1
            string oneHourLessThanThreeIndividualWeekDay = weekIndividualBelowThreeOnehour.Text;
            if (!(oneHourLessThanThreeIndividualWeekDay.Length < 1))
            {
                weekDayPrice.oneHourPrice = int.Parse(oneHourLessThanThreeIndividualWeekDay);
            }



            //2,1
            string twoHourLessThanThreeIndividualWeekDay = weekIndividualBelowThreeTwoHour.Text;
            if (!(twoHourLessThanThreeIndividualWeekDay.Length < 1))
            {
                weekDayPrice.twoHourPrice = int.Parse(twoHourLessThanThreeIndividualWeekDay);
            }

            string threeHourLessThanThreeIndividualWeekDay = weekIndividualBelowThreeThreeHour.Text;
            if (!(threeHourLessThanThreeIndividualWeekDay.Length < 1))
            {
                weekDayPrice.threeHourPrice = int.Parse(threeHourLessThanThreeIndividualWeekDay);
            }

            string fourHourLessThanThreeIndividualWeekDay = weekIndividualBelowThreeFourHour.Text;
            if (!(fourHourLessThanThreeIndividualWeekDay.Length < 1))
            {
                weekDayPrice.fourHourPrice = int.Parse(fourHourLessThanThreeIndividualWeekDay);
            }

            string wholeDayLessThanThreeIndividualWeekDay = weekIndividualBelowThreeWholeDay.Text;
            if (!(wholeDayLessThanThreeIndividualWeekDay.Length < 1))
            {
                weekDayPrice.wholeDayPrice = int.Parse(wholeDayLessThanThreeIndividualWeekDay);
            }

            string discountTwoToFiveGroupWeekDay = weekGroupTwoToFiveDiscount.Text;
            if (!(discountTwoToFiveGroupWeekDay.Length < 1))
            {
                weekDayPrice.groupFiveDiscount = int.Parse(discountTwoToFiveGroupWeekDay);
            }
            //6,2
            string discountFiveToTenGroupWeekDay = weekGroupFiveToTenDiscount.Text;
            if (!(discountFiveToTenGroupWeekDay.Length < 1))
            {
                weekDayPrice.groupTenDiscount = int.Parse(discountFiveToTenGroupWeekDay);
            }
            //6,3
            string discountTenToFifteenGroupWeekDay = weekGroupTenToFifteenDiscount.Text;
            if (!(discountTenToFifteenGroupWeekDay.Length < 1))
            {
                weekDayPrice.groupFifteenDiscount = int.Parse(discountTenToFifteenGroupWeekDay);
            }
            //6,4
            string discountFifteenPlusGroupWeekDay = weekGroupAboveFifteenDiscount.Text;
            if (!(discountFifteenPlusGroupWeekDay.Length < 1))
            {
                weekDayPrice.groupMaxDiscount = int.Parse(discountFifteenPlusGroupWeekDay);
            }

            if (childDiscount.Text.Length > 0)
            {
                System.Diagnostics.Debug.WriteLine("Wrote child");
                weekDayPrice.childDiscount = int.Parse(childDiscount.Text);
            }

            if (oldDiscount.Text.Length > 0)
            {
                weekDayPrice.oldDiscount = int.Parse(oldDiscount.Text);
            }

            if (holidayDiscount.Text.Length > 0)
            {
                weekDayPrice.holidayDiscount = int.Parse(holidayDiscount.Text);
            }
            if (weekendDiscount.Text.Length > 0)
            {
                weekDayPrice.weekendDiscount = int.Parse(weekendDiscount.Text);
            }

            Utils.writeToFile( Constants.PRICE_FILE, weekDayPrice.toJson());
        }
        private void numberKeyDown(object sender, KeyEventArgs e)
        {
            Utils.validateForStringPress(sender, e, true);
        }

        private void cancelBtnWeek_Click(object sender, EventArgs e)
        {
            weekIndividualBelowThreeOnehour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualBelowThreeTwoHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualBelowThreeThreeHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualBelowThreeFourHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekIndividualBelowThreeWholeDay.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupTwoToFiveDiscount.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupFiveToTenDiscount.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupTenToFifteenDiscount.Text = Properties.Settings.Default.TextBoxDefaultValue;
            weekGroupAboveFifteenDiscount.Text = Properties.Settings.Default.TextBoxDefaultValue;
        }
    }
}
