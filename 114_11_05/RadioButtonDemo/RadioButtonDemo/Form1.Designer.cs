namespace RadioButtonDemo
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
            groupBox1 = new GroupBox();
            orangejuiceRadioButton = new RadioButton();
            milkteaRadioButton = new RadioButton();
            blackteaRadioButton = new RadioButton();
            coffeeRedioButton = new RadioButton();
            groupBox2 = new GroupBox();
            hamRadioButton = new RadioButton();
            jamsandwichRadioButton = new RadioButton();
            tunarradioButton = new RadioButton();
            sendbutton = new Button();
            exitbutton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(orangejuiceRadioButton);
            groupBox1.Controls.Add(milkteaRadioButton);
            groupBox1.Controls.Add(blackteaRadioButton);
            groupBox1.Controls.Add(coffeeRedioButton);
            groupBox1.Location = new Point(35, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 411);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "飲料";
            // 
            // orangejuiceRadioButton
            // 
            orangejuiceRadioButton.AutoSize = true;
            orangejuiceRadioButton.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            orangejuiceRadioButton.Location = new Point(144, 313);
            orangejuiceRadioButton.Name = "orangejuiceRadioButton";
            orangejuiceRadioButton.Size = new Size(139, 45);
            orangejuiceRadioButton.TabIndex = 7;
            orangejuiceRadioButton.TabStop = true;
            orangejuiceRadioButton.Text = "柳橙汁";
            orangejuiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // milkteaRadioButton
            // 
            milkteaRadioButton.AutoSize = true;
            milkteaRadioButton.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            milkteaRadioButton.Location = new Point(144, 132);
            milkteaRadioButton.Name = "milkteaRadioButton";
            milkteaRadioButton.Size = new Size(107, 45);
            milkteaRadioButton.TabIndex = 6;
            milkteaRadioButton.TabStop = true;
            milkteaRadioButton.Text = "奶茶";
            milkteaRadioButton.UseVisualStyleBackColor = true;
            // 
            // blackteaRadioButton
            // 
            blackteaRadioButton.AutoSize = true;
            blackteaRadioButton.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            blackteaRadioButton.Location = new Point(144, 224);
            blackteaRadioButton.Name = "blackteaRadioButton";
            blackteaRadioButton.Size = new Size(107, 45);
            blackteaRadioButton.TabIndex = 5;
            blackteaRadioButton.TabStop = true;
            blackteaRadioButton.Text = "紅茶";
            blackteaRadioButton.UseVisualStyleBackColor = true;
            // 
            // coffeeRedioButton
            // 
            coffeeRedioButton.AutoSize = true;
            coffeeRedioButton.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            coffeeRedioButton.Location = new Point(144, 53);
            coffeeRedioButton.Name = "coffeeRedioButton";
            coffeeRedioButton.Size = new Size(107, 45);
            coffeeRedioButton.TabIndex = 4;
            coffeeRedioButton.TabStop = true;
            coffeeRedioButton.Text = "咖啡";
            coffeeRedioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(hamRadioButton);
            groupBox2.Controls.Add(jamsandwichRadioButton);
            groupBox2.Controls.Add(tunarradioButton);
            groupBox2.Location = new Point(503, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 411);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "三明治";
            // 
            // hamRadioButton
            // 
            hamRadioButton.AutoSize = true;
            hamRadioButton.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            hamRadioButton.Location = new Point(85, 178);
            hamRadioButton.Name = "hamRadioButton";
            hamRadioButton.Size = new Size(203, 45);
            hamRadioButton.TabIndex = 9;
            hamRadioButton.TabStop = true;
            hamRadioButton.Text = "火腿三明治";
            hamRadioButton.UseVisualStyleBackColor = true;
            // 
            // jamsandwichRadioButton
            // 
            jamsandwichRadioButton.AutoSize = true;
            jamsandwichRadioButton.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            jamsandwichRadioButton.Location = new Point(85, 277);
            jamsandwichRadioButton.Name = "jamsandwichRadioButton";
            jamsandwichRadioButton.Size = new Size(203, 45);
            jamsandwichRadioButton.TabIndex = 8;
            jamsandwichRadioButton.TabStop = true;
            jamsandwichRadioButton.Text = "果醬三明治";
            jamsandwichRadioButton.UseVisualStyleBackColor = true;
            // 
            // tunarradioButton
            // 
            tunarradioButton.AutoSize = true;
            tunarradioButton.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            tunarradioButton.Location = new Point(85, 88);
            tunarradioButton.Name = "tunarradioButton";
            tunarradioButton.Size = new Size(203, 45);
            tunarradioButton.TabIndex = 7;
            tunarradioButton.TabStop = true;
            tunarradioButton.Text = "鮪魚三明治";
            tunarradioButton.UseVisualStyleBackColor = true;
            // 
            // sendbutton
            // 
            sendbutton.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            sendbutton.Location = new Point(164, 599);
            sendbutton.Name = "sendbutton";
            sendbutton.Size = new Size(166, 93);
            sendbutton.TabIndex = 9;
            sendbutton.Text = "送出訂單";
            sendbutton.UseVisualStyleBackColor = true;
            sendbutton.Click += sendbutton_Click;
            // 
            // exitbutton
            // 
            exitbutton.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            exitbutton.Location = new Point(625, 599);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(166, 93);
            exitbutton.TabIndex = 10;
            exitbutton.Text = "離開";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += exitbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 838);
            Controls.Add(exitbutton);
            Controls.Add(sendbutton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton orangejuiceRadioButton;
        private RadioButton milkteaRadioButton;
        private RadioButton blackteaRadioButton;
        private RadioButton coffeeRedioButton;
        private GroupBox groupBox2;
        private RadioButton hamRadioButton;
        private RadioButton jamsandwichRadioButton;
        private RadioButton tunarradioButton;
        private Button sendbutton;
        private Button exitbutton;
    }
}
