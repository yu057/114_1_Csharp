namespace RadioButtonDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            String message = "點餐內容: ";
            String drink = "";
            String sandwich = "";

            // 修正：移除 if 後面的分號，否則 else if 會報錯
            if (coffeeRedioButton.Checked)
            {
                drink = "咖啡 ";
            }
            else if (milkteaRadioButton.Checked)
            {
                drink = "奶茶";
            }
            else if (blackteaRadioButton.Checked)
            {
                drink = "紅茶 ";
            }
            else if (orangejuiceRadioButton.Checked)
            {
                drink = "柳橙汁 ";
            }
            else
            {
                drink = "未選擇飲料 ";
            }
            if (hamRadioButton.Checked)
            {
                sandwich = "火腿三明治 ";
            }
            else if (tunarradioButton.Checked)
            {
                sandwich = "鮪魚三明治 ";
            }
            else if (jamsandwichRadioButton.Checked)
            {
                sandwich = "果醬三明治 ";
            }


            else
            {
                sandwich = " ";
            }

            message = drink + sandwich;
            MessageBox.Show(message, "您的點餐內容");

            // 你可以在這裡繼續後續邏輯
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
        this.Close();
        }
    }
}
