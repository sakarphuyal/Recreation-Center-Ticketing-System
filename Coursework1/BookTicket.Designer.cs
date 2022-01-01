
namespace Coursework1
{
    partial class BookTicket
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookTicket));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nameTextField = new System.Windows.Forms.TextBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.saveBtnTicketBooking = new System.Windows.Forms.Button();
            this.checkOutBtnTicketBooking = new System.Windows.Forms.Button();
            this.checkoutTextBoxId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ticketAutoIncresedId = new System.Windows.Forms.TextBox();
            this.clearBtnTicketBooking = new System.Windows.Forms.Button();
            this.continueBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkOut = new System.Windows.Forms.DateTimePicker();
            this.Enter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 76);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(2, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "You can book Ticket here";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(225, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Booking";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ticket ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(436, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "In Time";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // nameTextField
            // 
            this.nameTextField.Location = new System.Drawing.Point(175, 141);
            this.nameTextField.Name = "nameTextField";
            this.nameTextField.Size = new System.Drawing.Size(174, 20);
            this.nameTextField.TabIndex = 13;
            this.nameTextField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stringKeyDown);
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(575, 99);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(83, 20);
            this.timePicker.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(436, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Date";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(575, 138);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(95, 20);
            this.datePicker.TabIndex = 27;
            // 
            // searchBtn
            // 
            this.searchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(339, 353);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(209, 33);
            this.searchBtn.TabIndex = 28;
            this.searchBtn.Tag = "";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 66;
            this.label9.Text = "Total Cost";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.Location = new System.Drawing.Point(146, 353);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.ReadOnly = true;
            this.totalCostTextBox.Size = new System.Drawing.Size(108, 20);
            this.totalCostTextBox.TabIndex = 67;
            this.totalCostTextBox.Text = "0";
            // 
            // saveBtnTicketBooking
            // 
            this.saveBtnTicketBooking.BackColor = System.Drawing.Color.Lime;
            this.saveBtnTicketBooking.Location = new System.Drawing.Point(230, 198);
            this.saveBtnTicketBooking.Name = "saveBtnTicketBooking";
            this.saveBtnTicketBooking.Size = new System.Drawing.Size(153, 34);
            this.saveBtnTicketBooking.TabIndex = 68;
            this.saveBtnTicketBooking.Text = "Save";
            this.saveBtnTicketBooking.UseVisualStyleBackColor = false;
            this.saveBtnTicketBooking.Click += new System.EventHandler(this.saveBtnTicketBooking_Click);
            // 
            // checkOutBtnTicketBooking
            // 
            this.checkOutBtnTicketBooking.BackColor = System.Drawing.Color.Red;
            this.checkOutBtnTicketBooking.Location = new System.Drawing.Point(565, 312);
            this.checkOutBtnTicketBooking.Name = "checkOutBtnTicketBooking";
            this.checkOutBtnTicketBooking.Size = new System.Drawing.Size(153, 34);
            this.checkOutBtnTicketBooking.TabIndex = 69;
            this.checkOutBtnTicketBooking.Text = "Check-Out";
            this.checkOutBtnTicketBooking.UseVisualStyleBackColor = false;
            this.checkOutBtnTicketBooking.Click += new System.EventHandler(this.checkOutBtnTicketBooking_Click);
            // 
            // checkoutTextBoxId
            // 
            this.checkoutTextBoxId.Location = new System.Drawing.Point(146, 312);
            this.checkoutTextBoxId.Name = "checkoutTextBoxId";
            this.checkoutTextBoxId.Size = new System.Drawing.Size(108, 20);
            this.checkoutTextBoxId.TabIndex = 70;
            this.checkoutTextBoxId.TextChanged += new System.EventHandler(this.checkoutTextBoxId_TextChanged);
            this.checkoutTextBoxId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberKeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "Ticket ID";
            // 
            // ticketAutoIncresedId
            // 
            this.ticketAutoIncresedId.Location = new System.Drawing.Point(175, 99);
            this.ticketAutoIncresedId.Name = "ticketAutoIncresedId";
            this.ticketAutoIncresedId.ReadOnly = true;
            this.ticketAutoIncresedId.Size = new System.Drawing.Size(174, 20);
            this.ticketAutoIncresedId.TabIndex = 72;
            // 
            // clearBtnTicketBooking
            // 
            this.clearBtnTicketBooking.BackColor = System.Drawing.Color.Red;
            this.clearBtnTicketBooking.Location = new System.Drawing.Point(565, 356);
            this.clearBtnTicketBooking.Name = "clearBtnTicketBooking";
            this.clearBtnTicketBooking.Size = new System.Drawing.Size(153, 34);
            this.clearBtnTicketBooking.TabIndex = 73;
            this.clearBtnTicketBooking.Text = "Clear";
            this.clearBtnTicketBooking.UseVisualStyleBackColor = false;
            this.clearBtnTicketBooking.Click += new System.EventHandler(this.clearBtnTicketBooking_Click_2);
            // 
            // continueBtn
            // 
            this.continueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.continueBtn.Location = new System.Drawing.Point(410, 198);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(153, 34);
            this.continueBtn.TabIndex = 79;
            this.continueBtn.Text = "Continue";
            this.continueBtn.UseVisualStyleBackColor = false;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(279, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 80;
            this.label7.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(339, 315);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(209, 20);
            this.name.TabIndex = 81;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(70, 398);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 17);
            this.label13.TabIndex = 84;
            this.label13.Text = "CheckOut Time";
            // 
            // checkOut
            // 
            this.checkOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.checkOut.Location = new System.Drawing.Point(200, 398);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(83, 20);
            this.checkOut.TabIndex = 85;
            // 
            // Enter
            // 
            this.Enter.Enabled = false;
            this.Enter.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic);
            this.Enter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Enter.Location = new System.Drawing.Point(3, 264);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(734, 30);
            this.Enter.TabIndex = 87;
            this.Enter.Text = "Enter TicketId For Check-Out";
            this.Enter.UseVisualStyleBackColor = false;
            // 
            // BookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.clearBtnTicketBooking);
            this.Controls.Add(this.ticketAutoIncresedId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkoutTextBoxId);
            this.Controls.Add(this.checkOutBtnTicketBooking);
            this.Controls.Add(this.saveBtnTicketBooking);
            this.Controls.Add(this.totalCostTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.nameTextField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "BookTicket";
            this.Size = new System.Drawing.Size(748, 475);
            this.Load += new System.EventHandler(this.BookTicket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameTextField;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private System.Windows.Forms.Button saveBtnTicketBooking;
        private System.Windows.Forms.Button checkOutBtnTicketBooking;
        private System.Windows.Forms.TextBox checkoutTextBoxId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ticketAutoIncresedId;
        private System.Windows.Forms.Button clearBtnTicketBooking;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker checkOut;
        private new System.Windows.Forms.Button Enter;
    }
}
