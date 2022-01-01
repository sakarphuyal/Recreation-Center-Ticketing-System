using Coursework1.Data;
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
    public partial class DailyReport : Form
    {
        private Font arial = new Font("Arial", 10f, FontStyle.Bold);

        public DailyReport()
        {
            InitializeComponent();

            ageRadio.Checked = true;

        }

        private void setReportBydate(DateTime date, bool isAge)
        {
            List<Ticket> ticktList = Utils.getTicketBookingListFromFile();
            if (ticktList.Count > 0)
            {

                var dayTickets = ticktList.Where(t => t.date.DayOfYear == date.DayOfYear);


                var noGroup = dayTickets.Where(t => t.childCount + t.normalCount + t.oldCount < 5);
                var fiveGroup = dayTickets.Where(t => (t.childCount + t.normalCount + t.oldCount >= 5 && t.childCount + t.normalCount + t.oldCount < 10));
                var tenGroup = dayTickets.Where(t => (t.childCount + t.normalCount + t.oldCount >= 10 && t.childCount + t.normalCount + t.oldCount < 15));
                var maxGroup = dayTickets.Where(t => (t.childCount + t.normalCount + t.oldCount >= 15));

                
                if (isAge)
                {
                    Dictionary<string, int> ageDict = new Dictionary<string, int>();

                    ageDict.Add("Child", dayTickets.Sum(t => t.childCount));
                    ageDict.Add("Adult", ticktList.Sum(t => t.normalCount));
                    ageDict.Add("Senior", ticktList.Sum(t => t.oldCount));

                    var dataSource = ageDict.Select(t => new
                    {
                        Age = t.Key,
                        Count = t.Value
                    });

                    dailyChart.Series[0].XValueMember = "Age";
                    dailyChart.Series[0].YValueMembers = "Count";
                    dailyChart.Series[0].IsValueShownAsLabel = true;
                    dailyChart.Series[0].Name = "Age";

                    dailyChart.DataSource = dataSource;
                    dailyChart.DataBind();

                    dailyTable.Controls.Clear();
                    dailyTable.RowCount = 6;

                    dailyTable.Controls.Add(new Label() { Text = "Age Groups", AutoSize = true, Font = arial }, 0, 0);
                    dailyTable.Controls.Add(new Label() { Text = "Number of Visitors", AutoSize = true, Font = arial }, 1, 0);

                    int rowNum = 1;
                    int count = 0;
                    foreach (string visitorGroup in ageDict.Keys)
                    {
                        dailyTable.Controls.Add(new Label() { Text = visitorGroup }, 0, rowNum);
                        dailyTable.Controls.Add(new Label() { Text = ageDict[visitorGroup].ToString() }, 1, rowNum);

                        count += ageDict[visitorGroup];

                        rowNum++;
                    }

                    dailyTable.Controls.Add(new Label() { Text = "Grand Total ", AutoSize = true, Font = arial }, 0, 5);
                    dailyTable.Controls.Add(new Label() { Text = count.ToString(), AutoSize = true, Font = arial }, 1, 5);

                }
                else
                {
                    Dictionary<string, int> groupDict = new Dictionary<string, int>();
                    groupDict.Add("< 5", noGroup.Count());
                    groupDict.Add("5 - 9", fiveGroup.Count());
                    groupDict.Add("10 - 14", tenGroup.Count());
                    groupDict.Add("15+", maxGroup.Count());

                    var dataSource = groupDict.Select(t => new
                    {
                        Group = t.Key,
                        Count = t.Value
                    });

                    dailyChart.Series[0].XValueMember = "Group";
                    dailyChart.Series[0].YValueMembers = "Count";
                    dailyChart.Series[0].IsValueShownAsLabel = true;
                    dailyChart.Series[0].Name = "Group";

                    dailyChart.DataSource = dataSource;
                    dailyChart.DataBind();


                    dailyTable.Controls.Clear();
                    dailyTable.RowCount = 6;

                    dailyTable.Controls.Add(new Label() { Text = "Visitor Groups", AutoSize = true, Font = arial }, 0, 0);
                    dailyTable.Controls.Add(new Label() { Text = "Number of Visitors", AutoSize = true, Font = arial }, 1, 0);

                    int rowNum = 1;
                    int count = 0;
                    foreach (string visitorGroup in groupDict.Keys)
                    {
                        dailyTable.Controls.Add(new Label() { Text = visitorGroup }, 0, rowNum);
                        dailyTable.Controls.Add(new Label() { Text = groupDict[visitorGroup].ToString() }, 1, rowNum);

                        count += groupDict[visitorGroup];

                        rowNum++;
                    }

                    dailyTable.Controls.Add(new Label() { Text = "Grand Total ", AutoSize = true, Font = arial }, 0, 5);
                    dailyTable.Controls.Add(new Label() { Text = count.ToString(), AutoSize = true, Font = arial }, 1, 5);
                }

            }
            else
            {
                System.Diagnostics.Debug.WriteLine("No data");
            }
        }

        private void datevalueChanged(object sender, EventArgs e)
        {
            setReportBydate(chartDay.Value, ageRadio.Checked);
        }

        private void radioCheckChanged(object sender, EventArgs e)
        {
            setReportBydate(chartDay.Value, ageRadio.Checked);
        }
    }
}
