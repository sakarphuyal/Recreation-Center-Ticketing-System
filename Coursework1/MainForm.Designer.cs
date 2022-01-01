
namespace Coursework1
{
    partial class MainForm
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
            this.navProgressChartBtn = new System.Windows.Forms.Button();
            this.navGenerateReportBtn = new System.Windows.Forms.Button();
            this.navBookBtn = new System.Windows.Forms.Button();
            this.navWeekBtn = new System.Windows.Forms.Button();
            this.bookTicket1 = new Coursework1.BookTicket();
            this.setTicketPriceForWeekDays1 = new Coursework1.SetTicketPrice();
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(327, -8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recreation Center";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.navProgressChartBtn);
            this.panel2.Controls.Add(this.navGenerateReportBtn);
            this.panel2.Controls.Add(this.navBookBtn);
            this.panel2.Controls.Add(this.navWeekBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 532);
            this.panel2.TabIndex = 1;
            // 
            // navProgressChartBtn
            // 
            this.navProgressChartBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.navProgressChartBtn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.navProgressChartBtn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navProgressChartBtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.navProgressChartBtn.Location = new System.Drawing.Point(3, 224);
            this.navProgressChartBtn.Name = "navProgressChartBtn";
            this.navProgressChartBtn.Size = new System.Drawing.Size(129, 43);
            this.navProgressChartBtn.TabIndex = 3;
            this.navProgressChartBtn.Text = "Weekly Progress Chart";
            this.navProgressChartBtn.UseVisualStyleBackColor = false;
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
            this.navGenerateReportBtn.Click += new System.EventHandler(this.navGenerateReportBtn_Click);
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
            this.navWeekBtn.Location = new System.Drawing.Point(3, 56);
            this.navWeekBtn.Name = "navWeekBtn";
            this.navWeekBtn.Size = new System.Drawing.Size(129, 38);
            this.navWeekBtn.TabIndex = 0;
            this.navWeekBtn.Text = "Set Ticket Price for Week Days";
            this.navWeekBtn.UseVisualStyleBackColor = false;
            this.navWeekBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookTicket1
            // 
            this.bookTicket1.BackColor = System.Drawing.Color.Aquamarine;
            this.bookTicket1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookTicket1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bookTicket1.Location = new System.Drawing.Point(146, 75);
            this.bookTicket1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bookTicket1.Name = "bookTicket1";
            this.bookTicket1.Size = new System.Drawing.Size(985, 532);
            this.bookTicket1.TabIndex = 3;
            // 
            // setTicketPriceForWeekDays1
            // 
            this.setTicketPriceForWeekDays1.AutoScroll = true;
            this.setTicketPriceForWeekDays1.BackColor = System.Drawing.Color.Aquamarine;
            this.setTicketPriceForWeekDays1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setTicketPriceForWeekDays1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.setTicketPriceForWeekDays1.Location = new System.Drawing.Point(146, 75);
            this.setTicketPriceForWeekDays1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.setTicketPriceForWeekDays1.Name = "setTicketPriceForWeekDays1";
            this.setTicketPriceForWeekDays1.Size = new System.Drawing.Size(985, 532);
            this.setTicketPriceForWeekDays1.TabIndex = 4;
            this.setTicketPriceForWeekDays1.Load += new System.EventHandler(this.setTicketPriceForWeekDays1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1131, 607);
            this.Controls.Add(this.setTicketPriceForWeekDays1);
            this.Controls.Add(this.bookTicket1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
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
        private BookTicket bookTicket1;
        private SetTicketPrice setTicketPriceForWeekDays1;
    }
}

