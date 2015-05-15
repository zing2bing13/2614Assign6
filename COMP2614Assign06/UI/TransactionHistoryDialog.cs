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
    public partial class TransactionHistoryDialog : Form
    {
        TransactionCollection transactions;

        public TransactionHistoryDialog(TransactionCollection transactions)
        {
            InitializeComponent();
            this.transactions = transactions;
            transactionString();
        }

        // Triggers event if the checkbox for details is checked
        private void checkBoxShowDetails_CheckedChanged(object sender, EventArgs e)
        {
            transactionString();
        }

        // Creates the string to display the transactions.
        private void transactionString()
        {
            string stringTransaction = "";
            if (transactions.Count == 0)
            {
                textBoxTransactionHistory.Text = "<none>";
            }
            else
            {
                if (checkBoxShowDetails.Checked)
                {
                    foreach (Transaction transaction in transactions)
                    {
                        stringTransaction += transaction.Details;
                    }
                }
                else
                {
                    foreach (Transaction transaction in transactions)
                    {
                        stringTransaction += transaction.Summary;
                    }
                }
                textBoxTransactionHistory.Text = string.Empty;
                textBoxTransactionHistory.Text = stringTransaction;
            }
        }
    }
}
