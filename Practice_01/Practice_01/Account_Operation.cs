using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_01
{
    public partial class Account_Operation : Form
    {
        public Account_Operation()
        {
            InitializeComponent();
        }
        Transaction transaction = new Transaction();
        private void createButton_Click(object sender, EventArgs e)
        {
            transaction.customerName = nameTextBox.Text;
            transaction.accountNumber = numberTextBox.Text;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            bool isDeposited = transaction.Deposit(amount);
            if (isDeposited)
            {
                amountTextBox.Text = "";
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            bool isWithdrawn = transaction.Withdraw(amount);
            if (isWithdrawn)
            {
                amountTextBox.Text = "";
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            string message = transaction.GetInfo();
            MessageBox.Show(message);
        }
    }
}
