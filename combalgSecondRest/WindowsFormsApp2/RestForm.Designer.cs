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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.num5 = new System.Windows.Forms.NumericUpDown();
            this.num10 = new System.Windows.Forms.NumericUpDown();
            this.num50 = new System.Windows.Forms.NumericUpDown();
            this.num100 = new System.Windows.Forms.NumericUpDown();
            this.num200 = new System.Windows.Forms.NumericUpDown();
            this.num500 = new System.Windows.Forms.NumericUpDown();
            this.num1000 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbRest = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lbRests = new System.Windows.Forms.ListBox();
            this.lbVarsCnt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num200)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num500)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1000)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(61, 645);
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
            this.label1.Location = new System.Drawing.Point(58, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1 копейка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "5 копеек";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "10 копеек";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "50 копеек";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "1 рубль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "2 рубля";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "5 рублей";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "10 рублей";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Монет у продавца:";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(210, 88);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(72, 20);
            this.num1.TabIndex = 10;
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(210, 141);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(72, 20);
            this.num5.TabIndex = 11;
            // 
            // num10
            // 
            this.num10.Location = new System.Drawing.Point(210, 192);
            this.num10.Name = "num10";
            this.num10.Size = new System.Drawing.Size(72, 20);
            this.num10.TabIndex = 12;
            // 
            // num50
            // 
            this.num50.Location = new System.Drawing.Point(210, 246);
            this.num50.Name = "num50";
            this.num50.Size = new System.Drawing.Size(72, 20);
            this.num50.TabIndex = 13;
            // 
            // num100
            // 
            this.num100.Location = new System.Drawing.Point(210, 303);
            this.num100.Name = "num100";
            this.num100.Size = new System.Drawing.Size(72, 20);
            this.num100.TabIndex = 14;
            this.num100.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // num200
            // 
            this.num200.Location = new System.Drawing.Point(210, 360);
            this.num200.Name = "num200";
            this.num200.Size = new System.Drawing.Size(72, 20);
            this.num200.TabIndex = 15;
            this.num200.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // num500
            // 
            this.num500.Location = new System.Drawing.Point(210, 416);
            this.num500.Name = "num500";
            this.num500.Size = new System.Drawing.Size(72, 20);
            this.num500.TabIndex = 16;
            this.num500.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // num1000
            // 
            this.num1000.Location = new System.Drawing.Point(210, 472);
            this.num1000.Name = "num1000";
            this.num1000.Size = new System.Drawing.Size(72, 20);
            this.num1000.TabIndex = 17;
            this.num1000.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 551);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Цена";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(230, 551);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Деньги покупателя";
            // 
            // lbRest
            // 
            this.lbRest.AutoSize = true;
            this.lbRest.Location = new System.Drawing.Point(405, 551);
            this.lbRest.Name = "lbRest";
            this.lbRest.Size = new System.Drawing.Size(0, 13);
            this.lbRest.TabIndex = 20;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(61, 588);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 21;
            this.txtPrice.Text = "20";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(233, 588);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(100, 20);
            this.txtMoney.TabIndex = 22;
            this.txtMoney.Text = "30";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(233, 645);
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
            this.label13.Location = new System.Drawing.Point(62, 715);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(336, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Подсказка: для ввода копеек используйте разделение запятой!";
            // 
            // lbRests
            // 
            this.lbRests.FormattingEnabled = true;
            this.lbRests.Location = new System.Drawing.Point(459, 85);
            this.lbRests.Name = "lbRests";
            this.lbRests.Size = new System.Drawing.Size(453, 407);
            this.lbRests.TabIndex = 25;
            // 
            // lbVarsCnt
            // 
            this.lbVarsCnt.AutoSize = true;
            this.lbVarsCnt.Location = new System.Drawing.Point(575, 551);
            this.lbVarsCnt.Name = "lbVarsCnt";
            this.lbVarsCnt.Size = new System.Drawing.Size(0, 13);
            this.lbVarsCnt.TabIndex = 26;
            // 
            // SecondRestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 751);
            this.Controls.Add(this.lbVarsCnt);
            this.Controls.Add(this.lbRests);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lbRest);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.num1000);
            this.Controls.Add(this.num500);
            this.Controls.Add(this.num200);
            this.Controls.Add(this.num100);
            this.Controls.Add(this.num50);
            this.Controls.Add(this.num10);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDo);
            this.Name = "SecondRestForm";
            this.Text = "Second Rest";
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num200)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num500)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1000)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.NumericUpDown num5;
        private System.Windows.Forms.NumericUpDown num10;
        private System.Windows.Forms.NumericUpDown num50;
        private System.Windows.Forms.NumericUpDown num100;
        private System.Windows.Forms.NumericUpDown num200;
        private System.Windows.Forms.NumericUpDown num500;
        private System.Windows.Forms.NumericUpDown num1000;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbRest;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lbRests;
        private System.Windows.Forms.Label lbVarsCnt;
    }
}

