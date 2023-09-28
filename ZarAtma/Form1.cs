namespace ZarAtma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random dice = new Random();
            int no1 = dice.Next(1, 7);
            int no2 = dice.Next(1, 7);
            label1.Text = no1.ToString();
            label2.Text = no2.ToString();
        }
    }
}