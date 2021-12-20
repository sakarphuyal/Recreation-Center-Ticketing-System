
namespace Coursework1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.navHolidayBtn = new System.Windows.Forms.Button();
            this.navProgressChartBtn = new System.Windows.Forms.Button();
            this.navGenerateReportBtn = new System.Windows.Forms.Button();
            this.navBookBtn = new System.Windows.Forms.Button();
            this.navWeekBtn = new System.Windows.Forms.Button();
            this.setTicketPriceForWeekDays1 = new Coursework1.SetTicketPriceForWeekDays();
            this.bookTicket1 = new Coursework1.BookTicket();
            this.setTicketPriceForHolidays1 = new Coursework1.SetTicketPriceForHolidays();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 75);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(341, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticketing System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.navHolidayBtn);
            this.panel2.Controls.Add(this.navProgressChartBtn);
            this.panel2.Controls.Add(this.navGenerateReportBtn);
            this.panel2.Controls.Add(this.navBookBtn);
            this.panel2.Controls.Add(this.navWeekBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 507);
            this.panel2.TabIndex = 1;
            // 
            // navHolidayBtn
            // 
            this.navHolidayBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.navHolidayBtn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.navHolidayBtn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navHolidayBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.navHolidayBtn.Location = new System.Drawing.Point(3, 65);
            this.navHolidayBtn.Name = "navHolidayBtn";
            this.navHolidayBtn.Size = new System.Drawing.Size(129, 38);
            this.navHolidayBtn.TabIndex = 4;
            this.navHolidayBtn.Text = "Set Ticket Price for Holidays";
            this.navHolidayBtn.UseVisualStyleBackColor = false;
            this.navHolidayBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // navProgressChartBtn
            // 
            this.navProgressChartBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.navProgressChartBtn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.navProgressChartBtn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navProgressChartBtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.navProgressChartBtn.Location = new System.Drawing.Point(3, 213);
            this.navProgressChartBtn.Name = "navProgressChartBtn";
            this.navProgressChartBtn.Size = new System.Drawing.Size(129, 43);
            this.navProgressChartBtn.TabIndex = 3;
            this.navProgressChartBtn.Text = "Weekly Progress Chart";
            this.navProgressChartBtn.UseVisualStyleBackColor = false;
            this.navProgressChartBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // navGenerateReportBtn
            // 
            this.navGenerateReportBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.navGenerateReportBtn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.navGenerateReportBtn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navGenerateReportBtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.navGenerateReportBtn.Location = new System.Drawing.Point(3, 170);
            this.navGenerateReportBtn.Name = "navGenerateReportBtn";
            this.navGenerateReportBtn.Size = new System.Drawing.Size(129, 23);
            this.navGenerateReportBtn.TabIndex = 2;
            this.navGenerateReportBtn.Text = "Generate Report";
            this.navGenerateReportBtn.UseVisualStyleBackColor = false;
            this.navGenerateReportBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // navBookBtn
            // 
            this.navBookBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.navBookBtn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.navBookBtn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBookBtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.navBookBtn.Location = new System.Drawing.Point(3, 120);
            this.navBookBtn.Name = "navBookBtn";
            this.navBookBtn.Size = new System.Drawing.Size(129, 23);
            this.navBookBtn.TabIndex = 1;
            this.navBookBtn.Text = "Book Ticket";
            this.navBookBtn.UseVisualStyleBackColor = false;
            this.navBookBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // navWeekBtn
            // 
            this.navWeekBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.navWeekBtn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.navWeekBtn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navWeekBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.navWeekBtn.Location = new System.Drawing.Point(3, 7);
            this.navWeekBtn.Name = "navWeekBtn";
            this.navWeekBtn.Size = new System.Drawing.Size(129, 38);
            this.navWeekBtn.TabIndex = 0;
            this.navWeekBtn.Text = "Set Ticket Price for Week Days";
            this.navWeekBtn.UseVisualStyleBackColor = false;
            this.navWeekBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // setTicketPriceForWeekDays1
            // 
            this.setTicketPriceForWeekDays1.AutoScroll = true;
            this.setTicketPriceForWeekDays1.BackColor = System.Drawing.Color.Aquamarine;
            this.setTicketPriceForWeekDays1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setTicketPriceForWeekDays1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.setTicketPriceForWeekDays1.Location = new System.Drawing.Point(146, 75);
            this.setTicketPriceForWeekDays1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.setTicketPriceForWeekDays1.Name = "setTicketPriceForWeekDays1";
            this.setTicketPriceForWeekDays1.Size = new System.Drawing.Size(985, 507);
            this.setTicketPriceForWeekDays1.TabIndex = 4;
            this.setTicketPriceForWeekDays1.Load += new System.EventHandler(this.setTicketPriceForWeekDays1_Load);
            // 
            // bookTicket1
            // 
            this.bookTicket1.BackColor = System.Drawing.Color.Aquamarine;
            this.bookTicket1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookTicket1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bookTicket1.Location = new System.Drawing.Point(146, 75);
            this.bookTicket1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bookTicket1.Name = "bookTicket1";
            this.bookTicket1.Size = new System.Drawing.Size(985, 507);
            this.bookTicket1.TabIndex = 3;
            // 
            // setTicketPriceForHolidays1
            // 
            this.setTicketPriceForHolidays1.AutoScroll = true;
            this.setTicketPriceForHolidays1.BackColor = System.Drawing.Color.Aquamarine;
            this.setTicketPriceForHolidays1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setTicketPriceForHolidays1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.setTicketPriceForHolidays1.Location = new System.Drawing.Point(146, 75);
            this.setTicketPriceForHolidays1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.setTicketPriceForHolidays1.Name = "setTicketPriceForHolidays1";
            this.setTicketPriceForHolidays1.Size = new System.Drawing.Size(985, 507);
            this.setTicketPriceForHolidays1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1131, 582);
            this.Controls.Add(this.setTicketPriceForWeekDays1);
            this.Controls.Add(this.bookTicket1);
            this.Controls.Add(this.setTicketPriceForHolidays1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button navBookBtn;
        private System.Windows.Forms.Button navWeekBtn;
        private System.Windows.Forms.Button navGenerateReportBtn;
        private System.Windows.Forms.Button navProgressChartBtn;
        private System.Windows.Forms.Button navHolidayBtn;
        private SetTicketPriceForHolidays setTicketPriceForHolidays1;
        private BookTicket bookTicket1;
        private SetTicketPriceForWeekDays setTicketPriceForWeekDays1;
    }
}

