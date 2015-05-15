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
    public partial class DepositDialog : Form
    {
        private Customer customer;
        public DepositDialog(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            comboBoxAccounts.DataSource = customer.Accounts;
        }

        private void DepositDialog_Load(object sender, EventArgs e)
        {
            textBoxAmount.Select();
        }

        // Checks that an account has been selected.  Checks to see an actual non-negative
        // number has been entered and displays a message box if it is not.
        // If no exceptions are thrown, then the transaction is processed.
        private void buttonOK_Click(object sender, EventArgs e)
        {
            errorProviderDepositDialog.SetError(comboBoxAccounts, string.Empty);
            errorProviderDepositDialog.SetError(textBoxAmount, string.Empty);

            if (comboBoxAccounts.SelectedIndex == -1)
            {
                errorProviderDepositDialog.SetError(comboBoxAccounts, "Please select an account to deposit funds into.");
                comboBoxAccounts.Select();
            }
            else
            {
                decimal depositAmount;

                if (decimal.TryParse(textBoxAmount.Text, out depositAmount))
                {
                    try
                    {
                        BankAccount account = comboBoxAccounts.SelectedItem as BankAccount;
                        Transaction transaction = new DepositTransaction(account, depositAmount);
                        transaction.DoTransaction();
                        customer.TransactionHistory.Add(transaction);
                        DialogResult = DialogResult.OK;
                    }

                    catch (AccountInactiveException ex)
                    {
                        errorProviderDepositDialog.SetError(comboBoxAccounts, ex.Message);
                        comboBoxAccounts.Select();
                    }

                    catch (InvalidTransactionAmtException ex)
                    {
                        errorProviderDepositDialog.SetError(textBoxAmount, ex.Message);
                        textBoxAmount.Select();
                        textBoxAmount.SelectAll();
                    }
                }

                else
                {
                    errorProviderDepositDialog.SetError(textBoxAmount, "Invalid amount.  Please enter a numeric value. ");
                    textBoxAmount.Select();
                    textBoxAmount.SelectAll();
                }
            }
        }
    }
}