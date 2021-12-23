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
    public partial class BookTicket : UserControl
    {
        private object setTicketPriceForHolidays;

        public BookTicket()
        {
            InitializeComponent();
        }

        public static bool Visisble { get; internal set; }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void numberKeyDown(object sender, KeyEventArgs e)
        {
            Utils.validateForStringPress(sender, e, false);
        }

        private void clearBtnTicketBooking_Click(object sender, EventArgs e)
        {
            Utils.getHolidayPriceFromFile();
        }

        private void saveBtnTicketBooking_Click(object sender, EventArgs e)
        {
            //Data.Ticket ticketList = new Data.Ticket();
            //string id = 
        }

        private void nameTextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back ||e.KeyChar == (char)Keys.Space);
        }

        private void ticketIdTextField_TextChanged(object sender, EventArgs e)
        {
            
        }


    }
}
