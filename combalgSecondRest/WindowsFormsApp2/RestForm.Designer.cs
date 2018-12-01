namespace WindowsFormsApp2
{
    partial class SecondRestForm
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
            this.btnDo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.num5 = new System.Windows.Forms.NumericUpDown();
            this.num10 = new System.Windows.Forms.NumericUpDown();
            this.num50 = new System.Windows.Forms.NumericUpDown();
            this.num100 = new System.Windows.Forms.NumericUpDown();
            this.num200 = new System.Windows.Forms.NumericUpDown();
            this.num500 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lbVarsCnt = new System.Windows.Forms.Label();
            this.numRub = new System.Windows.Forms.NumericUpDown();
            this.numCop = new System.Windows.Forms.NumericUpDown();
            this.panelCoins = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num200)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num500)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCop)).BeginInit();
            this.panelCoins.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(48, 172);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(100, 36);
            this.btnDo.TabIndex = 0;
            this.btnDo.Text = "Считать";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1 копейка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "5 копеек";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "10 копеек";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "50 копеек";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "1 рубль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "2 рубля";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "5 рублей";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Монет у продавца:";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(159, 48);
            this.num1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(153, 20);
            this.num1.TabIndex = 10;
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(159, 96);
            this.num5.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(153, 20);
            this.num5.TabIndex = 11;
            // 
            // num10
            // 
            this.num10.Location = new System.Drawing.Point(159, 140);
            this.num10.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num10.Name = "num10";
            this.num10.Size = new System.Drawing.Size(153, 20);
            this.num10.TabIndex = 12;
            // 
            // num50
            // 
            this.num50.Location = new System.Drawing.Point(159, 190);
            this.num50.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num50.Name = "num50";
            this.num50.Size = new System.Drawing.Size(153, 20);
            this.num50.TabIndex = 13;
            // 
            // num100
            // 
            this.num100.Location = new System.Drawing.Point(150, 64);
            this.num100.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num100.Name = "num100";
            this.num100.Size = new System.Drawing.Size(162, 20);
            this.num100.TabIndex = 14;
            this.num100.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // num200
            // 
            this.num200.Location = new System.Drawing.Point(150, 121);
            this.num200.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num200.Name = "num200";
            this.num200.Size = new System.Drawing.Size(162, 20);
            this.num200.TabIndex = 15;
            this.num200.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // num500
            // 
            this.num500.Location = new System.Drawing.Point(150, 177);
            this.num500.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num500.Name = "num500";
            this.num500.Size = new System.Drawing.Size(162, 20);
            this.num500.TabIndex = 16;
            this.num500.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Рублей";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(217, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Копеек:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(220, 172);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 36);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(141, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Сумма сдачи:";
            // 
            // lbVarsCnt
            // 
            this.lbVarsCnt.AutoSize = true;
            this.lbVarsCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVarsCnt.Location = new System.Drawing.Point(217, 29);
            this.lbVarsCnt.Name = "lbVarsCnt";
            this.lbVarsCnt.Size = new System.Drawing.Size(0, 20);
            this.lbVarsCnt.TabIndex = 26;
            // 
            // numRub
            // 
            this.numRub.Location = new System.Drawing.Point(48, 122);
            this.numRub.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRub.Name = "numRub";
            this.numRub.Size = new System.Drawing.Size(100, 20);
            this.numRub.TabIndex = 27;
            // 
            // numCop
            // 
            this.numCop.Location = new System.Drawing.Point(220, 122);
            this.numCop.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numCop.Name = "numCop";
            this.numCop.Size = new System.Drawing.Size(100, 20);
            this.numCop.TabIndex = 28;
            // 
            // panelCoins
            // 
            this.panelCoins.Controls.Add(this.label1);
            this.panelCoins.Controls.Add(this.label8);
            this.panelCoins.Controls.Add(this.num1);
            this.panelCoins.Controls.Add(this.label4);
            this.panelCoins.Controls.Add(this.label3);
            this.panelCoins.Controls.Add(this.label2);
            this.panelCoins.Controls.Add(this.num5);
            this.panelCoins.Controls.Add(this.num10);
            this.panelCoins.Controls.Add(this.num50);
            this.panelCoins.Location = new System.Drawing.Point(448, 65);
            this.panelCoins.Name = "panelCoins";
            this.panelCoins.Size = new System.Drawing.Size(366, 235);
            this.panelCoins.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.num100);
            this.panel1.Controls.Add(this.num200);
            this.panel1.Controls.Add(this.num500);
            this.panel1.Location = new System.Drawing.Point(36, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 235);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btnDo);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.numCop);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.numRub);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.lbVarsCnt);
            this.panel2.Location = new System.Drawing.Point(243, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 255);
            this.panel2.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Копеек:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Рублей:";
            // 
            // SecondRestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCoins);
            this.Controls.Add(this.label9);
            this.MaximizeBox = false;
            this.Name = "SecondRestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Second Rest";
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num200)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num500)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCop)).EndInit();
            this.panelCoins.ResumeLayout(false);
            this.panelCoins.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.NumericUpDown num5;
        private System.Windows.Forms.NumericUpDown num10;
        private System.Windows.Forms.NumericUpDown num50;
        private System.Windows.Forms.NumericUpDown num100;
        private System.Windows.Forms.NumericUpDown num200;
        private System.Windows.Forms.NumericUpDown num500;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbVarsCnt;
        private System.Windows.Forms.NumericUpDown numRub;
        private System.Windows.Forms.NumericUpDown numCop;
        private System.Windows.Forms.Panel panelCoins;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
    }
}

