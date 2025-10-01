namespace tutorial_3_1
{
    public partial class Form1 : Form
    {
        // 建構函式，初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 按下顯示日期按鈕時執行的事件處理函式
        private void showDateButton_Click(object sender, EventArgs e)
        {
            // 取得使用者輸入的星期、月份、年份與日期
            string dayOfWeek = dayOfMonthTextbox.Text;
            string month = monthTextbox.Text;
            string year = yearTextbox.Text;
            string dayOfMonth = dayOfMonthTextbox.Text;

            string output = "中華民國" + year + " 年 " + month + " 月 " + dayOfMonth + " 日 " + " ，星期 " + dayOfWeek;

            dateOutputLabel.Text = output;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextbox.Text = "";
            monthTextbox.Text = "";
            dayOfMonthTextbox.Text = "";
            yearTextbox.Text = "";
            
        }
    }
}
