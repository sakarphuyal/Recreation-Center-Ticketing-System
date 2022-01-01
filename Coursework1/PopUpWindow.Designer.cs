
namespace Coursework1
{
    partial class PopUpWindow
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.childPrice = new System.Windows.Forms.TextBox();
            this.normalPrice = new System.Windows.Forms.TextBox();
            this.oldPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.popUpWindowId = new System.Windows.Forms.TextBox();
            this.saveBtnTicketBooking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ticket ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(56, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please Enter Number of People with their respective age group";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Less than 12 yrs (<12)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "12 to 60 yrs (12-60)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(532, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Above 60 (60+)";
            // 
            // childPrice
            // 
            this.childPrice.Location = new System.Drawing.Point(189, 163);
            this.childPrice.Name = "childPrice";
            this.childPrice.Size = new System.Drawing.Size(100, 20);
            this.childPrice.TabIndex = 19;
            this.childPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberKeyDown);
            // 
            // normalPrice
            // 
            this.normalPrice.Location = new System.Drawing.Point(358, 160);
            this.normalPrice.Name = "normalPrice";
            this.normalPrice.Size = new System.Drawing.Size(100, 20);
            this.normalPrice.TabIndex = 21;
            this.normalPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberKeyDown);
            // 
            // oldPrice
            // 
            this.oldPrice.Location = new System.Drawing.Point(535, 160);
            this.oldPrice.Name = "oldPrice";
            this.oldPrice.Size = new System.Drawing.Size(100, 20);
            this.oldPrice.TabIndex = 22;
            this.oldPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberKeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Number Of People";
            // 
            // popUpWindowId
            // 
            this.popUpWindowId.Location = new System.Drawing.Point(125, 35);
            this.popUpWindowId.Name = "popUpWindowId";
            this.popUpWindowId.ReadOnly = true;
            this.popUpWindowId.Size = new System.Drawing.Size(100, 20);
            this.popUpWindowId.TabIndex = 24;
            this.popUpWindowId.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // saveBtnTicketBooking
            // 
            this.saveBtnTicketBooking.BackColor = System.Drawing.Color.GreenYellow;
            this.saveBtnTicketBooking.Location = new System.Drawing.Point(246, 202);
            this.saveBtnTicketBooking.Name = "saveBtnTicketBooking";
            this.saveBtnTicketBooking.Size = new System.Drawing.Size(153, 34);
            this.saveBtnTicketBooking.TabIndex = 69;
            this.saveBtnTicketBooking.Text = "Save";
            this.saveBtnTicketBooking.UseVisualStyleBackColor = false;
            this.saveBtnTicketBooking.Click += new System.EventHandler(this.saveBtnTicketBooking_Click);
            // 
            // PopUpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(653, 248);
            this.ControlBox = false;
            this.Controls.Add(this.saveBtnTicketBooking);
            this.Controls.Add(this.popUpWindowId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.oldPrice);
            this.Controls.Add(this.normalPrice);
            this.Controls.Add(this.childPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Enabled = false;
            this.Location = new System.Drawing.Point(500, 300);
            this.Name = "PopUpWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopUpWindow";
            this.Load += new System.EventHandler(this.PopUpWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox childPrice;
        private System.Windows.Forms.TextBox normalPrice;
        private System.Windows.Forms.TextBox oldPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox popUpWindowId;
        private System.Windows.Forms.Button saveBtnTicketBooking;
    }
}