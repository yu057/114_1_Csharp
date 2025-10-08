using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        // 定義常數：各種硬幣的面額（單位：分）
        const decimal FIVE_CENT = 5.0m;
        const decimal TEN_CENT = 10.0m;
        const decimal TWENTYFIVE_CENT = 25.0m;
        const decimal FIFTY_CENT = 50.0m;

        // 儲存目前總金額（單位：分）
        private decimal total;

        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 點擊 5 分硬幣圖片時執行的事件處理函式
        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 將 5 分加入總金額
            total = total + 5;
            // 顯示目前總金額於標籤上
            totalLabel.Text = total.ToString();
        }

        // 點擊 10 分硬幣圖片時執行的事件處理函式
        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 將 10 分加入總金額
            total = total + 10;
            // 顯示目前總金額於標籤上
            totalLabel.Text = total.ToString();
        }

        // 點擊 25 分硬幣圖片時執行的事件處理函式
        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 將 25 分加入總金額
            total = total + 25;
            // 顯示目前總金額於標籤上
            totalLabel.Text = total.ToString();
        }

        // 點擊 50 分硬幣圖片時執行的事件處理函式
        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 將 50 分加入總金額
            total = total + 50;
            // 顯示目前總金額於標籤上
            totalLabel.Text = total.ToString();
        }

        // 點擊離開按鈕時執行的事件處理函式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
