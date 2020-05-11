namespace lab2_mobile
{
    partial class NetFlow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetFlow));
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartData
            // 
            chartArea1.Name = "ChartArea1";
            this.chartData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartData.Legends.Add(legend1);
            this.chartData.Location = new System.Drawing.Point(312, 178);
            this.chartData.Name = "chartData";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Bytes";
            this.chartData.Series.Add(series1);
            this.chartData.Size = new System.Drawing.Size(616, 300);
            this.chartData.TabIndex = 1;
            this.chartData.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(390, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(426, 131);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Лабораторная работа №2\r\n«Обработка и тарификация трафика NetFlow»\r\nФам Хю Хоанг N" +
    "3351\r\nВариант 4";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "1.График";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(83, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "2.Тарификация ";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(367, 498);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(476, 62);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Абонента с IP-адресом 192.168.250.59\r\n0,5руб/Мб до достижения 500Мб, далее 1руб/М" +
    "б";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxMoney);
            this.panel1.Controls.Add(this.textBoxSum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(367, 583);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 105);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Объем трафика (Мб):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(124, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Итого:";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(233, 17);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(116, 20);
            this.textBoxSum.TabIndex = 9;
            this.textBoxSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(233, 63);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(116, 20);
            this.textBoxMoney.TabIndex = 10;
            this.textBoxMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NetFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1241, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chartData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NetFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetFlow";
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

