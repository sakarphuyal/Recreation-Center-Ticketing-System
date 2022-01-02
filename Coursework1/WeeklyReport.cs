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
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Coursework1
{
    public partial class WeeklyReport : Form
    {
        private Font arial = new Font("Arial", 10f, FontStyle.Bold);
        public WeeklyReport()
        {
            InitializeComponent();
            sortCombo.SelectedIndex = 0;
            weeklyReport();

        }
        private void weeklyReport()
        {
            List<Ticket> ticktList = Utils.getTicketBookingListFromFile();
            Dictionary<string, float[]> report = new Dictionary<string, float[]>();
            foreach (Ticket ticket in ticktList) 
            {
                System.Diagnostics.Debug.WriteLine(ticket.getTotalVistor());
                if (isThisWeek(ticket.date))
                {
                    if (report.ContainsKey(ticket.date.ToShortDateString()))
                    {
                        report[ticket.date.ToShortDateString()][0] += ticket.total_cost;
                        report[ticket.date.ToShortDateString()][1] += ticket.getTotalVistor();
                    }
                    else
                    {
                        float[] priceVistor = { ticket.total_cost, ticket.getTotalVistor() };
                        report.Add(ticket.date.ToShortDateString(), priceVistor);
                    }
                }
             
            }
            loadToChart(report);
        }
        private void loadToChart(Dictionary<string, float[]> report) {
            weeklyTable.Rows.Clear();
            weekChart.Series["Earning"].Points.Clear();
            weekChart.Series["Visitor"].Points.Clear();
            foreach (KeyValuePair<string, float[]>data in sort(report.ToList())) {
                weeklyTable.Rows.Add(data.Key, data.Value[1],data.Value[0]);
                weekChart.Series["Visitor"].Points.AddXY(data.Key, data.Value[1]);
                weekChart.Series["Earning"].Points.AddXY(data.Key, data.Value[0]);
            }

        }

        private bool isThisWeek(DateTime ticketDate) {  
                DateTime date = reportDatePicker.Value; //get current datetime 
                                              //get year from the date
                int year = date.Date.Year;
                //set the first day of the year
                DateTime firstDay = new DateTime(year, 1, 1);
                //get Day of the week 
                DayOfWeek day = date.DayOfWeek;
                CultureInfo cul = CultureInfo.CurrentCulture;
                //get no of week for the date
                int weekNo = cul.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
                //get no of day
                int days = (weekNo - 1) * 7;
                DateTime dt1 = firstDay.AddDays(days);
                DayOfWeek dow = dt1.DayOfWeek;
                DateTime startDateOfWeek = dt1.AddDays(-(int)dow);
                DateTime endDateOfWeek = startDateOfWeek.AddDays(6);
            return (startDateOfWeek <= ticketDate) & (endDateOfWeek >= ticketDate); 
      
        }

        private void reportDatePicker_ValueChanged(object sender, EventArgs e)
        {
            weeklyReport();
        }
        private Dictionary<string, float[]> sort(List<KeyValuePair<string, float[]>> weekList) {

            for (int i = weekList.Count - 1; i > 0; i--)
            {
                int sort = sortCombo.SelectedIndex;
                for (int j = 0; j <= i - 1; j++)
                {
                    if (weekList[j].Value[sort] > weekList[j + 1].Value[sort])
                    {
                        var big = weekList[j];
                        weekList[j] = weekList[j + 1];
                        weekList[j + 1] = big;
                    }
                }
            }
            return weekList.ToDictionary(x => x.Key, x => x.Value);
        }

        private void sortCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            weeklyReport();
        }
    }
}
