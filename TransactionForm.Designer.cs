namespace Marxian_Bank
{
    partial class TransactionForm
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
            this.btnAddAccount = new FontAwesome.Sharp.IconButton();
            this.txtAccNumber = new System.Windows.Forms.TextBox();
            this.txtAccName = new System.Windows.Forms.TextBox();
            this.txtAccBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditAccount = new FontAwesome.Sharp.IconButton();
            this.btnDeleteAccount = new FontAwesome.Sharp.IconButton();
            this.btnWithdraw = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCashInput = new System.Windows.Forms.TextBox();
            this.btnDeposit = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.btnAddAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(72)))), ((int)(((byte)(251)))));
            this.btnAddAccount.FlatAppearance.BorderSize = 2;
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.ForeColor = System.Drawing.Color.White;
            this.btnAddAccount.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnAddAccount.IconColor = System.Drawing.Color.Green;
            this.btnAddAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddAccount.IconSize = 40;
            this.btnAddAccount.Location = new System.Drawing.Point(12, 226);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(122, 56);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // txtAccNumber
            // 
            this.txtAccNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(72)))), ((int)(((byte)(251)))));
            this.txtAccNumber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNumber.Location = new System.Drawing.Point(188, 102);
            this.txtAccNumber.Multiline = true;
            this.txtAccNumber.Name = "txtAccNumber";
            this.txtAccNumber.Size = new System.Drawing.Size(204, 26);
            this.txtAccNumber.TabIndex = 1;
            this.txtAccNumber.TextChanged += new System.EventHandler(this.txtAccNumber_TextChanged);
            this.txtAccNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccNumber_KeyPress);
            // 
            // txtAccName
            // 
            this.txtAccName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(72)))), ((int)(((byte)(251)))));
            this.txtAccName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccName.Location = new System.Drawing.Point(188, 134);
            this.txtAccName.Multiline = true;
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(204, 26);
            this.txtAccName.TabIndex = 2;
            // 
            // txtAccBalance
            // 
            this.txtAccBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(72)))), ((int)(((byte)(251)))));
            this.txtAccBalance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccBalance.Location = new System.Drawing.Point(187, 166);
            this.txtAccBalance.Multiline = true;
            this.txtAccBalance.Name = "txtAccBalance";
            this.txtAccBalance.Size = new System.Drawing.Size(204, 26);
            this.txtAccBalance.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(72)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(22, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Account Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(72)))), ((int)(((byte)(251)))));
            this.label2.Location = new System.Drawing.Point(23, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Account Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(72)))), ((int)(((byte)(251)))));
            this.label3.Location = new System.Drawing.Point(23, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Account Balance:";
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.btnEditAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(72)))), ((int)(((byte)(251)))));
            this.btnEditAccount.FlatAppearance.BorderSize = 2;
            this.btnEditAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAccount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAccount.ForeColor = System.Drawing.Color.White;
            this.btnEditAccount.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditAccount.IconColor = System.Drawing.Color.Yellow;
            this.btnEditAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditAccount.IconSize = 40;
            this.btnEditAccount.Location = new System.Drawing.Point(146, 226);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(122, 56);
            this.btnEditAccount.TabIndex = 7;
            this.btnEditAccount.Text = "Edit Account";
            this.btnEditAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditAccount.UseVisualStyleBackColor = false;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.btnDeleteAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(72)))), ((int)(((byte)(251)))));
            this.btnDeleteAccount.FlatAppearance.BorderSize = 2;
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccount.IconChar = FontAwesome.Sharp.IconChar.TrashRestore;
            this.btnDeleteAccount.IconColor = System.Drawing.Color.Red;
            this.btnDeleteAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteAccount.IconSize = 40;
            this.btnDeleteAccount.Location = new System.Drawing.Point(280, 226);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(122, 56);
            this.btnDeleteAccount.TabIndex = 8;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.btnWithdraw.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(72)))), ((int)(((byte)(251)))));
            this.btnWithdraw.FlatAppearance.BorderSize = 2;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnWithdraw.IconColor = System.Drawing.Color.Orange;
            this.btnWithdraw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWithdraw.Location = new System.Drawing.Point(213, 119);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(142, 56);
            this.btnWithdraw.TabIndex = 9;
            this.btnWithdraw.Text = "Withdrawal";
            this.btnWithdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(72)))), ((int)(((byte)(251)))));
            this.label4.Location = new System.Drawing.Point(25, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Input Cash:";
            // 
            // txtCashInput
            // 
            this.txtCashInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(72)))), ((int)(((byte)(251)))));
            this.txtCashInput.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashInput.Location = new System.Drawing.Point(140, 60);
            this.txtCashInput.Multiline = true;
            this.txtCashInput.Name = "txtCashInput";
            this.txtCashInput.Size = new System.Drawing.Size(215, 26);
            this.txtCashInput.TabIndex = 10;
            this.txtCashInput.TextChanged += new System.EventHandler(this.txtCashInput_TextChanged);
            this.txtCashInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashInput_KeyPress);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.btnDeposit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(72)))), ((int)(((byte)(251)))));
            this.btnDeposit.FlatAppearance.BorderSize = 2;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.btnDeposit.IconColor = System.Drawing.Color.Blue;
            this.btnDeposit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeposit.Location = new System.Drawing.Point(30, 119);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(142, 56);
            this.btnDeposit.TabIndex = 12;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnDeleteAccount);
            this.panel1.Controls.Add(this.btnAddAccount);
            this.panel1.Controls.Add(this.txtAccNumber);
            this.panel1.Controls.Add(this.txtAccName);
            this.panel1.Controls.Add(this.txtAccBalance);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEditAccount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 294);
            this.panel1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(93, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Programmers Box ATM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.btnWithdraw);
            this.panel2.Controls.Add(this.txtCashInput);
            this.panel2.Controls.Add(this.btnDeposit);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(418, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 224);
            this.panel2.TabIndex = 14;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(72)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(841, 294);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAddAccount;
        private System.Windows.Forms.TextBox txtAccNumber;
        private System.Windows.Forms.TextBox txtAccName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnEditAccount;
        private FontAwesome.Sharp.IconButton btnDeleteAccount;
        private FontAwesome.Sharp.IconButton btnWithdraw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCashInput;
        private FontAwesome.Sharp.IconButton btnDeposit;
        public System.Windows.Forms.TextBox txtAccBalance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}

