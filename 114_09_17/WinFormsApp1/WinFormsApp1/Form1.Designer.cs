﻿namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            messageButton = new Button();
            SuspendLayout();
            // 
            // messageButton
            // 
            messageButton.Font = new Font("華康中特圓體", 24F, FontStyle.Bold, GraphicsUnit.Point, 136);
            messageButton.Location = new Point(217, 107);
            messageButton.Name = "messageButton";
            messageButton.Size = new Size(261, 133);
            messageButton.TabIndex = 0;
            messageButton.Text = "顯示訊息";
            messageButton.UseVisualStyleBackColor = true;
            messageButton.Click += messageButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 345);
            Controls.Add(messageButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button messageButton;
    }
}
