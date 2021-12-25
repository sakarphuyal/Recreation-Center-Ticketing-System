
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
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nameTextField = new System.Windows.Forms.TextBox();
            this.ageGroupComboBox = new System.Windows.Forms.ComboBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.numberOfPeopleComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.saveBtnTicketBooking = new System.Windows.Forms.Button();
            this.checkOutBtnTicketBooking = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ticketAutoIncresedId = new System.Windows.Forms.TextBox();
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
            this.label2.Location = new System.Drawing.Point(294, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "You can book Ticket here";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Booking";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 347);
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
            this.label4.Location = new System.Drawing.Point(67, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            this.label4.VisibleChanged += new System.EventHandler(this.saveBtnTicketBooking_Click);
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Age Group";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(447, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "In Time";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // nameTextField
            // 
            this.nameTextField.Location = new System.Drawing.Point(175, 180);
            this.nameTextField.Name = "nameTextField";
            this.nameTextField.Size = new System.Drawing.Size(174, 20);
            this.nameTextField.TabIndex = 13;
            this.nameTextField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextField_KeyPress);
            // 
            // ageGroupComboBox
            // 
            this.ageGroupComboBox.FormattingEnabled = true;
            this.ageGroupComboBox.Items.AddRange(new object[] {
            "0-3 years",
            "3-16 years",
            "16-60 years",
            "60 + years"});
            this.ageGroupComboBox.Location = new System.Drawing.Point(175, 224);
            this.ageGroupComboBox.Name = "ageGroupComboBox";
            this.ageGroupComboBox.Size = new System.Drawing.Size(174, 21);
            this.ageGroupComboBox.TabIndex = 17;
            this.ageGroupComboBox.SelectedIndexChanged += new System.EventHandler(this.ageGroupComboBox_SelectedIndexChanged);
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(575, 144);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(83, 20);
            this.timePicker.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(447, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Number of People";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // numberOfPeopleComboBox
            // 
            this.numberOfPeopleComboBox.FormattingEnabled = true;
            this.numberOfPeopleComboBox.Items.AddRange(new object[] {
            "0-5",
            "5-10",
            "10-15",
            "15+"});
            this.numberOfPeopleComboBox.Location = new System.Drawing.Point(575, 224);
            this.numberOfPeopleComboBox.Name = "numberOfPeopleComboBox";
            this.numberOfPeopleComboBox.Size = new System.Drawing.Size(108, 21);
            this.numberOfPeopleComboBox.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(456, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Date";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(575, 183);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(95, 20);
            this.datePicker.TabIndex = 27;
            // 
            // searchBtn
            // 
            this.searchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(365, 351);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(46, 22);
            this.searchBtn.TabIndex = 28;
            this.searchBtn.Tag = "";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(67, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 66;
            this.label9.Text = "Total Cost";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.Location = new System.Drawing.Point(175, 400);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.ReadOnly = true;
            this.totalCostTextBox.Size = new System.Drawing.Size(108, 20);
            this.totalCostTextBox.TabIndex = 67;
            this.totalCostTextBox.TextChanged += new System.EventHandler(this.clearBtnTicketBooking_Click);
            this.totalCostTextBox.VisibleChanged += new System.EventHandler(this.clearBtnTicketBooking_Click);
            // 
            // saveBtnTicketBooking
            // 
            this.saveBtnTicketBooking.BackColor = System.Drawing.Color.GreenYellow;
            this.saveBtnTicketBooking.Location = new System.Drawing.Point(351, 270);
            this.saveBtnTicketBooking.Name = "saveBtnTicketBooking";
            this.saveBtnTicketBooking.Size = new System.Drawing.Size(153, 34);
            this.saveBtnTicketBooking.TabIndex = 68;
            this.saveBtnTicketBooking.Text = "Save";
            this.saveBtnTicketBooking.UseVisualStyleBackColor = false;
            this.saveBtnTicketBooking.Click += new System.EventHandler(this.saveBtnTicketBooking_Click);
            // 
            // checkOutBtnTicketBooking
            // 
            this.checkOutBtnTicketBooking.BackColor = System.Drawing.Color.LightCoral;
            this.checkOutBtnTicketBooking.Location = new System.Drawing.Point(487, 363);
            this.checkOutBtnTicketBooking.Name = "checkOutBtnTicketBooking";
            this.checkOutBtnTicketBooking.Size = new System.Drawing.Size(153, 34);
            this.checkOutBtnTicketBooking.TabIndex = 69;
            this.checkOutBtnTicketBooking.Text = "Check-Out";
            this.checkOutBtnTicketBooking.UseVisualStyleBackColor = false;
            this.checkOutBtnTicketBooking.Click += new System.EventHandler(this.clearBtnTicketBooking_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 70;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberKeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "Ticket ID";
            // 
            // ticketAutoIncresedId
            // 
            this.ticketAutoIncresedId.Location = new System.Drawing.Point(175, 138);
            this.ticketAutoIncresedId.Name = "ticketAutoIncresedId";
            this.ticketAutoIncresedId.Size = new System.Drawing.Size(174, 20);
            this.ticketAutoIncresedId.TabIndex = 72;
            // 
            // BookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.Controls.Add(this.ticketAutoIncresedId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkOutBtnTicketBooking);
            this.Controls.Add(this.saveBtnTicketBooking);
            this.Controls.Add(this.totalCostTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numberOfPeopleComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.ageGroupComboBox);
            this.Controls.Add(this.nameTextField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "BookTicket";
            this.Size = new System.Drawing.Size(900, 475);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameTextField;
        private System.Windows.Forms.ComboBox ageGroupComboBox;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox numberOfPeopleComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private System.Windows.Forms.Button saveBtnTicketBooking;
        private System.Windows.Forms.Button checkOutBtnTicketBooking;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ticketAutoIncresedId;
    }
}
