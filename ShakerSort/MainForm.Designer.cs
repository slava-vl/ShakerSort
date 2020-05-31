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
            this.panelMas = new System.Windows.Forms.Panel();
            this.buttonCount = new System.Windows.Forms.Button();
            this.buttonSortAllMass = new System.Windows.Forms.Button();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.chartTimeFromCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelChart = new System.Windows.Forms.Label();
            this.labelRandom = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonSortParts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartTimeFromCount)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(13, 12);
            this.textBoxCount.Multiline = true;
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(64, 51);
            this.textBoxCount.TabIndex = 0;
            this.textBoxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPress);
            // 
            // panelMas
            // 
            this.panelMas.AutoScroll = true;
            this.panelMas.Location = new System.Drawing.Point(13, 118);
            this.panelMas.Name = "panelMas";
            this.panelMas.Size = new System.Drawing.Size(843, 90);
            this.panelMas.TabIndex = 1;
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(83, 12);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(72, 51);
            this.buttonCount.TabIndex = 2;
            this.buttonCount.Text = "OK";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // buttonSortAllMass
            // 
            this.buttonSortAllMass.Location = new System.Drawing.Point(13, 245);
            this.buttonSortAllMass.Name = "buttonSortAllMass";
            this.buttonSortAllMass.Size = new System.Drawing.Size(349, 53);
            this.buttonSortAllMass.TabIndex = 3;
            this.buttonSortAllMass.Text = "Сортировать весь массив";
            this.buttonSortAllMass.UseVisualStyleBackColor = true;
            this.buttonSortAllMass.Click += new System.EventHandler(this.buttonSortAll_Click);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTime.Location = new System.Drawing.Point(13, 425);
            this.textBoxTime.Multiline = true;
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTime.Size = new System.Drawing.Size(349, 107);
            this.textBoxTime.TabIndex = 4;
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(12, 71);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(143, 41);
            this.buttonRandom.TabIndex = 5;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // chartTimeFromCount
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTimeFromCount.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTimeFromCount.Legends.Add(legend1);
            this.chartTimeFromCount.Location = new System.Drawing.Point(368, 273);
            this.chartTimeFromCount.Name = "chartTimeFromCount";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Время";
            this.chartTimeFromCount.Series.Add(series1);
            this.chartTimeFromCount.Size = new System.Drawing.Size(488, 210);
            this.chartTimeFromCount.TabIndex = 6;
            this.chartTimeFromCount.Text = "chart1";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(10, 392);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(259, 18);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "Время выполнения сортировки:";
            // 
            // labelChart
            // 
            this.labelChart.AutoSize = true;
            this.labelChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChart.Location = new System.Drawing.Point(365, 245);
            this.labelChart.Name = "labelChart";
            this.labelChart.Size = new System.Drawing.Size(397, 18);
            this.labelChart.TabIndex = 8;
            this.labelChart.Text = "Зависимость времени от количества элементов:";
            // 
            // labelRandom
            // 
            this.labelRandom.AutoSize = true;
            this.labelRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRandom.Location = new System.Drawing.Point(170, 81);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(514, 18);
            this.labelRandom.TabIndex = 9;
            this.labelRandom.Text = "Заполните массив значениями или нажмите на автозаполнение";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(170, 27);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(345, 18);
            this.labelCount.TabIndex = 10;
            this.labelCount.Text = "Введите количество элементов в массиве";
            // 
            // buttonSortParts
            // 
            this.buttonSortParts.Location = new System.Drawing.Point(12, 315);
            this.buttonSortParts.Name = "buttonSortParts";
            this.buttonSortParts.Size = new System.Drawing.Size(350, 53);
            this.buttonSortParts.TabIndex = 11;
            this.buttonSortParts.Text = "Сортировать, деля по частям";
            this.buttonSortParts.UseVisualStyleBackColor = true;
            this.buttonSortParts.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 557);
            this.Controls.Add(this.buttonSortParts);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelRandom);
            this.Controls.Add(this.labelChart);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.chartTimeFromCount);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.buttonSortAllMass);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.panelMas);
            this.Controls.Add(this.textBoxCount);
            this.Name = "MainForm";
            this.Text = "Shaker-Sort";
            ((System.ComponentModel.ISupportInitialize)(this.chartTimeFromCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Panel panelMas;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Button buttonSortAllMass;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTimeFromCount;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelChart;
        private System.Windows.Forms.Label labelRandom;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonSortParts;
    }
}

