namespace lab1_PhamHuyHoang
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Pay = new System.Windows.Forms.Button();
            this.buttonPrice = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(97, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 134);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(254, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Вариант 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(213, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Фам Хю Хоанг N3351";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(82, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(570, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Обработка и тарификация CDR (Call Detail Record)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(192, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Лабораторная работа №1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_Pay);
            this.panel2.Controls.Add(this.buttonPrice);
            this.panel2.Location = new System.Drawing.Point(164, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 55);
            this.panel2.TabIndex = 1;
            // 
            // button_Pay
            // 
            this.button_Pay.Location = new System.Drawing.Point(293, 14);
            this.button_Pay.Name = "button_Pay";
            this.button_Pay.Size = new System.Drawing.Size(97, 23);
            this.button_Pay.TabIndex = 3;
            this.button_Pay.Text = "Тарификация";
            this.button_Pay.UseVisualStyleBackColor = true;
            this.button_Pay.Click += new System.EventHandler(this.button_Pay_Click);
            // 
            // buttonPrice
            // 
            this.buttonPrice.Location = new System.Drawing.Point(115, 14);
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Size = new System.Drawing.Size(75, 23);
            this.buttonPrice.TabIndex = 2;
            this.buttonPrice.Text = "Тариф";
            this.buttonPrice.UseVisualStyleBackColor = true;
            this.buttonPrice.Click += new System.EventHandler(this.buttonPrice_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(899, 424);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лаб1_Фам_Хю_Хоанг_N3351";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Pay;
        private System.Windows.Forms.Button buttonPrice;
    }
}

