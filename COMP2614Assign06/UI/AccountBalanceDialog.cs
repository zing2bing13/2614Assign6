using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankBizLogic;

namespace COMP2614Assign06.UI
{
    public partial class AccountBalanceDialog : Form
    {
        private BankAccountCollection accounts;

        public AccountBalanceDialog(BankAccountCollection accounts)
        {
            InitializeComponent();
            this.accounts = accounts;
            comboBoxAccounts.DataSource = accounts;
        }

        private void AccountBalanceDialog_Load(object sender, EventArgs e)
        {
            labelCreditLimit.Text = string.Empty;
        }

        // Updates the textbox with the newly selected account balance.  Displays the line
        // of credit if the account is of that type.
        private void comboBoxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            BankAccount account = accounts[comboBoxAccounts.SelectedIndex] as BankAccount;
            
            if (account != null)
            {
                SavingsAccount saveAccount = account as SavingsAccount;
                LineOfCreditAccount creditAccount = account as LineOfCreditAccount;

                if (saveAccount != null)
                {
                    textBoxAccountBalance.Text = string.Format("{0:C}", saveAccount.Balance);
                    labelCreditLimit.Text = string.Empty;
                }

                if (creditAccount != null)
                {
                    textBoxAccountBalance.Text = string.Format("{0:C}", creditAccount.Balance);
                    labelCreditLimit.Text = string.Format("Credit Limit: {0:C}", creditAccount.CreditLimit);
                }
            }
        }
    }
}
