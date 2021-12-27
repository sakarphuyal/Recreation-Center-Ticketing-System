using Coursework1.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework1
{
    public partial class SetTicketPriceForHolidays : UserControl
    {
        public SetTicketPriceForHolidays()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetTicketPriceForHolidays_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void saveBtnHoliday_Click(object sender, EventArgs e)
        {
            TicketPriceForHolidays holidayPrice = new TicketPriceForHolidays();
            //1,1
            string oneHourLessThanThreeIndividualHoliday = holidayIndividualLessThanThreeOnehour.Text;
            if (!(oneHourLessThanThreeIndividualHoliday.Length < 1))
            {
                holidayPrice.holiday_individual_less_than_three_one_hour = int.Parse(oneHourLessThanThreeIndividualHoliday);
            }
            //1,2
            string oneHourThreeToSixteenIndividualHoliday = holidayIndividualThreeToSixteenOnehour.Text;
            if (!(oneHourThreeToSixteenIndividualHoliday.Length < 1))
            {
                holidayPrice.holiday_individual_three_to_sixteen_one_hour = int.Parse(oneHourThreeToSixteenIndividualHoliday);
            }
            //1,3
            string oneHourSixteenToSixtyIndividualHoliday = holidayIndividualSixteenToSixtyOnehour.Text;
            if (!(oneHourSixteenToSixtyIndividualHoliday.Length < 1))
            {
                holidayPrice.holiday_individual_sixteen_to_sixty_one_hour = int.Parse(oneHourSixteenToSixtyIndividualHoliday);
            }
            //1,4
            string oneHourSixtyPlusIndividualHoliday = holidayIndividualAboveSixtyOnehour.Text;
            if (!(oneHourSixtyPlusIndividualHoliday.Length < 1))
            {
                holidayPrice.holiday_individual_sixty_plus_one_hour = int.Parse(oneHourSixtyPlusIndividualHoliday); 
            }
            //2,1
            string twoHourLessThanThreeIndividualHoliday = holidayIndividualLessThanThreeOnehour.Text;
            if (!(twoHourLessThanThreeIndividualHoliday.Length < 1))
            {
                holidayPrice.holiday_individual_less_than_three_one_hour = int.Parse(twoHourLessThanThreeIndividualHoliday);
            }
            //2,2
            string twoHourThreeToSixteenIndividualHoliday = holidayIndividualThreeToSixteenTwoHour.Text;
            if (!(twoHourThreeToSixteenIndividualHoliday.Length < 1))
            {
                holidayPrice.holiday_individual_three_to_sixteen_two_hour = int.Parse(twoHourThreeToSixteenIndividualHoliday);    
            }
            //2,3
            string twoHourSixteenToSixtyIndividualHoliday = holidayIndividualSixteenToSixtyTwoHour.Text;
            if (!(twoHourSixteenToSixtyIndividualHoliday.Length < 1))
            {
                holidayPrice.holiday_individual_sixteen_to_sixty_two_hour = int.Parse(twoHourSixteenToSixtyIndividualHoliday);   
            }
            //2,4
            string twoHourSixtyPlusIndividualHoliday = holidayIndividualSixtyPlusTwoHour.Text;
            if (!(twoHourSixtyPlusIndividualHoliday.Length < 1))
            {
                holidayPrice.holiday_individual_sixty_plus_two_hour = int.Parse(twoHourSixtyPlusIndividualHoliday);
            }
            //3,1
            string threeHourLessThanThreeIndividualHoliday = holidayIndividualLessThanThreeThreeHour.Text;
            if (!(threeHourLessThanThreeIndividualHoliday.Length < 1))
            {
                holidayPrice.holiday_individual_less_than_three_three_hour = int.Parse(threeHourLessThanThreeIndividualHoliday);   
            }
            //3,2
            string threeHourThreeToSixteenIndividualHoliday = holidayIndividualThreeToSixteenThreeHour.Text;
            if (!(threeHourThreeToSixteenIndividualHoliday.Length < 1))
            {
                holidayPrice.holiday_individual_three_to_sixteen_three_hour = int.Parse(threeHourThreeToSixteenIndividualHoliday);  
            }
            //3,3
            string threeHourSixteenToSixtyIndividualHoliday = holidayIndividualSixteenToSixtyThreeHour.Text;
            if (!(threeHourSixteenToSixtyIndividualHoliday.Length < 1))
            {
                holidayPrice.holiday_individual_sixteen_to_sixty_three_hour = int.Parse(threeHourSixteenToSixtyIndividualHoliday);
            }
            //3,4
            string threeHourSixtyPlusIndividualHoliday = holidayIndividualAboveSixtyThreeHour.Text;
            if (!(threeHourSixtyPlusIndividualHoliday.Length < 1))
            {
                holidayPrice.holiday_individual_sixty_plus_three_hour = int.Parse(threeHourSixtyPlusIndividualHoliday);   
            }
            //4,1
            string fourHourLessThanThreeIndividualHoliday = holidayIndividualBelowThreeFourHour.Text;
            if (!(fourHourLessThanThreeIndividualHoliday.Length < 1))
            {
                holidayPrice.holiday_individual_less_than_three_four_hour = int.Parse(fourHourLessThanThreeIndividualHoliday);    
            }
            //4,2
            string fourHourThreeToSixteenIndividualHoliday = holidayIndividualThreeToSixteenFourHour.Text;
            if (!(fourHourThreeToSixteenIndividualHoliday.Length < 1))
            {
                holidayPrice.holiday_individual_three_to_sixteen_four_hour = int.Parse(fourHourThreeToSixteenIndividualHoliday);                
            }
            //4,3
            string fourHourSixteenToSixtyIndividualHoliday = holidayIndividualSixteenToSixtyFourHour.Text;
            if (!(fourHourSixteenToSixtyIndividualHoliday.Length < 1))
            {
                holidayPrice.holiday_individual_sixteen_to_sixty_four_hour = int.Parse(fourHourSixteenToSixtyIndividualHoliday);        
            }
            //4,4
            string fourHourSixtyPlusIndividualHoliday = holidayIndividualAboveSixtyFourHour.Text;
            if (!(fourHourSixtyPlusIndividualHoliday.Length < 1))
            {
                holidayPrice.holiday_individual_sixty_plus_four_hour = int.Parse(fourHourSixtyPlusIndividualHoliday);    
            }
            //5,1
            string wholeDayLessThanThreeIndividualHoliday = holidayIndividualLessThanThreeWholeDay.Text;
            if (!(wholeDayLessThanThreeIndividualHoliday.Length < 1))
            {
                holidayPrice.holiday_individual_less_than_three_whole_day = int.Parse(wholeDayLessThanThreeIndividualHoliday);                
            }
            //5,2
            string wholeDayThreeToSixteenIndividualHoliday = holidayIndividualThreeToSixteenWholeDay.Text;
            if (!(wholeDayThreeToSixteenIndividualHoliday.Length < 1))
            {
                holidayPrice.holiday_individual_three_to_sixteen_whole_day = int.Parse(wholeDayThreeToSixteenIndividualHoliday);                
            }
            //5,3
            string wholeDaySixteenToSixtyIndividualHoliday = holidayIndividualSixteenToSixtyWholeDay.Text;
            if (!(wholeDaySixteenToSixtyIndividualHoliday.Length < 1))
            {
                holidayPrice.holiday_individual_sixteen_to_sixty_whole_day = int.Parse(wholeDaySixteenToSixtyIndividualHoliday);    
            }
            //5,4
            string wholeDaySixtyPlusIndividualHoliday = holidayIndividualAboveSixtyWholeDay.Text;
            if (!(wholeDaySixtyPlusIndividualHoliday.Length < 1))
            {
                holidayPrice.holiday_individual_sixty_plus_whole_day = int.Parse(wholeDaySixtyPlusIndividualHoliday);   
            }
            //6,1
            string oneHourTwoToFiveGroupHoliday = holidayGroupTwoToFiveDiscount.Text;
            if (!(oneHourTwoToFiveGroupHoliday.Length < 1))
            {
                holidayPrice.holiday_group_two_to_five_Discount = int.Parse(oneHourTwoToFiveGroupHoliday);               
            }
            //6,2
            string discountFiveToTenGroupHoliday = holidayGroupFiveToTenDiscount.Text;
            if (!(discountFiveToTenGroupHoliday.Length < 1))
            {
                holidayPrice.holiday_group_five_to_ten_Discount = int.Parse(discountFiveToTenGroupHoliday);    
            }
            //6,3
            string discountTenToFifteenGroupHoliday = holidayGroupTenToFifteenDiscount.Text;
            if (!(discountTenToFifteenGroupHoliday.Length < 1))
            {
                holidayPrice.holiday_group_ten_to_fifteen_Discount = int.Parse(discountTenToFifteenGroupHoliday);        
            }
            //6,4
            string discountFifteenPlusGroupHoliday = holidayGroupAboveFifteenDiscount.Text;
            if (!(discountFifteenPlusGroupHoliday.Length < 1))
            {
                holidayPrice.holiday_group_fifteen_plus_Discount = int.Parse(discountFifteenPlusGroupHoliday);   
            }
            Utils.setOnFile(holidayPrice.toJson(), Constants.HOLIDAY_FILE);

        }

        private void holidayIndividualAboveSixtyOnehour_TextChanged(object sender, EventArgs e)
        {
        }

        private void numberKeyDown(object sender, KeyEventArgs e)
        {
            Utils.validateForStringPress(sender, e, true);
        }

        private void resetBtnHoliday_Click(object sender, EventArgs e)
        {
            holidayIndividualLessThanThreeOnehour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayIndividualThreeToSixteenOnehour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayIndividualSixteenToSixtyOnehour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayIndividualAboveSixtyOnehour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayIndividualLessThanThreeTwoHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayIndividualThreeToSixteenTwoHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayIndividualSixteenToSixtyTwoHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayIndividualSixtyPlusTwoHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayIndividualLessThanThreeThreeHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayIndividualThreeToSixteenThreeHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayIndividualSixteenToSixtyThreeHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayIndividualAboveSixtyThreeHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayIndividualBelowThreeFourHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayIndividualThreeToSixteenFourHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayIndividualSixteenToSixtyFourHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayIndividualAboveSixtyFourHour.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayIndividualLessThanThreeWholeDay.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayIndividualThreeToSixteenWholeDay.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayIndividualSixteenToSixtyWholeDay.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayIndividualAboveSixtyWholeDay.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayGroupTwoToFiveDiscount.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayGroupFiveToTenDiscount.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayGroupTenToFifteenDiscount.Text = Properties.Settings.Default.TextBoxDefaultValue;
            holidayGroupAboveFifteenDiscount.Text = Properties.Settings.Default.TextBoxDefaultValue;
        }

        private void holidayGroupFiveToTenOneHour_TextChanged(object sender, EventArgs e)
        {

        }

        private void holidayIndividualLessThanThreeOnehour_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
