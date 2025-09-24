namespace tutorial_2_4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.germanyPicturebox = new System.Windows.Forms.PictureBox();
            this.francePicturebox = new System.Windows.Forms.PictureBox();
            this.finlandPicturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.germanyPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finlandPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("華康超黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(173, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "點選國旗會出現國家名稱";
            // 
            // countryLabel
            // 
            this.countryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countryLabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.countryLabel.Location = new System.Drawing.Point(208, 372);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(470, 93);
            this.countryLabel.TabIndex = 1;
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // germanyPicturebox
            // 
            this.germanyPicturebox.Image = global::tutorial_2_4.Properties.Resources.Germany;
            this.germanyPicturebox.Location = new System.Drawing.Point(649, 200);
            this.germanyPicturebox.Name = "germanyPicturebox";
            this.germanyPicturebox.Size = new System.Drawing.Size(178, 103);
            this.germanyPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.germanyPicturebox.TabIndex = 4;
            this.germanyPicturebox.TabStop = false;
            this.germanyPicturebox.Click += new System.EventHandler(this.germanyPicturebox_Click);
            // 
            // francePicturebox
            // 
            this.francePicturebox.Image = global::tutorial_2_4.Properties.Resources.France;
            this.francePicturebox.Location = new System.Drawing.Point(364, 200);
            this.francePicturebox.Name = "francePicturebox";
            this.francePicturebox.Size = new System.Drawing.Size(173, 103);
            this.francePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.francePicturebox.TabIndex = 3;
            this.francePicturebox.TabStop = false;
            this.francePicturebox.Click += new System.EventHandler(this.francePicturebox_Click);
            // 
            // finlandPicturebox
            // 
            this.finlandPicturebox.Image = global::tutorial_2_4.Properties.Resources.Finland;
            this.finlandPicturebox.Location = new System.Drawing.Point(76, 200);
            this.finlandPicturebox.Name = "finlandPicturebox";
            this.finlandPicturebox.Size = new System.Drawing.Size(171, 103);
            this.finlandPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.finlandPicturebox.TabIndex = 2;
            this.finlandPicturebox.TabStop = false;
            this.finlandPicturebox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 542);
            this.Controls.Add(this.germanyPicturebox);
            this.Controls.Add(this.francePicturebox);
            this.Controls.Add(this.finlandPicturebox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.germanyPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finlandPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.PictureBox finlandPicturebox;
        private System.Windows.Forms.PictureBox francePicturebox;
        private System.Windows.Forms.PictureBox germanyPicturebox;
    }
}

