namespace BankAccountWindowsFormsApp
{
    public partial class Form1 : Form
    {
        BankAccount ba1 = new BankAccount();
        BankAccount ba2 = new BankAccount();
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void BankAccount1button_Click(object sender, EventArgs e)
        {
            label1.Text = "BankAccount1";
        }

        private void BankAccount2button_Click(object sender, EventArgs e)
        {
            label1.Text = "BankAccount2";
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            int value = int.Parse(textBox1.Text);
            if (label1.Text == "BankAccount1")
            {
                ba1.Deposit(value);
                ba1textBox.Text = ba1.GetBalance().ToString();
            }
            else if(label1.Text == "BankAccount2")
            {
                ba2.Deposit(value);
                ba2textBox.Text = ba2.GetBalance().ToString();
            }
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            int value = int.Parse(textBox1.Text);
            if (label1.Text == "BankAccount1")
            {
                int balance1 = ba1.GetBalance();
                if(balance1 - value < 0)
                {

                }
                else
                {
                    ba1.Withdraw(value);
                }
                ba1textBox.Text = ba1.GetBalance().ToString();
            }
            else if (label1.Text == "BankAccount2")
            {
                int balance2 = ba2.GetBalance();
                if (balance2 - value < 0)
                {

                }
                else
                {
                    ba2.Withdraw(value);
                }
                ba2textBox.Text = ba2.GetBalance().ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}