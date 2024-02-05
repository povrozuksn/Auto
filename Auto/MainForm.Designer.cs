namespace Auto
{
    partial class MainForm
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
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.AuthButton = new System.Windows.Forms.Button();
            this.FiltrPanel = new System.Windows.Forms.Panel();
            this.RegButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.FiltrButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.UserPanel.SuspendLayout();
            this.FiltrPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewPanel
            // 
            this.ViewPanel.AutoScroll = true;
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPanel.Location = new System.Drawing.Point(0, 154);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(1032, 501);
            this.ViewPanel.TabIndex = 8;
            this.ViewPanel.Resize += new System.EventHandler(this.ViewPanel_Resize);
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UserPanel.Controls.Add(this.HelpButton);
            this.UserPanel.Controls.Add(this.RegButton);
            this.UserPanel.Controls.Add(this.HelloLabel);
            this.UserPanel.Controls.Add(this.AuthButton);
            this.UserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserPanel.Location = new System.Drawing.Point(0, 0);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(1032, 55);
            this.UserPanel.TabIndex = 9;
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(170, 18);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(64, 25);
            this.HelloLabel.TabIndex = 1;
            this.HelloLabel.Text = "label1";
            // 
            // AuthButton
            // 
            this.AuthButton.Location = new System.Drawing.Point(19, 12);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(136, 37);
            this.AuthButton.TabIndex = 0;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // FiltrPanel
            // 
            this.FiltrPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FiltrPanel.Controls.Add(this.FindButton);
            this.FiltrPanel.Controls.Add(this.comboBox2);
            this.FiltrPanel.Controls.Add(this.label3);
            this.FiltrPanel.Controls.Add(this.comboBox1);
            this.FiltrPanel.Controls.Add(this.label2);
            this.FiltrPanel.Controls.Add(this.label1);
            this.FiltrPanel.Controls.Add(this.textBox1);
            this.FiltrPanel.Controls.Add(this.FiltrButton);
            this.FiltrPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FiltrPanel.Location = new System.Drawing.Point(0, 55);
            this.FiltrPanel.Name = "FiltrPanel";
            this.FiltrPanel.Size = new System.Drawing.Size(1032, 99);
            this.FiltrPanel.TabIndex = 10;
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(724, 12);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(156, 37);
            this.RegButton.TabIndex = 2;
            this.RegButton.Text = "Регистрация";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(892, 12);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(129, 37);
            this.HelpButton.TabIndex = 3;
            this.HelpButton.Text = "Помощь";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // FiltrButton
            // 
            this.FiltrButton.Location = new System.Drawing.Point(0, 0);
            this.FiltrButton.Name = "FiltrButton";
            this.FiltrButton.Size = new System.Drawing.Size(125, 33);
            this.FiltrButton.TabIndex = 0;
            this.FiltrButton.Text = "Фильтр";
            this.FiltrButton.UseVisualStyleBackColor = true;
            this.FiltrButton.Click += new System.EventHandler(this.FiltrButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 30);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Модель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип КПП";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(425, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 33);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(737, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(164, 33);
            this.comboBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тип кузова";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(920, 39);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(100, 34);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1032, 655);
            this.Controls.Add(this.ViewPanel);
            this.Controls.Add(this.FiltrPanel);
            this.Controls.Add(this.UserPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            this.FiltrPanel.ResumeLayout(false);
            this.FiltrPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Panel FiltrPanel;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button FiltrButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

