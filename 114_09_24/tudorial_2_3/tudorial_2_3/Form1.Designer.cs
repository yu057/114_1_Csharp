namespace tudorial_2_3
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
            label1 = new Label();
            translationLabel = new Label();
            italianButton = new Button();
            spanishButton = new Button();
            germanButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("華康中特圓體", 24F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(69, 50);
            label1.Name = "label1";
            label1.Size = new Size(608, 48);
            label1.TabIndex = 0;
            label1.Text = "選擇一個語言，我會說早安";
            // 
            // translationLabel
            // 
            translationLabel.BorderStyle = BorderStyle.Fixed3D;
            translationLabel.Font = new Font("華康中特圓體", 24F, FontStyle.Bold, GraphicsUnit.Point, 136);
            translationLabel.Location = new Point(69, 141);
            translationLabel.Name = "translationLabel";
            translationLabel.Size = new Size(608, 80);
            translationLabel.TabIndex = 1;
            translationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // italianButton
            // 
            italianButton.Font = new Font("華康粗圓體", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            italianButton.Location = new Point(69, 265);
            italianButton.Name = "italianButton";
            italianButton.Size = new Size(162, 49);
            italianButton.TabIndex = 2;
            italianButton.Text = "義大利文";
            italianButton.UseVisualStyleBackColor = true;
            italianButton.Click += italianButton_Click;
            // 
            // spanishButton
            // 
            spanishButton.Font = new Font("華康粗圓體", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            spanishButton.Location = new Point(290, 265);
            spanishButton.Name = "spanishButton";
            spanishButton.Size = new Size(162, 49);
            spanishButton.TabIndex = 3;
            spanishButton.Text = "西班牙文";
            spanishButton.UseVisualStyleBackColor = true;
            spanishButton.Click += spanishButton_Click;
            // 
            // germanButton
            // 
            germanButton.Font = new Font("華康粗圓體", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            germanButton.Location = new Point(515, 265);
            germanButton.Name = "germanButton";
            germanButton.Size = new Size(162, 49);
            germanButton.TabIndex = 4;
            germanButton.Text = "德文";
            germanButton.UseVisualStyleBackColor = true;
            germanButton.Click += germanButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 374);
            Controls.Add(germanButton);
            Controls.Add(spanishButton);
            Controls.Add(italianButton);
            Controls.Add(translationLabel);
            Controls.Add(label1);
            Name = "Form1";
            Text = "語言翻譯器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label translationLabel;
        private Button italianButton;
        private Button spanishButton;
        private Button germanButton;
    }
}
