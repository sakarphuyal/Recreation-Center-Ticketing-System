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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            setTicketPriceForHolidays1.Visible = false;
            setTicketPriceForWeekDays1.Visible = true;
            bookTicket1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setTicketPriceForHolidays1.Visible = false;
            setTicketPriceForWeekDays1.Visible = false;
            bookTicket1.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void setTicketPriceFormWeekDays1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void setTicketPriceForHolidays1_Load(object sender, EventArgs e)
        {
        }
        
        private void bookTicket1_Load(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setTicketPriceForHolidays1.Visible = true;
            setTicketPriceForWeekDays1.Visible = false;
            bookTicket1.Visible = false;
        }

        private void setTicketPriceForWeekDays1_Load(object sender, EventArgs e)
        {

        }
    }
}
