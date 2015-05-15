namespace COMP2614Assign06
{
    partial class BankMachineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.buttonAccountBalance = new System.Windows.Forms.Button();
            this.buttonTransferFunds = new System.Windows.Forms.Button();
            this.buttonTransactionHistory = new System.Windows.Forms.Button();
            this.timerTransactions = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeposit.Location = new System.Drawing.Point(12, 28);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(186, 29);
            this.buttonDeposit.TabIndex = 0;
            this.buttonDeposit.Text = "&Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdraw.Location = new System.Drawing.Point(12, 97);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(186, 29);
            this.buttonWithdraw.TabIndex = 1;
            this.buttonWithdraw.Text = "&Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            // 
            // buttonAccountBalance
            // 
            this.buttonAccountBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccountBalance.Location = new System.Drawing.Point(12, 168);
            this.buttonAccountBalance.Name = "buttonAccountBalance";
            this.buttonAccountBalance.Size = new System.Drawing.Size(186, 29);
            this.buttonAccountBalance.TabIndex = 2;
            this.buttonAccountBalance.Text = "&Account Balance";
            this.buttonAccountBalance.UseVisualStyleBackColor = true;
            this.buttonAccountBalance.Click += new System.EventHandler(this.buttonAccountBalance_Click);
            // 
            // buttonTransferFunds
            // 
            this.buttonTransferFunds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransferFunds.Location = new System.Drawing.Point(307, 97);
            this.buttonTransferFunds.Name = "buttonTransferFunds";
            this.buttonTransferFunds.Size = new System.Drawing.Size(186, 29);
            this.buttonTransferFunds.TabIndex = 3;
            this.buttonTransferFunds.Text = "&Transfer Funds";
            this.buttonTransferFunds.UseVisualStyleBackColor = true;
            this.buttonTransferFunds.Click += new System.EventHandler(this.buttonTransferFunds_Click);
            // 
            // buttonTransactionHistory
            // 
            this.buttonTransactionHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransactionHistory.Location = new System.Drawing.Point(307, 169);
            this.buttonTransactionHistory.Name = "buttonTransactionHistory";
            this.buttonTransactionHistory.Size = new System.Drawing.Size(186, 28);
            this.buttonTransactionHistory.TabIndex = 4;
            this.buttonTransactionHistory.Text = "Transaction &History";
            this.buttonTransactionHistory.UseVisualStyleBackColor = true;
            this.buttonTransactionHistory.Click += new System.EventHandler(this.buttonTransactionHistory_Click);
            // 
            // timerTransactions
            // 
            this.timerTransactions.Enabled = true;
            this.timerTransactions.Interval = 5000;
            this.timerTransactions.Tick += new System.EventHandler(this.timerTransactions_Tick);
            // 
            // BankMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 237);
            this.Controls.Add(this.buttonTransactionHistory);
            this.Controls.Add(this.buttonTransferFunds);
            this.Controls.Add(this.buttonAccountBalance);
            this.Controls.Add(this.buttonWithdraw);
            this.Controls.Add(this.buttonDeposit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BankMachineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Machine";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Button buttonAccountBalance;
        private System.Windows.Forms.Button buttonTransferFunds;
        private System.Windows.Forms.Button buttonTransactionHistory;
        private System.Windows.Forms.Timer timerTransactions;
    }
}

