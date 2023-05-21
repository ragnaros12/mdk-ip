namespace Ipoteka
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Vznos = new System.Windows.Forms.TextBox();
            this.Srok = new System.Windows.Forms.TextBox();
            this.GodProc = new System.Windows.Forms.TextBox();
            this.Cena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Pereplata_1 = new System.Windows.Forms.TextBox();
            this.Itog_1 = new System.Windows.Forms.TextBox();
            this.SummaBanku_1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Pereplata_2 = new System.Windows.Forms.TextBox();
            this.Itog_2 = new System.Windows.Forms.TextBox();
            this.SummaBanku_2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SummaIpoteki = new System.Windows.Forms.TextBox();
            this.RaschetVznosa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Raschet = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Raznica = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Vznos);
            this.groupBox1.Controls.Add(this.Srok);
            this.groupBox1.Controls.Add(this.GodProc);
            this.groupBox1.Controls.Add(this.Cena);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные данные";
            // 
            // Vznos
            // 
            this.Vznos.Location = new System.Drawing.Point(201, 99);
            this.Vznos.Name = "Vznos";
            this.Vznos.Size = new System.Drawing.Size(133, 20);
            this.Vznos.TabIndex = 7;
            this.Vznos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Vznos_KeyPress);
            // 
            // Srok
            // 
            this.Srok.Location = new System.Drawing.Point(201, 73);
            this.Srok.Name = "Srok";
            this.Srok.Size = new System.Drawing.Size(133, 20);
            this.Srok.TabIndex = 6;
            this.Srok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Srok_KeyPress);
            // 
            // GodProc
            // 
            this.GodProc.Location = new System.Drawing.Point(201, 49);
            this.GodProc.Name = "GodProc";
            this.GodProc.Size = new System.Drawing.Size(133, 20);
            this.GodProc.TabIndex = 5;
            this.GodProc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GodProc_KeyPress);
            // 
            // Cena
            // 
            this.Cena.Location = new System.Drawing.Point(201, 23);
            this.Cena.Name = "Cena";
            this.Cena.Size = new System.Drawing.Size(133, 20);
            this.Cena.TabIndex = 4;
            this.Cena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cena_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Первоначальный взнос (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Срок кредитования (месяцев)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Годовая процентная ставка (%)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите цену недвижимости(руб)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Pereplata_1);
            this.groupBox2.Controls.Add(this.Itog_1);
            this.groupBox2.Controls.Add(this.SummaBanku_1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(402, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Аннуиетная схема";
            // 
            // Pereplata_1
            // 
            this.Pereplata_1.Location = new System.Drawing.Point(191, 76);
            this.Pereplata_1.Name = "Pereplata_1";
            this.Pereplata_1.ReadOnly = true;
            this.Pereplata_1.Size = new System.Drawing.Size(189, 20);
            this.Pereplata_1.TabIndex = 5;
            // 
            // Itog_1
            // 
            this.Itog_1.Location = new System.Drawing.Point(191, 53);
            this.Itog_1.Name = "Itog_1";
            this.Itog_1.ReadOnly = true;
            this.Itog_1.Size = new System.Drawing.Size(189, 20);
            this.Itog_1.TabIndex = 4;
            // 
            // SummaBanku_1
            // 
            this.SummaBanku_1.Location = new System.Drawing.Point(191, 27);
            this.SummaBanku_1.Name = "SummaBanku_1";
            this.SummaBanku_1.ReadOnly = true;
            this.SummaBanku_1.Size = new System.Drawing.Size(189, 20);
            this.SummaBanku_1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Переплаты";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Итогавая стоимость жилья";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Суммарные выплаты банку";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Pereplata_2);
            this.groupBox3.Controls.Add(this.Itog_2);
            this.groupBox3.Controls.Add(this.SummaBanku_2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(402, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 187);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дифференцированная схема";
            // 
            // Pereplata_2
            // 
            this.Pereplata_2.Location = new System.Drawing.Point(191, 89);
            this.Pereplata_2.Name = "Pereplata_2";
            this.Pereplata_2.ReadOnly = true;
            this.Pereplata_2.Size = new System.Drawing.Size(188, 20);
            this.Pereplata_2.TabIndex = 5;
            // 
            // Itog_2
            // 
            this.Itog_2.Location = new System.Drawing.Point(191, 58);
            this.Itog_2.Name = "Itog_2";
            this.Itog_2.ReadOnly = true;
            this.Itog_2.Size = new System.Drawing.Size(188, 20);
            this.Itog_2.TabIndex = 4;
            // 
            // SummaBanku_2
            // 
            this.SummaBanku_2.Location = new System.Drawing.Point(191, 26);
            this.SummaBanku_2.Name = "SummaBanku_2";
            this.SummaBanku_2.ReadOnly = true;
            this.SummaBanku_2.Size = new System.Drawing.Size(188, 20);
            this.SummaBanku_2.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Переплаты";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Итоговая стоимость жилья";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Суммарные выпдаты банку";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SummaIpoteki);
            this.groupBox4.Controls.Add(this.RaschetVznosa);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 129);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Промежуочные расчёты";
            // 
            // SummaIpoteki
            // 
            this.SummaIpoteki.Location = new System.Drawing.Point(171, 56);
            this.SummaIpoteki.Name = "SummaIpoteki";
            this.SummaIpoteki.ReadOnly = true;
            this.SummaIpoteki.Size = new System.Drawing.Size(154, 20);
            this.SummaIpoteki.TabIndex = 3;
            // 
            // RaschetVznosa
            // 
            this.RaschetVznosa.Location = new System.Drawing.Point(171, 24);
            this.RaschetVznosa.Name = "RaschetVznosa";
            this.RaschetVznosa.ReadOnly = true;
            this.RaschetVznosa.Size = new System.Drawing.Size(154, 20);
            this.RaschetVznosa.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Сумма ипотеки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Первоначальный взнос";
            // 
            // Raschet
            // 
            this.Raschet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Raschet.Location = new System.Drawing.Point(583, 388);
            this.Raschet.Name = "Raschet";
            this.Raschet.Size = new System.Drawing.Size(205, 50);
            this.Raschet.TabIndex = 4;
            this.Raschet.Text = "Расчитать";
            this.Raschet.UseVisualStyleBackColor = false;
            this.Raschet.Click += new System.EventHandler(this.Raschet_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 388);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Дата начала платежей: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 407);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Дата окончания платежей: ";
            // 
            // Raznica
            // 
            this.Raznica.AutoSize = true;
            this.Raznica.Location = new System.Drawing.Point(9, 428);
            this.Raznica.Name = "Raznica";
            this.Raznica.Size = new System.Drawing.Size(10, 13);
            this.Raznica.TabIndex = 7;
            this.Raznica.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Raznica);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Raschet);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Ипотека";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Raschet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Vznos;
        private System.Windows.Forms.TextBox Srok;
        private System.Windows.Forms.TextBox GodProc;
        private System.Windows.Forms.TextBox Cena;
        private System.Windows.Forms.TextBox Pereplata_1;
        private System.Windows.Forms.TextBox Itog_1;
        private System.Windows.Forms.TextBox SummaBanku_1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Pereplata_2;
        private System.Windows.Forms.TextBox Itog_2;
        private System.Windows.Forms.TextBox SummaBanku_2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SummaIpoteki;
        private System.Windows.Forms.TextBox RaschetVznosa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Raznica;
    }
}

