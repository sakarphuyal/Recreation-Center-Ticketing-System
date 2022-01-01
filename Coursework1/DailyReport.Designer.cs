namespace Coursework1
{
    partial class DailyReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dailyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dailyTable = new System.Windows.Forms.TableLayoutPanel();
            this.chartDay = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupRadio = new System.Windows.Forms.RadioButton();
            this.ageRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dailyChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dailyChart
            // 
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.Name = "ChartArea1";
            this.dailyChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.dailyChart.Legends.Add(legend3);
            this.dailyChart.Location = new System.Drawing.Point(12, 96);
            this.dailyChart.Name = "dailyChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Data";
            this.dailyChart.Series.Add(series3);
            this.dailyChart.Size = new System.Drawing.Size(300, 300);
            this.dailyChart.TabIndex = 0;
            this.dailyChart.Text = "chart1";
            // 
            // dailyTable
            // 
            this.dailyTable.AutoSize = true;
            this.dailyTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.dailyTable.ColumnCount = 2;
            this.dailyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dailyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dailyTable.Location = new System.Drawing.Point(361, 252);
            this.dailyTable.Name = "dailyTable";
            this.dailyTable.RowCount = 2;
            this.dailyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dailyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dailyTable.Size = new System.Drawing.Size(200, 100);
            this.dailyTable.TabIndex = 1;
            // 
            // chartDay
            // 
            this.chartDay.Location = new System.Drawing.Point(527, 25);
            this.chartDay.Name = "chartDay";
            this.chartDay.Size = new System.Drawing.Size(200, 20);
            this.chartDay.TabIndex = 2;
            this.chartDay.ValueChanged += new System.EventHandler(this.datevalueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupRadio);
            this.groupBox1.Controls.Add(this.ageRadio);
            this.groupBox1.Location = new System.Drawing.Point(553, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 45);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // groupRadio
            // 
            this.groupRadio.AutoSize = true;
            this.groupRadio.Location = new System.Drawing.Point(101, 19);
            this.groupRadio.Name = "groupRadio";
            this.groupRadio.Size = new System.Drawing.Size(54, 17);
            this.groupRadio.TabIndex = 1;
            this.groupRadio.TabStop = true;
            this.groupRadio.Text = "Group";
            this.groupRadio.UseVisualStyleBackColor = true;
            // 
            // ageRadio
            // 
            this.ageRadio.AutoSize = true;
            this.ageRadio.Location = new System.Drawing.Point(32, 19);
            this.ageRadio.Name = "ageRadio";
            this.ageRadio.Size = new System.Drawing.Size(44, 17);
            this.ageRadio.TabIndex = 0;
            this.ageRadio.TabStop = true;
            this.ageRadio.Text = "Age";
            this.ageRadio.UseVisualStyleBackColor = true;
            this.ageRadio.CheckedChanged += new System.EventHandler(this.radioCheckChanged);
            // 
            // DailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartDay);
            this.Controls.Add(this.dailyTable);
            this.Controls.Add(this.dailyChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DailyReport";
            ((System.ComponentModel.ISupportInitialize)(this.dailyChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart dailyChart;
        private System.Windows.Forms.TableLayoutPanel dailyTable;
        private System.Windows.Forms.DateTimePicker chartDay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton groupRadio;
        private System.Windows.Forms.RadioButton ageRadio;
    }
}