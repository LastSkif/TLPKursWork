namespace mk
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
            this.alphabetTextBox = new System.Windows.Forms.TextBox();
            this.multipleTextBox = new System.Windows.Forms.TextBox();
            this.substringTextBox = new System.Windows.Forms.TextBox();
            this.rulesTextBox = new System.Windows.Forms.TextBox();
            this.rightSideButton = new System.Windows.Forms.Button();
            this.symbolTextBox = new System.Windows.Forms.TextBox();
            this.lowerBound = new System.Windows.Forms.TextBox();
            this.upperBound = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.stringsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вводToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выводToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftSideButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // alphabetTextBox
            // 
            this.alphabetTextBox.Location = new System.Drawing.Point(11, 36);
            this.alphabetTextBox.Name = "alphabetTextBox";
            this.alphabetTextBox.Size = new System.Drawing.Size(100, 20);
            this.alphabetTextBox.TabIndex = 0;
            // 
            // multipleTextBox
            // 
            this.multipleTextBox.Location = new System.Drawing.Point(11, 158);
            this.multipleTextBox.Name = "multipleTextBox";
            this.multipleTextBox.Size = new System.Drawing.Size(100, 20);
            this.multipleTextBox.TabIndex = 1;
            // 
            // substringTextBox
            // 
            this.substringTextBox.Location = new System.Drawing.Point(11, 75);
            this.substringTextBox.Name = "substringTextBox";
            this.substringTextBox.Size = new System.Drawing.Size(100, 20);
            this.substringTextBox.TabIndex = 2;
            // 
            // rulesTextBox
            // 
            this.rulesTextBox.Location = new System.Drawing.Point(139, 36);
            this.rulesTextBox.Multiline = true;
            this.rulesTextBox.Name = "rulesTextBox";
            this.rulesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rulesTextBox.Size = new System.Drawing.Size(225, 301);
            this.rulesTextBox.TabIndex = 3;
            // 
            // rightSideButton
            // 
            this.rightSideButton.Location = new System.Drawing.Point(11, 199);
            this.rightSideButton.Name = "rightSideButton";
            this.rightSideButton.Size = new System.Drawing.Size(115, 23);
            this.rightSideButton.TabIndex = 4;
            this.rightSideButton.Text = "Правосторонняя";
            this.rightSideButton.UseVisualStyleBackColor = true;
            this.rightSideButton.Click += new System.EventHandler(this.rightSideButton_Click);
            // 
            // symbolTextBox
            // 
            this.symbolTextBox.Location = new System.Drawing.Point(11, 119);
            this.symbolTextBox.Name = "symbolTextBox";
            this.symbolTextBox.Size = new System.Drawing.Size(100, 20);
            this.symbolTextBox.TabIndex = 5;
            // 
            // lowerBound
            // 
            this.lowerBound.Location = new System.Drawing.Point(64, 20);
            this.lowerBound.Name = "lowerBound";
            this.lowerBound.Size = new System.Drawing.Size(135, 20);
            this.lowerBound.TabIndex = 6;
            // 
            // upperBound
            // 
            this.upperBound.Location = new System.Drawing.Point(64, 49);
            this.upperBound.Name = "upperBound";
            this.upperBound.Size = new System.Drawing.Size(135, 20);
            this.upperBound.TabIndex = 7;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(20, 378);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(168, 23);
            this.generateButton.TabIndex = 8;
            this.generateButton.Text = "Сгенерировать";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // stringsTextBox
            // 
            this.stringsTextBox.Location = new System.Drawing.Point(6, 97);
            this.stringsTextBox.Multiline = true;
            this.stringsTextBox.Name = "stringsTextBox";
            this.stringsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stringsTextBox.Size = new System.Drawing.Size(205, 277);
            this.stringsTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Подстрока";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Символ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авторToolStripMenuItem,
            this.заданиеToolStripMenuItem,
            this.вводToolStripMenuItem,
            this.выводToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // авторToolStripMenuItem
            // 
            this.авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            this.авторToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.авторToolStripMenuItem.Text = "Автор";
            this.авторToolStripMenuItem.Click += new System.EventHandler(this.авторToolStripMenuItem_Click);
            // 
            // заданиеToolStripMenuItem
            // 
            this.заданиеToolStripMenuItem.Name = "заданиеToolStripMenuItem";
            this.заданиеToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.заданиеToolStripMenuItem.Text = "Задание";
            this.заданиеToolStripMenuItem.Click += new System.EventHandler(this.заданиеToolStripMenuItem_Click);
            // 
            // вводToolStripMenuItem
            // 
            this.вводToolStripMenuItem.Name = "вводToolStripMenuItem";
            this.вводToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.вводToolStripMenuItem.Text = "Ввод";
            this.вводToolStripMenuItem.Click += new System.EventHandler(this.вводToolStripMenuItem_Click);
            // 
            // выводToolStripMenuItem
            // 
            this.выводToolStripMenuItem.Name = "выводToolStripMenuItem";
            this.выводToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.выводToolStripMenuItem.Text = "Вывод";
            this.выводToolStripMenuItem.Click += new System.EventHandler(this.выводToolStripMenuItem_Click);
            // 
            // leftSideButton
            // 
            this.leftSideButton.Location = new System.Drawing.Point(11, 228);
            this.leftSideButton.Name = "leftSideButton";
            this.leftSideButton.Size = new System.Drawing.Size(115, 23);
            this.leftSideButton.TabIndex = 13;
            this.leftSideButton.Text = "Левосторонняя";
            this.leftSideButton.UseVisualStyleBackColor = true;
            this.leftSideButton.Click += new System.EventHandler(this.leftSideButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Алфавит";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Кратность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Нижняя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Верхняя";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 32);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(129, 20);
            this.inputTextBox.TabIndex = 18;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(217, 34);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(145, 20);
            this.outputTextBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ввод";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Вывод";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rulesTextBox);
            this.groupBox1.Controls.Add(this.alphabetTextBox);
            this.groupBox1.Controls.Add(this.leftSideButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.multipleTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.substringTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.symbolTextBox);
            this.groupBox1.Controls.Add(this.rightSideButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 343);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генерация грамматики";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.outputTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 60);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод/вывод в файл";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.stringsTextBox);
            this.groupBox3.Controls.Add(this.generateButton);
            this.groupBox3.Location = new System.Drawing.Point(390, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 409);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Генерация цепочек";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lowerBound);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.upperBound);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(6, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(205, 75);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Границы диапазона длин";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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

        private System.Windows.Forms.TextBox alphabetTextBox;
        private System.Windows.Forms.TextBox multipleTextBox;
        private System.Windows.Forms.TextBox substringTextBox;
        private System.Windows.Forms.TextBox rulesTextBox;
        private System.Windows.Forms.Button rightSideButton;
        private System.Windows.Forms.TextBox symbolTextBox;
        private System.Windows.Forms.TextBox lowerBound;
        private System.Windows.Forms.TextBox upperBound;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox stringsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button leftSideButton;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заданиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вводToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выводToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}