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
        public static void setOnFile(string data, string fileName)
        {
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
            }

            File.AppendAllText(fileName, data + "\n");
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

        public static bool setCheckoutValues(int id, DateTime checkOutTime)
        {
            List<Ticket> allTicket = getTicketBookingListFromFile();
            List<Ticket> selectedTicket = allTicket.Where(t => t.ticketId == id).ToList();


            if (selectedTicket.Count > 0)
            {
                //  Assumes that every ticket has unique ID
                Ticket mTicket = selectedTicket.First();

                mTicket.check_out = checkOutTime;

                // TODO do price calculation here.
                mTicket.total_cost = calculatePrice(mTicket);

                allTicket.Remove(selectedTicket.First());
                allTicket.Add(mTicket);
                allTicket.Sort();

                string jsonHolder = "";
                allTicket.ForEach(t => jsonHolder += t.toJson() + "\n");

                writeToFile(Constants.TICKETBOOKING_FILE, jsonHolder);

                return true;
            }

            return false;
        }

        public static int calculatePrice(Ticket ticket)
        {
            // Assumes that there's only one price object
            TicketPrice weekPrice = getWeekDayPriceFromFile()[0];

            // Assumes that price is valid.
            int vPrice;
            switch (ticket.check_out.Subtract(ticket.check_out).TotalHours)
            {
                case double i when (i <= 1):
                    vPrice = weekPrice.oneHourPrice;
                    break;
                case double i when (i > 1 && i <= 2):
                    vPrice = weekPrice.twoHourPrice;
                    break;
                case double i when (i > 2 && i <= 3):
                    vPrice = weekPrice.threeHourPrice;
                    break;
                case double i when (i > 3 && i <= 4):
                    vPrice = weekPrice.fourHourPrice;
                    break;
                default:
                    vPrice = weekPrice.wholeDayPrice;
                    break;
            }

            int totalVisitors = ticket.childCount + ticket.oldCount + ticket.normalCount;


            int groupDiscount;
            switch (totalVisitors)
            {
                case int i when (i < 5):
                    groupDiscount = 0;
                    break;

                case int i when (i >= 5 && i < 10):
                    groupDiscount = weekPrice.groupFiveDiscount;
                    break;

                case int i when (i >= 10 && i < 15):
                    groupDiscount = weekPrice.groupTenDiscount;
                    break;

                default:
                    groupDiscount = weekPrice.groupMaxDiscount;
                    break;
            }

            // TODO add holiday as well.
            vPrice = isWeekend(ticket.in_time)? vPrice - weekPrice.weekendDiscount :vPrice;

            int childPrice = ticket.childCount * (vPrice - weekPrice.childDiscount);
            int oldPrice = ticket.oldCount * (vPrice - weekPrice.oldDiscount);
            int normalPrice = ticket.normalCount * vPrice;

            return childPrice + oldPrice + normalPrice  - groupDiscount;  // TODO remove this - DUMMY VALUE
        }


        public static bool isWeekend(DateTime date) { return date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday; }

        /// <summary>
        /// Replaces everything on the file with 'data'
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="data"></param>
        public static void writeToFile(string fileName, string data)
        {
            if (File.Exists(fileName))
            {
                File.WriteAllText(fileName, data);
            }
            else
            {
                File.Create(fileName).Close();
                File.WriteAllText(fileName, data);
            }
        }

        public static List<TicketPrice> getWeekDayPriceFromFile()
        {
            string[] lineValue = File.ReadAllLines(Constants.PRICE_FILE);
            List<TicketPrice> weekDayList = new List<TicketPrice>();
            foreach (string line in lineValue)
            {
                TicketPrice mTicket = JsonConvert.DeserializeObject<TicketPrice>(line);
                weekDayList.Add(mTicket);
            }
            return weekDayList;
        }
    }
}
