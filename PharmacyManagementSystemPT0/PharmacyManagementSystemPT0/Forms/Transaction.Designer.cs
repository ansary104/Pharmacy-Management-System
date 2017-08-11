namespace PharmacyManagementSystemPT0.Forms
{
    partial class Transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RevenueBox = new System.Windows.Forms.TextBox();
            this.ExpenseBox = new System.Windows.Forms.TextBox();
            this.MonthYearBox = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.TransactionInfo = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.ProfitBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pharmacy Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Month & Year";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monthly Revenue";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monthly Expense";
            // 
            // RevenueBox
            // 
            this.RevenueBox.Location = new System.Drawing.Point(166, 116);
            this.RevenueBox.Multiline = true;
            this.RevenueBox.Name = "RevenueBox";
            this.RevenueBox.Size = new System.Drawing.Size(181, 31);
            this.RevenueBox.TabIndex = 5;
            // 
            // ExpenseBox
            // 
            this.ExpenseBox.Location = new System.Drawing.Point(166, 161);
            this.ExpenseBox.Multiline = true;
            this.ExpenseBox.Name = "ExpenseBox";
            this.ExpenseBox.Size = new System.Drawing.Size(181, 31);
            this.ExpenseBox.TabIndex = 6;
            // 
            // MonthYearBox
            // 
            this.MonthYearBox.Location = new System.Drawing.Point(166, 77);
            this.MonthYearBox.Multiline = true;
            this.MonthYearBox.Name = "MonthYearBox";
            this.MonthYearBox.Size = new System.Drawing.Size(181, 31);
            this.MonthYearBox.TabIndex = 8;
            this.MonthYearBox.TextChanged += new System.EventHandler(this.MonthYearBox_TextChanged);
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.DarkGray;
            this.Create.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Create.Location = new System.Drawing.Point(19, 263);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(95, 36);
            this.Create.TabIndex = 9;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.DarkGray;
            this.Update.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Update.Location = new System.Drawing.Point(145, 263);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(88, 36);
            this.Update.TabIndex = 10;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.DarkGray;
            this.Delete.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete.Location = new System.Drawing.Point(254, 263);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(93, 36);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Search By Month and Year";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(366, 314);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(219, 31);
            this.SearchBox.TabIndex = 13;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.DarkGray;
            this.Back.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back.Location = new System.Drawing.Point(19, 314);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(95, 36);
            this.Back.TabIndex = 14;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.DarkGray;
            this.Search.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Search.Location = new System.Drawing.Point(613, 309);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(79, 36);
            this.Search.TabIndex = 15;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.DarkGray;
            this.Clear.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear.Location = new System.Drawing.Point(145, 314);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(88, 36);
            this.Clear.TabIndex = 16;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // TransactionInfo
            // 
            this.TransactionInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionInfo.Location = new System.Drawing.Point(353, 77);
            this.TransactionInfo.Name = "TransactionInfo";
            this.TransactionInfo.Size = new System.Drawing.Size(339, 181);
            this.TransactionInfo.TabIndex = 17;
            this.TransactionInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionInfo_CellContentClick);
            this.TransactionInfo.SelectionChanged += new System.EventHandler(this.TransactionInfo_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Profit";
            // 
            // ProfitBox
            // 
            this.ProfitBox.Location = new System.Drawing.Point(166, 204);
            this.ProfitBox.Multiline = true;
            this.ProfitBox.Name = "ProfitBox";
            this.ProfitBox.Size = new System.Drawing.Size(181, 31);
            this.ProfitBox.TabIndex = 19;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(704, 373);
            this.Controls.Add(this.ProfitBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TransactionInfo);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.MonthYearBox);
            this.Controls.Add(this.ExpenseBox);
            this.Controls.Add(this.RevenueBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Transaction";
            this.Text = "Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.TransactionInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RevenueBox;
        private System.Windows.Forms.TextBox ExpenseBox;
        private System.Windows.Forms.TextBox MonthYearBox;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.DataGridView TransactionInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProfitBox;
    }
}