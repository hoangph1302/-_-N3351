namespace lab3
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.kpiCustomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.innCustomer = new System.Windows.Forms.TextBox();
            this.nameCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bank = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.kppCompany = new System.Windows.Forms.TextBox();
            this.numberRepoter = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bikCompany = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numberCompany = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.innCompany = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nameCompany = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addService = new System.Windows.Forms.Button();
            this.nds = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.TextBox();
            this.nameService = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.print = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.numberBill = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kpiCustomer);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.innCustomer);
            this.panel1.Controls.Add(this.nameCustomer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 183);
            this.panel1.TabIndex = 0;
            // 
            // kpiCustomer
            // 
            this.kpiCustomer.Location = new System.Drawing.Point(269, 114);
            this.kpiCustomer.Name = "kpiCustomer";
            this.kpiCustomer.Size = new System.Drawing.Size(131, 20);
            this.kpiCustomer.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(43, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Название Контрагента:";
            // 
            // innCustomer
            // 
            this.innCustomer.Location = new System.Drawing.Point(269, 79);
            this.innCustomer.Name = "innCustomer";
            this.innCustomer.Size = new System.Drawing.Size(131, 20);
            this.innCustomer.TabIndex = 4;
            // 
            // nameCustomer
            // 
            this.nameCustomer.Location = new System.Drawing.Point(269, 45);
            this.nameCustomer.Name = "nameCustomer";
            this.nameCustomer.Size = new System.Drawing.Size(131, 20);
            this.nameCustomer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(43, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "КПП:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(43, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ИНН:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить покупателя";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bank);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.kppCompany);
            this.panel2.Controls.Add(this.numberRepoter);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.bikCompany);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.numberCompany);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.innCompany);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.nameCompany);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(1, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 348);
            this.panel2.TabIndex = 1;
            // 
            // bank
            // 
            this.bank.Location = new System.Drawing.Point(269, 211);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(131, 20);
            this.bank.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(33, 209);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 20);
            this.label16.TabIndex = 18;
            this.label16.Text = "Банк:";
            // 
            // kppCompany
            // 
            this.kppCompany.Location = new System.Drawing.Point(269, 282);
            this.kppCompany.Name = "kppCompany";
            this.kppCompany.Size = new System.Drawing.Size(131, 20);
            this.kppCompany.TabIndex = 17;
            // 
            // numberRepoter
            // 
            this.numberRepoter.Location = new System.Drawing.Point(269, 246);
            this.numberRepoter.Name = "numberRepoter";
            this.numberRepoter.Size = new System.Drawing.Size(131, 20);
            this.numberRepoter.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(34, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "КПП:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(31, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Конрреспондентский счет:";
            // 
            // bikCompany
            // 
            this.bikCompany.Location = new System.Drawing.Point(269, 177);
            this.bikCompany.Name = "bikCompany";
            this.bikCompany.Size = new System.Drawing.Size(131, 20);
            this.bikCompany.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(34, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "БИК:";
            // 
            // numberCompany
            // 
            this.numberCompany.Location = new System.Drawing.Point(269, 140);
            this.numberCompany.Name = "numberCompany";
            this.numberCompany.Size = new System.Drawing.Size(131, 20);
            this.numberCompany.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(31, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Расчетный счет:";
            // 
            // innCompany
            // 
            this.innCompany.Location = new System.Drawing.Point(269, 101);
            this.innCompany.Name = "innCompany";
            this.innCompany.Size = new System.Drawing.Size(131, 20);
            this.innCompany.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(31, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "ИНН:";
            // 
            // nameCompany
            // 
            this.nameCompany.Location = new System.Drawing.Point(269, 64);
            this.nameCompany.Name = "nameCompany";
            this.nameCompany.Size = new System.Drawing.Size(131, 20);
            this.nameCompany.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(33, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Название организации:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Данные по вашей копании";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addService);
            this.panel3.Controls.Add(this.nds);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.money);
            this.panel3.Controls.Add(this.nameService);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(476, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 183);
            this.panel3.TabIndex = 2;
            // 
            // addService
            // 
            this.addService.Location = new System.Drawing.Point(133, 148);
            this.addService.Name = "addService";
            this.addService.Size = new System.Drawing.Size(75, 23);
            this.addService.TabIndex = 7;
            this.addService.Text = "Добавить ";
            this.addService.UseVisualStyleBackColor = true;
            // 
            // nds
            // 
            this.nds.Location = new System.Drawing.Point(269, 112);
            this.nds.Name = "nds";
            this.nds.Size = new System.Drawing.Size(131, 20);
            this.nds.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(129, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Название :";
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(269, 79);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(131, 20);
            this.money.TabIndex = 4;
            // 
            // nameService
            // 
            this.nameService.Location = new System.Drawing.Point(269, 43);
            this.nameService.Name = "nameService";
            this.nameService.Size = new System.Drawing.Size(131, 20);
            this.nameService.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(133, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "НДС:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(129, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Сумма:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(3, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(178, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "Добавить услугу";
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.print.Location = new System.Drawing.Point(403, 565);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(142, 52);
            this.print.TabIndex = 8;
            this.print.Text = "Печать Чек";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.date);
            this.panel4.Controls.Add(this.numberBill);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Location = new System.Drawing.Point(468, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(419, 124);
            this.panel4.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(43, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "№:";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(269, 79);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(131, 20);
            this.date.TabIndex = 4;
            // 
            // numberBill
            // 
            this.numberBill.Location = new System.Drawing.Point(269, 45);
            this.numberBill.Name = "numberBill";
            this.numberBill.Size = new System.Drawing.Size(131, 20);
            this.numberBill.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(43, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 20);
            this.label19.TabIndex = 1;
            this.label19.Text = "От:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(3, 5);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(181, 25);
            this.label20.TabIndex = 0;
            this.label20.Text = "Исходящий счет ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 732);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.print);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox kpiCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox innCustomer;
        private System.Windows.Forms.TextBox nameCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox kppCompany;
        private System.Windows.Forms.TextBox numberRepoter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bikCompany;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox numberCompany;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox innCompany;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameCompany;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addService;
        private System.Windows.Forms.TextBox nds;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.TextBox nameService;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.TextBox bank;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox numberBill;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}

