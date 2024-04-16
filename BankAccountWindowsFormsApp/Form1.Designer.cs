namespace BankAccountWindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Deposit = new System.Windows.Forms.Button();
            this.Withdraw = new System.Windows.Forms.Button();
            this.BankAccount1button = new System.Windows.Forms.Button();
            this.BankAccount2button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ba1label = new System.Windows.Forms.Label();
            this.ba2label = new System.Windows.Forms.Label();
            this.ba1textBox = new System.Windows.Forms.TextBox();
            this.ba2textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Deposit
            // 
            this.Deposit.Location = new System.Drawing.Point(123, 145);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(112, 34);
            this.Deposit.TabIndex = 0;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = true;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // Withdraw
            // 
            this.Withdraw.Location = new System.Drawing.Point(254, 145);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(112, 34);
            this.Withdraw.TabIndex = 1;
            this.Withdraw.Text = "Withdraw";
            this.Withdraw.UseVisualStyleBackColor = true;
            this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // BankAccount1button
            // 
            this.BankAccount1button.Location = new System.Drawing.Point(85, 197);
            this.BankAccount1button.Name = "BankAccount1button";
            this.BankAccount1button.Size = new System.Drawing.Size(150, 34);
            this.BankAccount1button.TabIndex = 2;
            this.BankAccount1button.Text = "BankAccount1";
            this.BankAccount1button.UseVisualStyleBackColor = true;
            this.BankAccount1button.Click += new System.EventHandler(this.BankAccount1button_Click);
            // 
            // BankAccount2button
            // 
            this.BankAccount2button.Location = new System.Drawing.Point(254, 197);
            this.BankAccount2button.Name = "BankAccount2button";
            this.BankAccount2button.Size = new System.Drawing.Size(135, 34);
            this.BankAccount2button.TabIndex = 3;
            this.BankAccount2button.Text = "BankAccount2";
            this.BankAccount2button.UseVisualStyleBackColor = true;
            this.BankAccount2button.Click += new System.EventHandler(this.BankAccount2button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // ba1label
            // 
            this.ba1label.AutoSize = true;
            this.ba1label.Location = new System.Drawing.Point(589, 101);
            this.ba1label.Name = "ba1label";
            this.ba1label.Size = new System.Drawing.Size(125, 25);
            this.ba1label.TabIndex = 6;
            this.ba1label.Text = "BankAccount1";
            // 
            // ba2label
            // 
            this.ba2label.AutoSize = true;
            this.ba2label.Location = new System.Drawing.Point(589, 184);
            this.ba2label.Name = "ba2label";
            this.ba2label.Size = new System.Drawing.Size(125, 25);
            this.ba2label.TabIndex = 7;
            this.ba2label.Text = "BankAccount2";
            // 
            // ba1textBox
            // 
            this.ba1textBox.Location = new System.Drawing.Point(589, 129);
            this.ba1textBox.Name = "ba1textBox";
            this.ba1textBox.Size = new System.Drawing.Size(150, 31);
            this.ba1textBox.TabIndex = 8;
            // 
            // ba2textBox
            // 
            this.ba2textBox.Location = new System.Drawing.Point(589, 212);
            this.ba2textBox.Name = "ba2textBox";
            this.ba2textBox.Size = new System.Drawing.Size(150, 31);
            this.ba2textBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ba2textBox);
            this.Controls.Add(this.ba1textBox);
            this.Controls.Add(this.ba2label);
            this.Controls.Add(this.ba1label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BankAccount2button);
            this.Controls.Add(this.BankAccount1button);
            this.Controls.Add(this.Withdraw);
            this.Controls.Add(this.Deposit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Deposit;
        private Button Withdraw;
        private Button BankAccount1button;
        private Button BankAccount2button;
        private TextBox textBox1;
        private Label label1;
        private Label ba1label;
        private Label ba2label;
        private TextBox ba1textBox;
        private TextBox ba2textBox;
    }
}