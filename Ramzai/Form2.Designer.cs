namespace Ramzai
{
    partial class Form2
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.cipherButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.gammaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pointerPart1 = new System.Windows.Forms.NumericUpDown();
            this.pointerPart2 = new System.Windows.Forms.NumericUpDown();
            this.pointerPart3 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pointerPart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointerPart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointerPart3)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.inputTextBox.Location = new System.Drawing.Point(19, 34);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(410, 620);
            this.inputTextBox.TabIndex = 0;
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.Color.White;
            this.outputTextBox.Location = new System.Drawing.Point(586, 34);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(410, 620);
            this.outputTextBox.TabIndex = 1;
            // 
            // cipherButton
            // 
            this.cipherButton.Location = new System.Drawing.Point(435, 60);
            this.cipherButton.Name = "cipherButton";
            this.cipherButton.Size = new System.Drawing.Size(145, 25);
            this.cipherButton.TabIndex = 2;
            this.cipherButton.Text = "Зашифровать";
            this.cipherButton.UseVisualStyleBackColor = true;
            this.cipherButton.Click += new System.EventHandler(this.cipherButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(435, 91);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(145, 22);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // gammaTextBox
            // 
            this.gammaTextBox.Location = new System.Drawing.Point(435, 34);
            this.gammaTextBox.Name = "gammaTextBox";
            this.gammaTextBox.Size = new System.Drawing.Size(145, 20);
            this.gammaTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Гамма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Шифруемое сообщение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Шифр";
            // 
            // pointerPart1
            // 
            this.pointerPart1.Location = new System.Drawing.Point(516, 582);
            this.pointerPart1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.pointerPart1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pointerPart1.Name = "pointerPart1";
            this.pointerPart1.Size = new System.Drawing.Size(64, 20);
            this.pointerPart1.TabIndex = 8;
            this.pointerPart1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pointerPart2
            // 
            this.pointerPart2.Location = new System.Drawing.Point(516, 608);
            this.pointerPart2.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.pointerPart2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pointerPart2.Name = "pointerPart2";
            this.pointerPart2.Size = new System.Drawing.Size(64, 20);
            this.pointerPart2.TabIndex = 9;
            this.pointerPart2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pointerPart3
            // 
            this.pointerPart3.Location = new System.Drawing.Point(516, 634);
            this.pointerPart3.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.pointerPart3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pointerPart3.Name = "pointerPart3";
            this.pointerPart3.Size = new System.Drawing.Size(64, 20);
            this.pointerPart3.TabIndex = 10;
            this.pointerPart3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 584);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Страница";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 610);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Сторка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 636);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Столбец";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 566);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Указатель начала гаммы";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pointerPart3);
            this.Controls.Add(this.pointerPart2);
            this.Controls.Add(this.pointerPart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gammaTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.cipherButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form2";
            this.Text = "Зорге";
            ((System.ComponentModel.ISupportInitialize)(this.pointerPart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointerPart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointerPart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button cipherButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox gammaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown pointerPart1;
        private System.Windows.Forms.NumericUpDown pointerPart2;
        private System.Windows.Forms.NumericUpDown pointerPart3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

