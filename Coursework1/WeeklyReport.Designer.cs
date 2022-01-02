namespace Coursework1
{
    partial class WeeklyReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.weekChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.reportDatePicker = new System.Windows.Forms.DateTimePicker();
            this.sortCombo = new System.Windows.Forms.ComboBox();
            this.weeklyTable = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVisitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalEarning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.weekChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // weekChart
            // 
            chartArea4.Name = "ChartArea1";
            this.weekChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.weekChart.Legends.Add(legend4);
            this.weekChart.Location = new System.Drawing.Point(21, 22);
            this.weekChart.Name = "weekChart";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Visitor";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Earning";
            this.weekChart.Series.Add(series7);
            this.weekChart.Series.Add(series8);
            this.weekChart.Size = new System.Drawing.Size(300, 300);
            this.weekChart.TabIndex = 0;
            this.weekChart.Text = "chart1";
            // 
            // reportDatePicker
            // 
            this.reportDatePicker.Location = new System.Drawing.Point(520, 22);
            this.reportDatePicker.Name = "reportDatePicker";
            this.reportDatePicker.Size = new System.Drawing.Size(200, 20);
            this.reportDatePicker.TabIndex = 1;
            this.reportDatePicker.ValueChanged += new System.EventHandler(this.reportDatePicker_ValueChanged);
            // 
            // sortCombo
            // 
            this.sortCombo.FormattingEnabled = true;
            this.sortCombo.Items.AddRange(new object[] {
            "Earning",
            "Visitor"});
            this.sortCombo.Location = new System.Drawing.Point(520, 48);
            this.sortCombo.Name = "sortCombo";
            this.sortCombo.Size = new System.Drawing.Size(200, 21);
            this.sortCombo.TabIndex = 2;
            this.sortCombo.SelectedIndexChanged += new System.EventHandler(this.sortCombo_SelectedIndexChanged);
            // 
            // weeklyTable
            // 
            this.weeklyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weeklyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.totalVisitor,
            this.totalEarning});
            this.weeklyTable.Location = new System.Drawing.Point(342, 172);
            this.weeklyTable.Name = "weeklyTable";
            this.weeklyTable.Size = new System.Drawing.Size(344, 150);
            this.weeklyTable.TabIndex = 3;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // totalVisitor
            // 
            this.totalVisitor.HeaderText = "Total Visitor";
            this.totalVisitor.Name = "totalVisitor";
            // 
            // totalEarning
            // 
            this.totalEarning.HeaderText = "Total Earning";
            this.totalEarning.Name = "totalEarning";
            // 
            // WeeklyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 475);
            this.Controls.Add(this.weeklyTable);
            this.Controls.Add(this.sortCombo);
            this.Controls.Add(this.reportDatePicker);
            this.Controls.Add(this.weekChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeeklyReport";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.weekChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart weekChart;
        private System.Windows.Forms.DateTimePicker reportDatePicker;
        private System.Windows.Forms.ComboBox sortCombo;
        private System.Windows.Forms.DataGridView weeklyTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVisitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalEarning;
    }
}