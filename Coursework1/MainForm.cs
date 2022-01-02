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

    
    public partial class MainForm : Form
    {

        private DailyReport dailyReport;
        private WeeklyReport weeklyReport;

        private List<Control> mainControls = new List<Control>();
        public MainForm()
        {
            InitializeComponent();

            dailyReport = new DailyReport();
            weeklyReport = new WeeklyReport();

            
            dailyReport.TopLevel = false;
            dailyReport.Size = bookTicket1.Size;
            dailyReport.Location = new Point(110, 60);

            weeklyReport.TopLevel = false;
            weeklyReport.Size = bookTicket1.Size;
            weeklyReport.Location = new Point(110, 60);

            this.Controls.Add(dailyReport);
            this.Controls.Add(weeklyReport);

            mainControls.Add(dailyReport);
            mainControls.Add(weeklyReport);
            mainControls.Add(setTicketPriceForWeekDays1);
            mainControls.Add(bookTicket1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideControls();

            setTicketPriceForWeekDays1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideControls();
            bookTicket1.Visible = true;

        }

        private void setTicketPriceForWeekDays1_Load(object sender, EventArgs e)
        {

        }
        private void navGenerateReportBtn_Click(object sender, EventArgs e)
        {
            hideControls();
            dailyReport.Show();
            dailyReport.Visible = true;
        }

        /// <summary>
        /// Hides all the forms in MainForm
        /// </summary>
        private void hideControls()
        {
            mainControls.ForEach(x => x.Visible = false);
        }

        private void navProgressChartBtn_Click(object sender, EventArgs e)
        {
            hideControls();

            weeklyReport.Show();
            weeklyReport.Visible = true;
        }
    }
}
