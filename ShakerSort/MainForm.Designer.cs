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
            this.buttonRandom = new System.Windows.Forms.Button();
            this.chartTeoreticTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelChart = new System.Windows.Forms.Label();
            this.textBoxNums = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.textBoxAfterSort = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.импортИзФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartTeoreticTime)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(194, 27);
            this.textBoxCount.Multiline = true;
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(234, 51);
            this.textBoxCount.TabIndex = 0;
            this.textBoxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPress);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(98, 27);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(72, 51);
            this.buttonRandom.TabIndex = 2;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // chartTeoreticTime
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTeoreticTime.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTeoreticTime.Legends.Add(legend1);
            this.chartTeoreticTime.Location = new System.Drawing.Point(1023, 80);
            this.chartTeoreticTime.Name = "chartTeoreticTime";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Время";
            this.chartTeoreticTime.Series.Add(series1);
            this.chartTeoreticTime.Size = new System.Drawing.Size(438, 210);
            this.chartTeoreticTime.TabIndex = 6;
            this.chartTeoreticTime.Text = "chart1";
            // 
            // labelChart
            // 
            this.labelChart.AutoSize = true;
            this.labelChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChart.Location = new System.Drawing.Point(1020, 47);
            this.labelChart.Name = "labelChart";
            this.labelChart.Size = new System.Drawing.Size(397, 18);
            this.labelChart.TabIndex = 8;
            this.labelChart.Text = "Зависимость времени от количества элементов:";
            // 
            // textBoxNums
            // 
            this.textBoxNums.Location = new System.Drawing.Point(23, 96);
            this.textBoxNums.Multiline = true;
            this.textBoxNums.Name = "textBoxNums";
            this.textBoxNums.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNums.Size = new System.Drawing.Size(914, 117);
            this.textBoxNums.TabIndex = 9;
            this.textBoxNums.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPress);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(194, 239);
            this.textBoxTime.Multiline = true;
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.Size = new System.Drawing.Size(234, 51);
            this.textBoxTime.TabIndex = 10;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(98, 239);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(72, 51);
            this.buttonSort.TabIndex = 11;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // textBoxAfterSort
            // 
            this.textBoxAfterSort.Location = new System.Drawing.Point(23, 309);
            this.textBoxAfterSort.Multiline = true;
            this.textBoxAfterSort.Name = "textBoxAfterSort";
            this.textBoxAfterSort.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAfterSort.Size = new System.Drawing.Size(914, 117);
            this.textBoxAfterSort.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.импортИзФайлаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1490, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // импортИзФайлаToolStripMenuItem
            // 
            this.импортИзФайлаToolStripMenuItem.Name = "импортИзФайлаToolStripMenuItem";
            this.импортИзФайлаToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.импортИзФайлаToolStripMenuItem.Text = "Импорт из файла";
            this.импортИзФайлаToolStripMenuItem.Click += new System.EventHandler(this.ImportFromFileToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(973, -26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 601);
            this.panel1.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxAfterSort);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxNums);
            this.Controls.Add(this.labelChart);
            this.Controls.Add(this.chartTeoreticTime);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Shaker-Sort";
            ((System.ComponentModel.ISupportInitialize)(this.chartTeoreticTime)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTeoreticTime;
        private System.Windows.Forms.Label labelChart;
        private System.Windows.Forms.TextBox textBoxNums;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.TextBox textBoxAfterSort;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem импортИзФайлаToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

