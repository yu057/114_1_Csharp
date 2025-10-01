namespace tutorial_3_1
{
    partial class Form1
    {
        /// <summary>
        ///  設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應釋放受控資源則為 true，否則為 false。</param>
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
        ///  設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        ///  這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dayOfWeekTextbox = new TextBox();
            monthTextbox = new TextBox();
            yearTextbox = new TextBox();
            dayOfMonthTextbox = new TextBox();
            dateOutputLabel = new Label();
            showDateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("華康中特圓體", 24F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(65, 57);
            label1.Name = "label1";
            label1.Size = new Size(168, 48);
            label1.TabIndex = 0;
            label1.Text = "星期 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("華康中特圓體", 24F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(114, 147);
            label2.Name = "label2";
            label2.Size = new Size(119, 48);
            label2.TabIndex = 1;
            label2.Text = "月 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("華康中特圓體", 24F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label3.Location = new Point(114, 362);
            label3.Name = "label3";
            label3.Size = new Size(119, 48);
            label3.TabIndex = 2;
            label3.Text = "年 :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("華康中特圓體", 24F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label4.Location = new Point(114, 256);
            label4.Name = "label4";
            label4.Size = new Size(119, 48);
            label4.TabIndex = 3;
            label4.Text = "日 :";
            // 
            // dayOfWeekTextbox
            // 
            dayOfWeekTextbox.Font = new Font("華康中特圓體", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dayOfWeekTextbox.Location = new Point(257, 54);
            dayOfWeekTextbox.Name = "dayOfWeekTextbox";
            dayOfWeekTextbox.Size = new Size(383, 55);
            dayOfWeekTextbox.TabIndex = 4;
            // 
            // monthTextbox
            // 
            monthTextbox.Font = new Font("華康中特圓體", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            monthTextbox.Location = new Point(257, 144);
            monthTextbox.Name = "monthTextbox";
            monthTextbox.Size = new Size(383, 55);
            monthTextbox.TabIndex = 5;
            // 
            // yearTextbox
            // 
            yearTextbox.Font = new Font("華康中特圓體", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            yearTextbox.Location = new Point(257, 359);
            yearTextbox.Name = "yearTextbox";
            yearTextbox.Size = new Size(383, 55);
            yearTextbox.TabIndex = 6;
            // 
            // dayOfMonthTextbox
            // 
            dayOfMonthTextbox.Font = new Font("華康中特圓體", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dayOfMonthTextbox.Location = new Point(257, 256);
            dayOfMonthTextbox.Name = "dayOfMonthTextbox";
            dayOfMonthTextbox.Size = new Size(383, 55);
            dayOfMonthTextbox.TabIndex = 7;
            // 
            // dateOutputLabel
            // 
            dateOutputLabel.BorderStyle = BorderStyle.Fixed3D;
            dateOutputLabel.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dateOutputLabel.Location = new Point(65, 445);
            dateOutputLabel.Name = "dateOutputLabel";
            dateOutputLabel.Size = new Size(899, 79);
            dateOutputLabel.TabIndex = 8;
            dateOutputLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // showDateButton
            // 
            showDateButton.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            showDateButton.Location = new Point(65, 548);
            showDateButton.Name = "showDateButton";
            showDateButton.Size = new Size(168, 77);
            showDateButton.TabIndex = 9;
            showDateButton.Text = "顯示日期";
            showDateButton.UseVisualStyleBackColor = true;
            showDateButton.Click += showDateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            clearButton.Location = new Point(430, 548);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(168, 77);
            clearButton.TabIndex = 10;
            clearButton.Text = "清除";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            exitButton.Location = new Point(796, 548);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(168, 77);
            exitButton.TabIndex = 11;
            exitButton.Text = "離開";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font; 
            ClientSize = new Size(1048, 649);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(showDateButton);
            Controls.Add(dateOutputLabel);
            Controls.Add(dayOfMonthTextbox);
            Controls.Add(yearTextbox);
            Controls.Add(monthTextbox);
            Controls.Add(dayOfWeekTextbox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // 標籤元件
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        // 輸入用文字方塊
        private TextBox dayOfWeekTextbox;
        private TextBox monthTextbox;
        private TextBox yearTextbox;
        private TextBox dayOfMonthTextbox;
        // 顯示結果的標籤
        private Label dateOutputLabel;
        // 按鈕元件
        private Button showDateButton;
        private Button clearButton;
        private Button exitButton;
    }
}
