namespace Enigma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cipherButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cipherTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.patch1 = new System.Windows.Forms.TextBox();
            this.patch2 = new System.Windows.Forms.TextBox();
            this.patch3 = new System.Windows.Forms.TextBox();
            this.patch4 = new System.Windows.Forms.TextBox();
            this.patch5 = new System.Windows.Forms.TextBox();
            this.patch6 = new System.Windows.Forms.TextBox();
            this.patch7 = new System.Windows.Forms.TextBox();
            this.patch8 = new System.Windows.Forms.TextBox();
            this.patch9 = new System.Windows.Forms.TextBox();
            this.patch10 = new System.Windows.Forms.TextBox();
            this.patch11 = new System.Windows.Forms.TextBox();
            this.patch12 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.reflectorBox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.key3 = new System.Windows.Forms.NumericUpDown();
            this.key2 = new System.Windows.Forms.NumericUpDown();
            this.key1 = new System.Windows.Forms.NumericUpDown();
            this.rotorSelection3 = new System.Windows.Forms.NumericUpDown();
            this.rotorSelection2 = new System.Windows.Forms.NumericUpDown();
            this.rotorSelection1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotorSelection3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotorSelection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotorSelection1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(404, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nachrichtentext";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextBox.BackColor = System.Drawing.Color.White;
            this.inputTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.inputTextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(7, 149);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(991, 140);
            this.inputTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Verschlüsselungsschlüssel:";
            // 
            // cipherButton
            // 
            this.cipherButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cipherButton.BackColor = System.Drawing.SystemColors.Window;
            this.cipherButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cipherButton.Location = new System.Drawing.Point(848, 314);
            this.cipherButton.Name = "cipherButton";
            this.cipherButton.Size = new System.Drawing.Size(148, 28);
            this.cipherButton.TabIndex = 5;
            this.cipherButton.Text = "Verschlüsseln";
            this.cipherButton.UseVisualStyleBackColor = false;
            this.cipherButton.Click += new System.EventHandler(this.cipherButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chiffre";
            // 
            // cipherTextBox
            // 
            this.cipherTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cipherTextBox.BackColor = System.Drawing.Color.White;
            this.cipherTextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cipherTextBox.Location = new System.Drawing.Point(7, 377);
            this.cipherTextBox.Multiline = true;
            this.cipherTextBox.Name = "cipherTextBox";
            this.cipherTextBox.ReadOnly = true;
            this.cipherTextBox.Size = new System.Drawing.Size(991, 140);
            this.cipherTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(465, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Patchfeld";
            // 
            // patch1
            // 
            this.patch1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.patch1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.patch1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patch1.Location = new System.Drawing.Point(28, 597);
            this.patch1.MaxLength = 1;
            this.patch1.Name = "patch1";
            this.patch1.Size = new System.Drawing.Size(32, 25);
            this.patch1.TabIndex = 9;
            // 
            // patch2
            // 
            this.patch2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.patch2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.patch2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patch2.Location = new System.Drawing.Point(66, 597);
            this.patch2.MaxLength = 1;
            this.patch2.Name = "patch2";
            this.patch2.Size = new System.Drawing.Size(32, 25);
            this.patch2.TabIndex = 10;
            // 
            // patch3
            // 
            this.patch3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.patch3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.patch3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patch3.Location = new System.Drawing.Point(194, 597);
            this.patch3.MaxLength = 1;
            this.patch3.Name = "patch3";
            this.patch3.Size = new System.Drawing.Size(32, 25);
            this.patch3.TabIndex = 11;
            // 
            // patch4
            // 
            this.patch4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.patch4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.patch4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patch4.Location = new System.Drawing.Point(232, 597);
            this.patch4.MaxLength = 1;
            this.patch4.Name = "patch4";
            this.patch4.Size = new System.Drawing.Size(32, 25);
            this.patch4.TabIndex = 12;
            // 
            // patch5
            // 
            this.patch5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.patch5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.patch5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patch5.Location = new System.Drawing.Point(366, 597);
            this.patch5.MaxLength = 1;
            this.patch5.Name = "patch5";
            this.patch5.Size = new System.Drawing.Size(32, 25);
            this.patch5.TabIndex = 13;
            // 
            // patch6
            // 
            this.patch6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.patch6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.patch6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patch6.Location = new System.Drawing.Point(404, 597);
            this.patch6.MaxLength = 1;
            this.patch6.Name = "patch6";
            this.patch6.Size = new System.Drawing.Size(32, 25);
            this.patch6.TabIndex = 14;
            // 
            // patch7
            // 
            this.patch7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.patch7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.patch7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patch7.Location = new System.Drawing.Point(549, 597);
            this.patch7.MaxLength = 1;
            this.patch7.Name = "patch7";
            this.patch7.Size = new System.Drawing.Size(32, 25);
            this.patch7.TabIndex = 15;
            // 
            // patch8
            // 
            this.patch8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.patch8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.patch8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patch8.Location = new System.Drawing.Point(587, 597);
            this.patch8.MaxLength = 1;
            this.patch8.Name = "patch8";
            this.patch8.Size = new System.Drawing.Size(32, 25);
            this.patch8.TabIndex = 16;
            // 
            // patch9
            // 
            this.patch9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.patch9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.patch9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patch9.Location = new System.Drawing.Point(743, 597);
            this.patch9.MaxLength = 1;
            this.patch9.Name = "patch9";
            this.patch9.Size = new System.Drawing.Size(32, 25);
            this.patch9.TabIndex = 17;
            // 
            // patch10
            // 
            this.patch10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.patch10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.patch10.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patch10.Location = new System.Drawing.Point(781, 597);
            this.patch10.MaxLength = 1;
            this.patch10.Name = "patch10";
            this.patch10.Size = new System.Drawing.Size(32, 25);
            this.patch10.TabIndex = 18;
            // 
            // patch11
            // 
            this.patch11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.patch11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.patch11.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patch11.Location = new System.Drawing.Point(926, 597);
            this.patch11.MaxLength = 1;
            this.patch11.Name = "patch11";
            this.patch11.Size = new System.Drawing.Size(32, 25);
            this.patch11.TabIndex = 19;
            // 
            // patch12
            // 
            this.patch12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.patch12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.patch12.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patch12.Location = new System.Drawing.Point(964, 597);
            this.patch12.MaxLength = 1;
            this.patch12.Name = "patch12";
            this.patch12.Size = new System.Drawing.Size(32, 25);
            this.patch12.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(465, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Rotoren";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(626, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Reflektor";
            // 
            // reflectorBox
            // 
            this.reflectorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reflectorBox.CheckOnClick = true;
            this.reflectorBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectorBox.FormattingEnabled = true;
            this.reflectorBox.Items.AddRange(new object[] {
            "B",
            "C",
            "B Dünn",
            "C Dünn"});
            this.reflectorBox.Location = new System.Drawing.Point(625, 39);
            this.reflectorBox.Name = "reflectorBox";
            this.reflectorBox.Size = new System.Drawing.Size(94, 104);
            this.reflectorBox.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(660, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "1";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(613, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "2";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(570, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "3";
            // 
            // key3
            // 
            this.key3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.key3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key3.Location = new System.Drawing.Point(266, 312);
            this.key3.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.key3.Name = "key3";
            this.key3.Size = new System.Drawing.Size(40, 28);
            this.key3.TabIndex = 34;
            // 
            // key2
            // 
            this.key2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.key2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key2.Location = new System.Drawing.Point(312, 312);
            this.key2.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.key2.Name = "key2";
            this.key2.Size = new System.Drawing.Size(40, 28);
            this.key2.TabIndex = 35;
            // 
            // key1
            // 
            this.key1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.key1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key1.Location = new System.Drawing.Point(358, 312);
            this.key1.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.key1.Name = "key1";
            this.key1.Size = new System.Drawing.Size(40, 28);
            this.key1.TabIndex = 36;
            // 
            // rotorSelection3
            // 
            this.rotorSelection3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rotorSelection3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotorSelection3.Location = new System.Drawing.Point(561, 315);
            this.rotorSelection3.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.rotorSelection3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rotorSelection3.Name = "rotorSelection3";
            this.rotorSelection3.Size = new System.Drawing.Size(40, 28);
            this.rotorSelection3.TabIndex = 37;
            this.rotorSelection3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rotorSelection2
            // 
            this.rotorSelection2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rotorSelection2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotorSelection2.Location = new System.Drawing.Point(607, 315);
            this.rotorSelection2.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.rotorSelection2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rotorSelection2.Name = "rotorSelection2";
            this.rotorSelection2.Size = new System.Drawing.Size(40, 28);
            this.rotorSelection2.TabIndex = 38;
            this.rotorSelection2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rotorSelection1
            // 
            this.rotorSelection1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rotorSelection1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotorSelection1.Location = new System.Drawing.Point(653, 315);
            this.rotorSelection1.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.rotorSelection1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rotorSelection1.Name = "rotorSelection1";
            this.rotorSelection1.Size = new System.Drawing.Size(40, 28);
            this.rotorSelection1.TabIndex = 39;
            this.rotorSelection1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(275, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 15);
            this.label10.TabIndex = 42;
            this.label10.Text = "3";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(318, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 15);
            this.label11.TabIndex = 41;
            this.label11.Text = "2";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(365, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 15);
            this.label12.TabIndex = 40;
            this.label12.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rotorSelection1);
            this.Controls.Add(this.rotorSelection2);
            this.Controls.Add(this.rotorSelection3);
            this.Controls.Add(this.key1);
            this.Controls.Add(this.key2);
            this.Controls.Add(this.key3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reflectorBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.patch12);
            this.Controls.Add(this.patch11);
            this.Controls.Add(this.patch10);
            this.Controls.Add(this.patch9);
            this.Controls.Add(this.patch8);
            this.Controls.Add(this.patch7);
            this.Controls.Add(this.patch6);
            this.Controls.Add(this.patch5);
            this.Controls.Add(this.patch4);
            this.Controls.Add(this.patch3);
            this.Controls.Add(this.patch2);
            this.Controls.Add(this.patch1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cipherTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cipherButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "Form1";
            this.Text = "Enigma";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotorSelection3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotorSelection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotorSelection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cipherButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cipherTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox patch1;
        private System.Windows.Forms.TextBox patch2;
        private System.Windows.Forms.TextBox patch3;
        private System.Windows.Forms.TextBox patch4;
        private System.Windows.Forms.TextBox patch5;
        private System.Windows.Forms.TextBox patch6;
        private System.Windows.Forms.TextBox patch7;
        private System.Windows.Forms.TextBox patch8;
        private System.Windows.Forms.TextBox patch9;
        private System.Windows.Forms.TextBox patch10;
        private System.Windows.Forms.TextBox patch11;
        private System.Windows.Forms.TextBox patch12;
        private System.Windows.Forms.CheckedListBox reflectorBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown key3;
        private System.Windows.Forms.NumericUpDown key2;
        private System.Windows.Forms.NumericUpDown key1;
        private System.Windows.Forms.NumericUpDown rotorSelection3;
        private System.Windows.Forms.NumericUpDown rotorSelection2;
        private System.Windows.Forms.NumericUpDown rotorSelection1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

