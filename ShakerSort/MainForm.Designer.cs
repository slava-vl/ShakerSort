namespace ShakerSort
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonCount = new System.Windows.Forms.Button();
            this.chartTimeFromCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelChart = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTimeFromCount)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(224, 80);
            this.textBoxCount.Multiline = true;
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(237, 51);
            this.textBoxCount.TabIndex = 0;
            this.textBoxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPress);
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(494, 80);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(72, 51);
            this.buttonCount.TabIndex = 2;
            this.buttonCount.Text = "OK";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // chartTimeFromCount
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTimeFromCount.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTimeFromCount.Legends.Add(legend1);
            this.chartTimeFromCount.Location = new System.Drawing.Point(29, 273);
            this.chartTimeFromCount.Name = "chartTimeFromCount";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Время";
            this.chartTimeFromCount.Series.Add(series1);
            this.chartTimeFromCount.Size = new System.Drawing.Size(732, 210);
            this.chartTimeFromCount.TabIndex = 6;
            this.chartTimeFromCount.Text = "chart1";
            // 
            // labelChart
            // 
            this.labelChart.AutoSize = true;
            this.labelChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChart.Location = new System.Drawing.Point(203, 252);
            this.labelChart.Name = "labelChart";
            this.labelChart.Size = new System.Drawing.Size(397, 18);
            this.labelChart.TabIndex = 8;
            this.labelChart.Text = "Зависимость времени от количества элементов:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(62, 37);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(617, 18);
            this.labelCount.TabIndex = 10;
            this.labelCount.Text = "Введите n, где n - число, до которого замеряется время работы сортировки";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 557);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelChart);
            this.Controls.Add(this.chartTimeFromCount);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.textBoxCount);
            this.Name = "MainForm";
            this.Text = "Shaker-Sort";
            ((System.ComponentModel.ISupportInitialize)(this.chartTimeFromCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTimeFromCount;
        private System.Windows.Forms.Label labelChart;
        private System.Windows.Forms.Label labelCount;
    }
}

