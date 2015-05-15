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
    public partial class TransferFundsDialog : Form
    {
        Customer customer;

        public TransferFundsDialog(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            comboBoxFromAccounts.DataSource = customer.Accounts;
            AddToAccounts();
            textBoxAmount.Select();
        }

        // Adds the unselected accounts to the To Accounts combo box.
        private void AddToAccounts()
        {
            comboBoxToAccounts.Items.Clear();

            foreach (BankAccount account in customer.Accounts)
            {
                if (account != comboBoxFromAccounts.SelectedItem)
                {
                    comboBoxToAccounts.Items.Add(account);
                }
            }
            comboBoxToAccounts.SelectedIndex = 0;
        }

        // Updates the To Accounts combobox when a new account is selected from the From Accounts combo box.
        private void comboBoxFromAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddToAccounts();
        }

        // Checks to see if accounts are selected and that the amount entered is actually a number.
        // Then creates the TransferFunds Transaction and catches any exceptions thrown.
        // If no exceptions are thrown, then the transaction is marked as completed and the amount
        // is transferred.
        private void buttonOK_Click(object sender, EventArgs e)
        {
            errorProviderTransferFundsDialog.SetError(comboBoxFromAccounts, string.Empty);
            errorProviderTransferFundsDialog.SetError(comboBoxToAccounts, string.Empty);
            errorProviderTransferFundsDialog.SetError(textBoxAmount, string.Empty);

            if (comboBoxFromAccounts.SelectedIndex == -1)
            {
                errorProviderTransferFundsDialog.SetError(comboBoxFromAccounts, "Please select an account to withdraw funds from.");
                comboBoxFromAccounts.Select();
            }
            else if (comboBoxToAccounts.SelectedIndex == -1)
            {
                errorProviderTransferFundsDialog.SetError(comboBoxToAccounts, "Please select an account to deposit funds into.");
                comboBoxFromAccounts.Select();
            }
            else
            {
                decimal transferAmount;

                if (decimal.TryParse(textBoxAmount.Text, out transferAmount))
                {
                    BankAccount fromAcct = comboBoxFromAccounts.SelectedItem as BankAccount;
                    BankAccount toAcct = comboBoxToAccounts.SelectedItem as BankAccount;

                    try
                    {
                        Transaction transaction = new TransferFundsTransaction(fromAcct, toAcct, transferAmount);
                        transaction.DoTransaction();
                        customer.TransactionHistory.Add(transaction);
                        DialogResult = DialogResult.OK;
                    }

                    catch (AccountInactiveException ex)
                    {
                        if(ex.Account == fromAcct)
                        {
                            errorProviderTransferFundsDialog.SetError(comboBoxFromAccounts, string.Format("{0}\n\nAccount #{1}", ex.Message, ex.Account));
                        }
                        else if(ex.Account == toAcct)
                        {
                            errorProviderTransferFundsDialog.SetError(comboBoxToAccounts, string.Format("{0}\n\nAccount #{1}", ex.Message, ex.Account));
                        }
                    }

                    catch (TransferFundsException ex)
                    {
                        errorProviderTransferFundsDialog.SetError(comboBoxFromAccounts, ex.Message);
                        errorProviderTransferFundsDialog.SetError(comboBoxToAccounts, ex.Message);
                    }
                    catch (InvalidTransactionAmtException ex)
                    {
                        errorProviderTransferFundsDialog.SetError(textBoxAmount, ex.Message);
                        textBoxAmount.Select();
                        textBoxAmount.SelectAll();
                    }

                    catch (NoSufficientFundsException ex)
                    {
                        errorProviderTransferFundsDialog.SetError(textBoxAmount, string.Format("{0}\n\nAccount number:\t{1}\nAccount Balance:\t${2:N2}\nWithdrawal:\t${3:N2}",
                                           ex.Message
                                         , ex.Account.AccountNumber
                                         , ex.Account.Balance
                                         , ex.WithdrawalAmount));
                        textBoxAmount.Select();
                        textBoxAmount.SelectAll();
                    }
                }

                else
                {
                    errorProviderTransferFundsDialog.SetError(textBoxAmount, "Please enter a valid amount to transfer.");
                    textBoxAmount.Select();
                    textBoxAmount.SelectAll();
                }
            }
        }
    }
}