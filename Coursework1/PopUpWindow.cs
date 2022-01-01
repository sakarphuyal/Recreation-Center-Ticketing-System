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



        private void PopUpWindow_Load(object sender, EventArgs e)
        {
            //List<Ticket> ticketList = Utils.getTicketBookingListFromFile();
            //int lengthOfList = ticketList.Count();
            //popUpWindowId.Text = (ticketList[lengthOfList-1].ticket_auto_incresed_id + 1).ToString();
        }

        private void saveBtnTicketBooking_Click(object sender, EventArgs e)
        {
            Constants.numberHolder.below_three = (childPrice.Text.Length < 1) ? 0 : int.Parse(childPrice.Text);
            Constants.numberHolder.sixteen_to_sixty = (normalPrice.Text.Length < 1) ? 0 : int.Parse(normalPrice.Text);
            Constants.numberHolder.above_sixty = (oldPrice.Text.Length < 1) ? 0 : int.Parse(oldPrice.Text);
            this.Close();
            saveBtnTicketBooking.Enabled = true;
        }

        private void numberKeyDown(object sender, KeyEventArgs e)
        {
            Utils.validateForStringPress(sender, e, true);
        }
    }
}
