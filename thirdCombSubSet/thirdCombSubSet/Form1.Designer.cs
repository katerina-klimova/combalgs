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
            ((System.ComponentModel.ISupportInitialize)(this.nudElem)).BeginInit();
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
            this.lbSet.Location = new System.Drawing.Point(44, 130);
            this.lbSet.Name = "lbSet";
            this.lbSet.Size = new System.Drawing.Size(148, 251);
            this.lbSet.TabIndex = 4;
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(218, 130);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(91, 53);
            this.btnDo.TabIndex = 5;
            this.btnDo.Text = "Посчитать решение";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(218, 339);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 42);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Выйти";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(218, 189);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(91, 37);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tbExact
            // 
            this.tbExact.Location = new System.Drawing.Point(367, 130);
            this.tbExact.Multiline = true;
            this.tbExact.Name = "tbExact";
            this.tbExact.ReadOnly = true;
            this.tbExact.Size = new System.Drawing.Size(259, 96);
            this.tbExact.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Решение точного алгоритма:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Решение генетического алгоритма:";
            // 
            // tbGen
            // 
            this.tbGen.Location = new System.Drawing.Point(367, 291);
            this.tbGen.Multiline = true;
            this.tbGen.Name = "tbGen";
            this.tbGen.ReadOnly = true;
            this.tbGen.Size = new System.Drawing.Size(259, 90);
            this.tbGen.TabIndex = 11;
            // 
            // tbTimeEx
            // 
            this.tbTimeEx.Location = new System.Drawing.Point(661, 163);
            this.tbTimeEx.Name = "tbTimeEx";
            this.tbTimeEx.ReadOnly = true;
            this.tbTimeEx.Size = new System.Drawing.Size(100, 20);
            this.tbTimeEx.TabIndex = 12;
            // 
            // tbTimeGen
            // 
            this.tbTimeGen.Location = new System.Drawing.Point(661, 329);
            this.tbTimeGen.Name = "tbTimeGen";
            this.tbTimeGen.ReadOnly = true;
            this.tbTimeGen.Size = new System.Drawing.Size(100, 20);
            this.tbTimeGen.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(658, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Время в секундах:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(218, 232);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 36);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 434);
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
    }
}

