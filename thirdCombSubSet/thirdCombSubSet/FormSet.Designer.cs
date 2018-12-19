namespace thirdCombSubSet
{
    partial class FormSet
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
            this.nudElem = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSet = new System.Windows.Forms.ListBox();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.tbExact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGen = new System.Windows.Forms.TextBox();
            this.tbTimeEx = new System.Windows.Forms.TextBox();
            this.tbTimeGen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.nudSteps = new System.Windows.Forms.NumericUpDown();
            this.nudMutation = new System.Windows.Forms.NumericUpDown();
            this.nudChrom = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nudMutCnt = new System.Windows.Forms.NumericUpDown();
            this.nudParentChrom = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGenSolve = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.nudItems = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudElem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParentChrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItems)).BeginInit();
            this.SuspendLayout();
            // 
            // nudElem
            // 
            this.nudElem.Location = new System.Drawing.Point(101, 48);
            this.nudElem.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudElem.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudElem.Name = "nudElem";
            this.nudElem.Size = new System.Drawing.Size(91, 20);
            this.nudElem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Элемент:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(218, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Множество:";
            // 
            // lbSet
            // 
            this.lbSet.FormattingEnabled = true;
            this.lbSet.Items.AddRange(new object[] {
            "1",
            "2",
            "-1",
            "4"});
            this.lbSet.Location = new System.Drawing.Point(44, 135);
            this.lbSet.Name = "lbSet";
            this.lbSet.Size = new System.Drawing.Size(148, 264);
            this.lbSet.TabIndex = 4;
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(873, 173);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(98, 53);
            this.btnDo.TabIndex = 5;
            this.btnDo.Text = "Решить точным алгоритмом";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(218, 357);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 42);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Выйти";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(218, 244);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(102, 37);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tbExact
            // 
            this.tbExact.Location = new System.Drawing.Point(579, 130);
            this.tbExact.Multiline = true;
            this.tbExact.Name = "tbExact";
            this.tbExact.ReadOnly = true;
            this.tbExact.Size = new System.Drawing.Size(259, 96);
            this.tbExact.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Решение точного алгоритма:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Решение генетического алгоритма:";
            // 
            // tbGen
            // 
            this.tbGen.Location = new System.Drawing.Point(579, 291);
            this.tbGen.Multiline = true;
            this.tbGen.Name = "tbGen";
            this.tbGen.ReadOnly = true;
            this.tbGen.Size = new System.Drawing.Size(259, 90);
            this.tbGen.TabIndex = 11;
            // 
            // tbTimeEx
            // 
            this.tbTimeEx.Location = new System.Drawing.Point(873, 127);
            this.tbTimeEx.Name = "tbTimeEx";
            this.tbTimeEx.ReadOnly = true;
            this.tbTimeEx.Size = new System.Drawing.Size(100, 20);
            this.tbTimeEx.TabIndex = 12;
            // 
            // tbTimeGen
            // 
            this.tbTimeGen.Location = new System.Drawing.Point(871, 288);
            this.tbTimeGen.Name = "tbTimeGen";
            this.tbTimeGen.ReadOnly = true;
            this.tbTimeGen.Size = new System.Drawing.Size(100, 20);
            this.tbTimeGen.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(870, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Время в секундах:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(218, 301);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 36);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // nudSteps
            // 
            this.nudSteps.Location = new System.Drawing.Point(340, 148);
            this.nudSteps.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudSteps.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSteps.Name = "nudSteps";
            this.nudSteps.Size = new System.Drawing.Size(117, 20);
            this.nudSteps.TabIndex = 16;
            this.nudSteps.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudMutation
            // 
            this.nudMutation.Location = new System.Drawing.Point(341, 206);
            this.nudMutation.Name = "nudMutation";
            this.nudMutation.Size = new System.Drawing.Size(120, 20);
            this.nudMutation.TabIndex = 17;
            this.nudMutation.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudChrom
            // 
            this.nudChrom.Location = new System.Drawing.Point(337, 311);
            this.nudChrom.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudChrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudChrom.Name = "nudChrom";
            this.nudChrom.Size = new System.Drawing.Size(120, 20);
            this.nudChrom.TabIndex = 18;
            this.nudChrom.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Максимальное количество шагов ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Вероятность мутации:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Количество отобранных хромосом";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(337, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "генетического алгоритма:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(337, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "в каждом поколении:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(341, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Количество мутирующих хромосом:";
            // 
            // nudMutCnt
            // 
            this.nudMutCnt.Location = new System.Drawing.Point(341, 262);
            this.nudMutCnt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMutCnt.Name = "nudMutCnt";
            this.nudMutCnt.Size = new System.Drawing.Size(120, 20);
            this.nudMutCnt.TabIndex = 25;
            this.nudMutCnt.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudParentChrom
            // 
            this.nudParentChrom.Location = new System.Drawing.Point(337, 379);
            this.nudParentChrom.Name = "nudParentChrom";
            this.nudParentChrom.Size = new System.Drawing.Size(120, 20);
            this.nudParentChrom.TabIndex = 26;
            this.nudParentChrom.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(337, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Количество хромосом:";
            // 
            // btnGenSolve
            // 
            this.btnGenSolve.Location = new System.Drawing.Point(871, 314);
            this.btnGenSolve.Name = "btnGenSolve";
            this.btnGenSolve.Size = new System.Drawing.Size(98, 67);
            this.btnGenSolve.TabIndex = 28;
            this.btnGenSolve.Text = "Решить генетическим алгоритмом";
            this.btnGenSolve.UseVisualStyleBackColor = true;
            this.btnGenSolve.Click += new System.EventHandler(this.btnGenSolve_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(868, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Время в секундах:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(215, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Элементы";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(218, 173);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(102, 46);
            this.btnGenerate.TabIndex = 31;
            this.btnGenerate.Text = "Сгенерировать";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // nudItems
            // 
            this.nudItems.Location = new System.Drawing.Point(218, 135);
            this.nudItems.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudItems.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudItems.Name = "nudItems";
            this.nudItems.Size = new System.Drawing.Size(102, 20);
            this.nudItems.TabIndex = 32;
            this.nudItems.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // FormSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 434);
            this.Controls.Add(this.nudItems);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnGenSolve);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nudParentChrom);
            this.Controls.Add(this.nudMutCnt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudChrom);
            this.Controls.Add(this.nudMutation);
            this.Controls.Add(this.nudSteps);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTimeGen);
            this.Controls.Add(this.tbTimeEx);
            this.Controls.Add(this.tbGen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbExact);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.lbSet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudElem);
            this.Name = "FormSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задача о сумме элементов подмножества";
            ((System.ComponentModel.ISupportInitialize)(this.nudElem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParentChrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudElem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbSet;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox tbExact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGen;
        private System.Windows.Forms.TextBox tbTimeEx;
        private System.Windows.Forms.TextBox tbTimeGen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown nudSteps;
        private System.Windows.Forms.NumericUpDown nudMutation;
        private System.Windows.Forms.NumericUpDown nudChrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudMutCnt;
        private System.Windows.Forms.NumericUpDown nudParentChrom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGenSolve;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.NumericUpDown nudItems;
    }
}

