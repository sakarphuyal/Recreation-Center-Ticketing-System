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
            }
            return holidayList;

        }

        // FIXME Use this function instead of reading from file directly
        public static List<Ticket> getTicketBookingListFromFile()
        {
            if (File.Exists(Constants.TICKETBOOKING_FILE))
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
            return new List<Ticket>();

        }

        public static bool setCheckoutValues(int id, DateTime checkOutTime) {
            List<Ticket> allTicket = getTicketBookingListFromFile();
            List<Ticket> selectedTicket = allTicket.Where(t => t.ticket_auto_incresed_id == id).ToList();


            if (selectedTicket.Count > 0)
            {
                //  Assumes that every ticket has unique ID
                Ticket mTicket = selectedTicket.First();

                mTicket.check_out = checkOutTime;

                // TODO do price calculation here.
                mTicket.total_cost =  calculatePrice(mTicket);

                allTicket.Remove(selectedTicket.First());
                allTicket.Add(mTicket);
                allTicket.Sort();

                string jsonHolder = "";
                allTicket.ForEach(t => jsonHolder += t.toJson()+"\n");

                writeToFile(Constants.TICKETBOOKING_FILE, jsonHolder);

                return true;
            }

            return false;
        }

        public static int calculatePrice(Ticket ticket) {
            // TODO calculate price here

            return ticket.three_to_sixteen * 12 + 1;  // TODO remove this - DUMMY VALUE
        }


        /// <summary>
        /// Replaces everything on the file with 'data'
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="data"></param>
        public static void writeToFile(string fileName, string data) {
            if (File.Exists(fileName))
            {
                File.WriteAllText(fileName, data);
            }
        }

        public static List<TicketPriceForWeekDays> getWeekDayPriceFromFile()
        {
            string[] lineValue = File.ReadAllLines(Constants.WeekDay_FILE);
            List<TicketPriceForWeekDays> weekDayList = new List<TicketPriceForWeekDays>();
            foreach (string line in lineValue)
            {
                TicketPriceForWeekDays mTicket = JsonConvert.DeserializeObject<TicketPriceForWeekDays>(line);
                weekDayList.Add(mTicket);
            }
            return weekDayList;
        }
    }
}
