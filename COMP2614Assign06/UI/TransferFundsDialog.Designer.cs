namespace COMP2614Assign06.UI
{
    partial class TransferFundsDialog
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
            this.labelFromAccount = new System.Windows.Forms.Label();
            this.comboBoxFromAccounts = new System.Windows.Forms.ComboBox();
            this.labelToAccount = new System.Windows.Forms.Label();
            this.comboBoxToAccounts = new System.Windows.Forms.ComboBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.errorProviderTransferFundsDialog = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTransferFundsDialog)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFromAccount
            // 
            this.labelFromAccount.AutoSize = true;
            this.labelFromAccount.Location = new System.Drawing.Point(12, 9);
            this.labelFromAccount.Name = "labelFromAccount";
            this.labelFromAccount.Size = new System.Drawing.Size(73, 13);
            this.labelFromAccount.TabIndex = 0;
            this.labelFromAccount.Text = "&From Account";
            // 
            // comboBoxFromAccounts
            // 
            this.comboBoxFromAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFromAccounts.FormattingEnabled = true;
            this.comboBoxFromAccounts.Location = new System.Drawing.Point(15, 25);
            this.comboBoxFromAccounts.Name = "comboBoxFromAccounts";
            this.comboBoxFromAccounts.Size = new System.Drawing.Size(160, 21);
            this.comboBoxFromAccounts.TabIndex = 1;
            this.comboBoxFromAccounts.SelectedIndexChanged += new System.EventHandler(this.comboBoxFromAccounts_SelectedIndexChanged);
            // 
            // labelToAccount
            // 
            this.labelToAccount.AutoSize = true;
            this.labelToAccount.Location = new System.Drawing.Point(223, 9);
            this.labelToAccount.Name = "labelToAccount";
            this.labelToAccount.Size = new System.Drawing.Size(63, 13);
            this.labelToAccount.TabIndex = 2;
            this.labelToAccount.Text = "&To Account";
            // 
            // comboBoxToAccounts
            // 
            this.comboBoxToAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxToAccounts.FormattingEnabled = true;
            this.comboBoxToAccounts.Location = new System.Drawing.Point(226, 25);
            this.comboBoxToAccounts.Name = "comboBoxToAccounts";
            this.comboBoxToAccounts.Size = new System.Drawing.Size(160, 21);
            this.comboBoxToAccounts.TabIndex = 3;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(12, 58);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(43, 13);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "&Amount";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(15, 74);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxAmount.Size = new System.Drawing.Size(111, 20);
            this.textBoxAmount.TabIndex = 5;
            this.textBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(354, 116);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(273, 116);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "Ok";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // errorProviderTransferFundsDialog
            // 
            this.errorProviderTransferFundsDialog.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderTransferFundsDialog.ContainerControl = this;
            // 
            // TransferFundsDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(441, 151);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.comboBoxToAccounts);
            this.Controls.Add(this.labelToAccount);
            this.Controls.Add(this.comboBoxFromAccounts);
            this.Controls.Add(this.labelFromAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransferFundsDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transfer Funds";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTransferFundsDialog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFromAccount;
        private System.Windows.Forms.ComboBox comboBoxFromAccounts;
        private System.Windows.Forms.Label labelToAccount;
        private System.Windows.Forms.ComboBox comboBoxToAccounts;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ErrorProvider errorProviderTransferFundsDialog;
    }
}