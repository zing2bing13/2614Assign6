namespace COMP2614Assign06.UI
{
    partial class TransactionHistoryDialog
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
            this.checkBoxShowDetails = new System.Windows.Forms.CheckBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxTransactionHistory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxShowDetails
            // 
            this.checkBoxShowDetails.AutoSize = true;
            this.checkBoxShowDetails.Location = new System.Drawing.Point(12, 481);
            this.checkBoxShowDetails.Name = "checkBoxShowDetails";
            this.checkBoxShowDetails.Size = new System.Drawing.Size(88, 17);
            this.checkBoxShowDetails.TabIndex = 2;
            this.checkBoxShowDetails.Text = "Show &Details";
            this.checkBoxShowDetails.UseVisualStyleBackColor = true;
            this.checkBoxShowDetails.CheckedChanged += new System.EventHandler(this.checkBoxShowDetails_CheckedChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(333, 477);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // textBoxTransactionHistory
            // 
            this.textBoxTransactionHistory.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTransactionHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTransactionHistory.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTransactionHistory.Location = new System.Drawing.Point(0, 0);
            this.textBoxTransactionHistory.Multiline = true;
            this.textBoxTransactionHistory.Name = "textBoxTransactionHistory";
            this.textBoxTransactionHistory.ReadOnly = true;
            this.textBoxTransactionHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTransactionHistory.Size = new System.Drawing.Size(420, 438);
            this.textBoxTransactionHistory.TabIndex = 1;
            // 
            // TransactionHistoryDialog
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(420, 510);
            this.Controls.Add(this.textBoxTransactionHistory);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.checkBoxShowDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransactionHistoryDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transaction History";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxShowDetails;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxTransactionHistory;
    }
}