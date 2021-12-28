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
    public partial class PopUpWindow : Form
    {
        public PopUpWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PopUpWindow newWindow = new PopUpWindow();
            this.Close();
           //newWindow.Enabled = false;
        }

        private void PopUpWindow_Load(object sender, EventArgs e)
        {
            List<Ticket> ticketList = Utils.getTicketBookingListFromFile();
            int lengthOfList = ticketList.Count();
            popUpWindowId.Text = (ticketList[lengthOfList-1].ticket_auto_incresed_id + 1).ToString();
        }
    }
}
