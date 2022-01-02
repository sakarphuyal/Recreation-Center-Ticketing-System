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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.weekChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.weekDate = new System.Windows.Forms.DateTimePicker();
            this.sortCombo = new System.Windows.Forms.ComboBox();
            this.weekTable = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.weekChart)).BeginInit();
            this.SuspendLayout();
            // 
            // weekChart
            // 
            chartArea2.Name = "ChartArea1";
            this.weekChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.weekChart.Legends.Add(legend2);
            this.weekChart.Location = new System.Drawing.Point(21, 22);
            this.weekChart.Name = "weekChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.weekChart.Series.Add(series2);
            this.weekChart.Size = new System.Drawing.Size(300, 300);
            this.weekChart.TabIndex = 0;
            this.weekChart.Text = "chart1";
            // 
            // weekDate
            // 
            this.weekDate.Location = new System.Drawing.Point(520, 22);
            this.weekDate.Name = "weekDate";
            this.weekDate.Size = new System.Drawing.Size(200, 20);
            this.weekDate.TabIndex = 1;
            // 
            // sortCombo
            // 
            this.sortCombo.FormattingEnabled = true;
            this.sortCombo.Location = new System.Drawing.Point(520, 48);
            this.sortCombo.Name = "sortCombo";
            this.sortCombo.Size = new System.Drawing.Size(200, 21);
            this.sortCombo.TabIndex = 2;
            // 
            // weekTable
            // 
            this.weekTable.ColumnCount = 2;
            this.weekTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.weekTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.weekTable.Location = new System.Drawing.Point(418, 129);
            this.weekTable.Name = "weekTable";
            this.weekTable.RowCount = 2;
            this.weekTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.weekTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.weekTable.Size = new System.Drawing.Size(200, 100);
            this.weekTable.TabIndex = 3;
            // 
            // WeeklyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 475);
            this.Controls.Add(this.weekTable);
            this.Controls.Add(this.sortCombo);
            this.Controls.Add(this.weekDate);
            this.Controls.Add(this.weekChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeeklyReport";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.weekChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart weekChart;
        private System.Windows.Forms.DateTimePicker weekDate;
        private System.Windows.Forms.ComboBox sortCombo;
        private System.Windows.Forms.TableLayoutPanel weekTable;
    }
}