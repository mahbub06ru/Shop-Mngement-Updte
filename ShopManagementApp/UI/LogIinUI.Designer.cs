namespace ShopManagementApp.UI
{
    partial class LogIinUI
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
            this.loginSubmitButton = new System.Windows.Forms.Button();
            this.enterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.enterUserNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginSubmitButton
            // 
            this.loginSubmitButton.Location = new System.Drawing.Point(98, 134);
            this.loginSubmitButton.Name = "loginSubmitButton";
            this.loginSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.loginSubmitButton.TabIndex = 11;
            this.loginSubmitButton.Text = "Submit";
            this.loginSubmitButton.UseVisualStyleBackColor = true;
            this.loginSubmitButton.Click += new System.EventHandler(this.loginSubmitButton_Click);
            // 
            // enterPasswordTextBox
            // 
            this.enterPasswordTextBox.Location = new System.Drawing.Point(126, 97);
            this.enterPasswordTextBox.Name = "enterPasswordTextBox";
            this.enterPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.enterPasswordTextBox.TabIndex = 9;
            // 
            // enterUserNameTextBox
            // 
            this.enterUserNameTextBox.Location = new System.Drawing.Point(126, 67);
            this.enterUserNameTextBox.Name = "enterUserNameTextBox";
            this.enterUserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.enterUserNameTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Log In";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter User Name";
            // 
            // LogIinUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.loginSubmitButton);
            this.Controls.Add(this.enterPasswordTextBox);
            this.Controls.Add(this.enterUserNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LogIinUI";
            this.Text = "LogIinUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginSubmitButton;
        private System.Windows.Forms.TextBox enterPasswordTextBox;
        private System.Windows.Forms.TextBox enterUserNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}