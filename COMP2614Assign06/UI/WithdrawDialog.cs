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
    public partial class WithdrawDialog : Form
    {
        Customer customer;

        public WithdrawDialog(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            comboBoxAccounts.DataSource = customer.Accounts;
        }

        private void WithdrawDialog_Load(object sender, EventArgs e)
        {
            textBoxAmount.Select();
        }

        // Checks to see if an account has been selected.  Checks to see that a non-negative
        // number has been entered, displays a message box with error if not.  Attempts
        // to perform transaction, catches exceptions if thrown.  Completes transaction
        // if no exceptions are thrown.
        private void buttonOK_Click(object sender, EventArgs e)
        {
            errorProviderWithdrawDialog.SetError(comboBoxAccounts, string.Empty);
            errorProviderWithdrawDialog.SetError(textBoxAmount, string.Empty);

            if (comboBoxAccounts.SelectedIndex == -1)
            {
                errorProviderWithdrawDialog.SetError(comboBoxAccounts, "Please select an account to deposit funds into.");
                comboBoxAccounts.Select();
            }
            else
            {
                decimal withdrawalAmount;

                if (decimal.TryParse(textBoxAmount.Text, out withdrawalAmount))
                {
                    try
                    {
                        BankAccount account = comboBoxAccounts.SelectedItem as BankAccount;
                        Transaction transaction = new WithdrawalTransaction(account, withdrawalAmount);
                        transaction.DoTransaction();
                        customer.TransactionHistory.Add(transaction);
                        DialogResult = DialogResult.OK;
                    }

                    catch (AccountInactiveException ex)
                    {
                        errorProviderWithdrawDialog.SetError(comboBoxAccounts, ex.Message);
                        comboBoxAccounts.Select();
                    }

                    catch (InvalidTransactionAmtException ex)
                    {
                        errorProviderWithdrawDialog.SetError(textBoxAmount, ex.Message);
                        textBoxAmount.Select();
                        textBoxAmount.SelectAll();
                    }

                    catch (NoSufficientFundsException ex)
                    {
                        errorProviderWithdrawDialog.SetError(textBoxAmount, string.Format("{0}\n\nAccount Balance: ${1:N2}\nWithdraw Amount: ${2:N2}",
                                           ex.Message
                                         , ex.Account.Balance
                                         , ex.WithdrawalAmount));
                        textBoxAmount.Select();
                        textBoxAmount.SelectAll();
                    }
                }

                else
                {
                    errorProviderWithdrawDialog.SetError(textBoxAmount, "Invalid amount.  Please enter a numeric value.");
                    textBoxAmount.Select();
                    textBoxAmount.SelectAll();
                }
            }
        }
    }
}
