namespace tutorial_3_1
{
    public partial class Form1 : Form
    {
        // �غc�禡�A��l�ƪ�椸��
        public Form1()
        {
            InitializeComponent();
        }

        // ���U��ܤ�����s�ɰ��檺�ƥ�B�z�禡
        private void showDateButton_Click(object sender, EventArgs e)
        {
            // ���o�ϥΪ̿�J���P���B����B�~���P���
            string dayOfWeek = dayOfMonthTextbox.Text;
            string month = monthTextbox.Text;
            string year = yearTextbox.Text;
            string dayOfMonth = dayOfMonthTextbox.Text;

            string output = "���إ���" + year + " �~ " + month + " �� " + dayOfMonth + " �� " + " �A�P�� " + dayOfWeek;

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
