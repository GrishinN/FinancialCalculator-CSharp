namespace Calcul
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
            this.perform = new System.Windows.Forms.Button();
            this.firstNumber = new System.Windows.Forms.TextBox();
            this.secondNumber = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxOperations = new System.Windows.Forms.GroupBox();
            this.radioButtonSubtraction = new System.Windows.Forms.RadioButton();
            this.radioButtonAddition = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonMultiply = new System.Windows.Forms.RadioButton();
            this.radioButtonDivide = new System.Windows.Forms.RadioButton();
            this.groupBoxOperations.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // perform
            // 
            this.perform.Location = new System.Drawing.Point(921, 450);
            this.perform.Name = "perform";
            this.perform.Size = new System.Drawing.Size(240, 86);
            this.perform.TabIndex = 2;
            this.perform.Text = "Вычислить";
            this.perform.UseVisualStyleBackColor = true;
            this.perform.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstNumber
            // 
            this.firstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNumber.Location = new System.Drawing.Point(45, 125);
            this.firstNumber.Multiline = true;
            this.firstNumber.Name = "firstNumber";
            this.firstNumber.Size = new System.Drawing.Size(482, 54);
            this.firstNumber.TabIndex = 4;
            this.firstNumber.Text = "Первое число";
            this.firstNumber.Click += new System.EventHandler(this.firstNumber_Click);
            this.firstNumber.TextChanged += new System.EventHandler(this.firstNumber_TextChanged);
            this.firstNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNumber_KeyPress);
            // 
            // secondNumber
            // 
            this.secondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNumber.Location = new System.Drawing.Point(657, 125);
            this.secondNumber.Multiline = true;
            this.secondNumber.Name = "secondNumber";
            this.secondNumber.Size = new System.Drawing.Size(505, 54);
            this.secondNumber.TabIndex = 5;
            this.secondNumber.Text = "Второе число";
            this.secondNumber.Click += new System.EventHandler(this.secondNumber_Click);
            this.secondNumber.TextChanged += new System.EventHandler(this.SecondNumber_TextChanged);
            this.secondNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondNumber_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(261, 463);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(549, 50);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Ответ";
            // 
            // groupBoxOperations
            // 
            this.groupBoxOperations.Controls.Add(this.radioButtonDivide);
            this.groupBoxOperations.Controls.Add(this.radioButtonMultiply);
            this.groupBoxOperations.Controls.Add(this.radioButtonSubtraction);
            this.groupBoxOperations.Controls.Add(this.radioButtonAddition);
            this.groupBoxOperations.Location = new System.Drawing.Point(402, 208);
            this.groupBoxOperations.Name = "groupBoxOperations";
            this.groupBoxOperations.Size = new System.Drawing.Size(298, 217);
            this.groupBoxOperations.TabIndex = 7;
            this.groupBoxOperations.TabStop = false;
            this.groupBoxOperations.Text = "Операции";
            // 
            // radioButtonSubtraction
            // 
            this.radioButtonSubtraction.AutoSize = true;
            this.radioButtonSubtraction.Location = new System.Drawing.Point(30, 94);
            this.radioButtonSubtraction.Name = "radioButtonSubtraction";
            this.radioButtonSubtraction.Size = new System.Drawing.Size(164, 36);
            this.radioButtonSubtraction.TabIndex = 1;
            this.radioButtonSubtraction.TabStop = true;
            this.radioButtonSubtraction.Text = "Вычесть";
            this.radioButtonSubtraction.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddition
            // 
            this.radioButtonAddition.AutoSize = true;
            this.radioButtonAddition.Location = new System.Drawing.Point(30, 52);
            this.radioButtonAddition.Name = "radioButtonAddition";
            this.radioButtonAddition.Size = new System.Drawing.Size(168, 36);
            this.radioButtonAddition.TabIndex = 0;
            this.radioButtonAddition.TabStop = true;
            this.radioButtonAddition.Text = "Сложить";
            this.radioButtonAddition.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1205, 49);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(145, 45);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(318, 46);
            this.aboutProgramToolStripMenuItem.Text = "О программе";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // radioButtonMultiply
            // 
            this.radioButtonMultiply.AutoSize = true;
            this.radioButtonMultiply.Location = new System.Drawing.Point(30, 137);
            this.radioButtonMultiply.Name = "radioButtonMultiply";
            this.radioButtonMultiply.Size = new System.Drawing.Size(186, 36);
            this.radioButtonMultiply.TabIndex = 2;
            this.radioButtonMultiply.TabStop = true;
            this.radioButtonMultiply.Text = "Умножить";
            this.radioButtonMultiply.UseVisualStyleBackColor = true;
            // 
            // radioButtonDivide
            // 
            this.radioButtonDivide.AutoSize = true;
            this.radioButtonDivide.Location = new System.Drawing.Point(30, 180);
            this.radioButtonDivide.Name = "radioButtonDivide";
            this.radioButtonDivide.Size = new System.Drawing.Size(193, 36);
            this.radioButtonDivide.TabIndex = 3;
            this.radioButtonDivide.TabStop = true;
            this.radioButtonDivide.Text = "Разделить";
            this.radioButtonDivide.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 558);
            this.Controls.Add(this.groupBoxOperations);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.secondNumber);
            this.Controls.Add(this.firstNumber);
            this.Controls.Add(this.perform);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1237, 646);
            this.MinimumSize = new System.Drawing.Size(1237, 646);
            this.Name = "Form1";
            this.Text = "Финансовый калькулятор";
            this.groupBoxOperations.ResumeLayout(false);
            this.groupBoxOperations.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button perform;
        private System.Windows.Forms.TextBox firstNumber;
        private System.Windows.Forms.TextBox secondNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxOperations;
        private System.Windows.Forms.RadioButton radioButtonSubtraction;
        private System.Windows.Forms.RadioButton radioButtonAddition;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButtonDivide;
        private System.Windows.Forms.RadioButton radioButtonMultiply;
    }
}

