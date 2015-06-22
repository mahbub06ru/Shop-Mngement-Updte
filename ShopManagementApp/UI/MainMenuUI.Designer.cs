namespace ShopManagementApp
{
    partial class MenuUI
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
            this.transactionButton = new System.Windows.Forms.Button();
            this.inventoryEntryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enterUserNameTextBox = new System.Windows.Forms.TextBox();
            this.enterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transactionButton
            // 
            this.transactionButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.transactionButton.Location = new System.Drawing.Point(179, 332);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.Size = new System.Drawing.Size(126, 63);
            this.transactionButton.TabIndex = 1;
            this.transactionButton.Text = "Transaction Management";
            this.transactionButton.UseVisualStyleBackColor = false;
            this.transactionButton.Click += new System.EventHandler(this.transactionButton_Click);
            // 
            // inventoryEntryButton
            // 
            this.inventoryEntryButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.inventoryEntryButton.Location = new System.Drawing.Point(31, 332);
            this.inventoryEntryButton.Name = "inventoryEntryButton";
            this.inventoryEntryButton.Size = new System.Drawing.Size(126, 63);
            this.inventoryEntryButton.TabIndex = 2;
            this.inventoryEntryButton.Text = "Products Entry";
            this.inventoryEntryButton.UseVisualStyleBackColor = false;
            this.inventoryEntryButton.Click += new System.EventHandler(this.inventoryEntryButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sign In";
            // 
            // enterUserNameTextBox
            // 
            this.enterUserNameTextBox.Location = new System.Drawing.Point(153, 80);
            this.enterUserNameTextBox.Name = "enterUserNameTextBox";
            this.enterUserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.enterUserNameTextBox.TabIndex = 4;
            // 
            // enterPasswordTextBox
            // 
            this.enterPasswordTextBox.Location = new System.Drawing.Point(153, 110);
            this.enterPasswordTextBox.Name = "enterPasswordTextBox";
            this.enterPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.enterPasswordTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Password";
            // 
            // loginSubmitButton
            // 
            this.loginSubmitButton.Location = new System.Drawing.Point(125, 147);
            this.loginSubmitButton.Name = "loginSubmitButton";
            this.loginSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.loginSubmitButton.TabIndex = 5;
            this.loginSubmitButton.Text = "button1";
            this.loginSubmitButton.UseVisualStyleBackColor = true;
            // 
            // MenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 445);
            this.Controls.Add(this.loginSubmitButton);
            this.Controls.Add(this.enterPasswordTextBox);
            this.Controls.Add(this.enterUserNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transactionButton);
            this.Controls.Add(this.inventoryEntryButton);
            this.Name = "MenuUI";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transactionButton;
        private System.Windows.Forms.Button inventoryEntryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox enterUserNameTextBox;
        private System.Windows.Forms.TextBox enterPasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginSubmitButton;

    }
}

