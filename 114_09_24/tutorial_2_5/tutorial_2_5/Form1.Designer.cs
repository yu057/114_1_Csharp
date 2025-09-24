namespace tutorial_2_5
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
            cardfacePictureBox = new PictureBox();
            cardbackPictureBox = new PictureBox();
            showBackbutton = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)cardfacePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardbackPictureBox).BeginInit();
            SuspendLayout();
            // 
            // cardfacePictureBox
            // 
            cardfacePictureBox.Image = Properties.Resources.Backface_Red;
            cardfacePictureBox.Location = new Point(97, 102);
            cardfacePictureBox.Name = "cardfacePictureBox";
            cardfacePictureBox.Size = new Size(196, 273);
            cardfacePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            cardfacePictureBox.TabIndex = 0;
            cardfacePictureBox.TabStop = false;
            cardfacePictureBox.Click += cardfacePictureBox_Click;
            // 
            // cardbackPictureBox
            // 
            cardbackPictureBox.Image = Properties.Resources._2_Diamonds;
            cardbackPictureBox.Location = new Point(464, 102);
            cardbackPictureBox.Name = "cardbackPictureBox";
            cardbackPictureBox.Size = new Size(196, 273);
            cardbackPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            cardbackPictureBox.TabIndex = 2;
            cardbackPictureBox.TabStop = false;
            cardbackPictureBox.Click += cardbackPictureBox_Click;
            // 
            // showBackbutton
            // 
            showBackbutton.Location = new Point(108, 406);
            showBackbutton.Name = "showBackbutton";
            showBackbutton.Size = new Size(185, 100);
            showBackbutton.TabIndex = 3;
            showBackbutton.Text = "顯示背面";
            showBackbutton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(464, 406);
            button2.Name = "button2";
            button2.Size = new Size(184, 100);
            button2.TabIndex = 4;
            button2.Text = "顯示正面";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 606);
            Controls.Add(button2);
            Controls.Add(showBackbutton);
            Controls.Add(cardbackPictureBox);
            Controls.Add(cardfacePictureBox);
            Name = "Form1";
            Text = "翻轉撲克牌";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)cardfacePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardbackPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cardfacePictureBox;
        private PictureBox cardbackPictureBox;
        private Button showBackbutton;
        private Button button2;
    }
}
