﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // 初始化表單元件
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double kilometers; // 宣告公里數變數
            double liters; // 宣告公升數變數
            double kmpl; // 宣告每公升公里數變數

            //讀取使用者輸入的公升數和公里數，並轉換為雙精度浮點數
            kilometers = double.Parse(milesTextBox.Text);
            liters = double.Parse(gallonsTextBox.Text);

            //計算每公升公里數
            kmpl = kilometers / liters;

            //顯示結果
            mpgLabel.Text = kmpl.ToString("n2") + " 公里/公升";



        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
