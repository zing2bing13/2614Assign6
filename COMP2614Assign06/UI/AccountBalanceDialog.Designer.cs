namespace COMP2614Assign06.UI
{
    partial class AccountBalanceDialog
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
            this.labelAccount = new System.Windows.Forms.Label();
            this.comboBoxAccounts = new System.Windows.Forms.ComboBox();
            this.textBoxAccountBalance = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelCreditLimit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(12, 9);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(50, 13);
            this.labelAccount.TabIndex = 0;
            this.labelAccount.Text = "&Account:";
            // 
            // comboBoxAccounts
            // 
            this.comboBoxAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccounts.FormattingEnabled = true;
            this.comboBoxAccounts.Location = new System.Drawing.Point(68, 6);
            this.comboBoxAccounts.Name = "comboBoxAccounts";
            this.comboBoxAccounts.Size = new System.Drawing.Size(213, 21);
            this.comboBoxAccounts.TabIndex = 1;
            this.comboBoxAccounts.SelectedIndexChanged += new System.EventHandler(this.comboBoxAccounts_SelectedIndexChanged);
            // 
            // textBoxAccountBalance
            // 
            this.textBoxAccountBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAccountBalance.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAccountBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAccountBalance.Location = new System.Drawing.Point(12, 42);
            this.textBoxAccountBalance.Name = "textBoxAccountBalance";
            this.textBoxAccountBalance.ReadOnly = true;
            this.textBoxAccountBalance.Size = new System.Drawing.Size(269, 29);
            this.textBoxAccountBalance.TabIndex = 2;
            this.textBoxAccountBalance.TabStop = false;
            this.textBoxAccountBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(206, 106);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // labelCreditLimit
            // 
            this.labelCreditLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCreditLimit.Location = new System.Drawing.Point(12, 74);
            this.labelCreditLimit.Name = "labelCreditLimit";
            this.labelCreditLimit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCreditLimit.Size = new System.Drawing.Size(269, 13);
            this.labelCreditLimit.TabIndex = 4;
            this.labelCreditLimit.Text = "<CreditLimit>";
            this.labelCreditLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AccountBalanceDialog
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(293, 141);
            this.Controls.Add(this.labelCreditLimit);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxAccountBalance);
            this.Controls.Add(this.comboBoxAccounts);
            this.Controls.Add(this.labelAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountBalanceDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Balance";
            this.Load += new System.EventHandler(this.AccountBalanceDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.ComboBox comboBoxAccounts;
        private System.Windows.Forms.TextBox textBoxAccountBalance;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelCreditLimit;
    }
}