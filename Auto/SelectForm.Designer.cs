﻿namespace Auto
{
    partial class SelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SysPanel = new System.Windows.Forms.Panel();
            this.SendButton = new System.Windows.Forms.Button();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.SysPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SysPanel
            // 
            this.SysPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SysPanel.Controls.Add(this.TotalPriceLabel);
            this.SysPanel.Controls.Add(this.SendButton);
            this.SysPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SysPanel.Location = new System.Drawing.Point(0, 0);
            this.SysPanel.Name = "SysPanel";
            this.SysPanel.Size = new System.Drawing.Size(1282, 60);
            this.SysPanel.TabIndex = 0;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(12, 12);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(224, 40);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Отправить на Email";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.AutoScroll = true;
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPanel.Location = new System.Drawing.Point(0, 60);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1282, 573);
            this.InfoPanel.TabIndex = 1;
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(621, 20);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(64, 25);
            this.TotalPriceLabel.TabIndex = 1;
            this.TotalPriceLabel.Text = "label1";
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1282, 633);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.SysPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SelectForm";
            this.Text = "Избранное";
            this.SysPanel.ResumeLayout(false);
            this.SysPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SysPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label TotalPriceLabel;
    }
}