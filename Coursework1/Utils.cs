using Coursework1.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework1
{
    static class Utils
    {
        public static void setOnFile(string data, string fileName) {
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
            }

            File.AppendAllText(fileName, data+"\n");
        }
        public static void validateForStringPress(object sender, KeyEventArgs e, bool allowDecimal)
        {
            int[] exceptionKeyValues = { 8, 37, 39, 46, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105 };
            int[] numericDecimals = { 110, 190 };

            var decimalKeyValues = exceptionKeyValues.Union(numericDecimals);

            if (Char.IsDigit((char)e.KeyValue) || (allowDecimal ? decimalKeyValues : exceptionKeyValues).Contains(e.KeyValue))
            {
                ((TextBox)sender).ReadOnly = false;
            }
            else
            {
                ((TextBox)sender).ReadOnly = true;
            }
        }
        public static void validateForNumberPress(object sender, KeyEventArgs e, bool allowDecimal)
        {
            int[] exceptionKeyValues = { 8, 37, 39, 46, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105 };
            int[] numericDecimals = { 110, 190 };

            var decimalKeyValues = exceptionKeyValues.Union(numericDecimals);

            if (!(Char.IsDigit((char)e.KeyValue)) || (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back))
            {
                ((TextBox)sender).ReadOnly = false;  
            }
            else
            {
                ((TextBox)sender).ReadOnly = true;
            }
        }
        public static List<TicketPriceForHolidays> getHolidayPriceFromFile()
        {

            string[] lineValue = File.ReadAllLines(Constants.HOLIDAY_FILE);
            List<TicketPriceForHolidays> holidayList = new List<TicketPriceForHolidays>();
            foreach (string line in lineValue)
            {
                TicketPriceForHolidays mTicket = JsonConvert.DeserializeObject<TicketPriceForHolidays>(line);
                holidayList.Add(mTicket);
                System.Diagnostics.Debug.WriteLine(mTicket.holiday_individual_less_than_three_one_hour.ToString());
                //System.Diagnostics.Debug.WriteLine(mTicket.holiday_group_five_to_ten_one_hour.ToString());
            }
            return holidayList;

        }
        public static List<Ticket> getTicketBookingListFromFile()
        {

            string[] lineValue = File.ReadAllLines(Constants.TICKETBOOKING_FILE);
            List<Ticket> ticketList = new List<Ticket>();
            foreach (string line in lineValue)
            {
                Ticket mTicket = JsonConvert.DeserializeObject<Ticket>(line);
                ticketList.Add(mTicket);
            }
            return ticketList;

        }
        public static List<TicketPriceForWeekDays> getWeekDayPriceFromFile()
        {
            string[] lineValue = File.ReadAllLines(Constants.WeekDay_FILE);
            List<TicketPriceForWeekDays> weekDayList = new List<TicketPriceForWeekDays>();
            foreach (string line in lineValue)
            {
                TicketPriceForWeekDays mTicket = JsonConvert.DeserializeObject<TicketPriceForWeekDays>(line);
                weekDayList.Add(mTicket);
                System.Diagnostics.Debug.WriteLine(mTicket.week_individual_less_than_three_one_hour.ToString());
            }
            return weekDayList;
        }
    }
}
