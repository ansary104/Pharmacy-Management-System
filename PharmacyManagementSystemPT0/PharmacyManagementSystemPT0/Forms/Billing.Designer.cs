namespace PharmacyManagementSystemPT0.Forms
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.StockInformation = new System.Windows.Forms.DataGridView();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MednameBox = new System.Windows.Forms.TextBox();
            this.MedquantityBox = new System.Windows.Forms.TextBox();
            this.Medname1Box = new System.Windows.Forms.TextBox();
            this.Medquantity1Box = new System.Windows.Forms.TextBox();
            this.Medname2Box = new System.Windows.Forms.TextBox();
            this.Medquantity2Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrescriptionIDBox = new System.Windows.Forms.TextBox();
            this.BillIDBox = new System.Windows.Forms.TextBox();
            this.SalesmanIDBox = new System.Windows.Forms.TextBox();
            this.TotalamountBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CustomerNameBox = new System.Windows.Forms.TextBox();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.MakeBill = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DoctorNameBox = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StockInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // StockInformation
            // 
            this.StockInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StockInformation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.StockInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockInformation.Location = new System.Drawing.Point(288, 67);
            this.StockInformation.Name = "StockInformation";
            this.StockInformation.Size = new System.Drawing.Size(532, 174);
            this.StockInformation.TabIndex = 0;
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(341, 270);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(268, 29);
            this.SearchBox.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.AliceBlue;
            this.Search.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(659, 256);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(89, 31);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Medicine";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MednameBox
            // 
            this.MednameBox.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MednameBox.Location = new System.Drawing.Point(27, 327);
            this.MednameBox.Multiline = true;
            this.MednameBox.Name = "MednameBox";
            this.MednameBox.Size = new System.Drawing.Size(120, 27);
            this.MednameBox.TabIndex = 4;
            this.MednameBox.TextChanged += new System.EventHandler(this.MednameBox_TextChanged);
            // 
            // MedquantityBox
            // 
            this.MedquantityBox.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedquantityBox.Location = new System.Drawing.Point(162, 327);
            this.MedquantityBox.Multiline = true;
            this.MedquantityBox.Name = "MedquantityBox";
            this.MedquantityBox.Size = new System.Drawing.Size(120, 27);
            this.MedquantityBox.TabIndex = 6;
            // 
            // Medname1Box
            // 
            this.Medname1Box.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medname1Box.Location = new System.Drawing.Point(26, 360);
            this.Medname1Box.Multiline = true;
            this.Medname1Box.Name = "Medname1Box";
            this.Medname1Box.Size = new System.Drawing.Size(120, 27);
            this.Medname1Box.TabIndex = 8;
            // 
            // Medquantity1Box
            // 
            this.Medquantity1Box.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medquantity1Box.Location = new System.Drawing.Point(162, 360);
            this.Medquantity1Box.Multiline = true;
            this.Medquantity1Box.Name = "Medquantity1Box";
            this.Medquantity1Box.Size = new System.Drawing.Size(120, 27);
            this.Medquantity1Box.TabIndex = 10;
            this.Medquantity1Box.TextChanged += new System.EventHandler(this.Medquantity1Box_TextChanged);
            // 
            // Medname2Box
            // 
            this.Medname2Box.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medname2Box.Location = new System.Drawing.Point(26, 393);
            this.Medname2Box.Multiline = true;
            this.Medname2Box.Name = "Medname2Box";
            this.Medname2Box.Size = new System.Drawing.Size(120, 27);
            this.Medname2Box.TabIndex = 12;
            // 
            // Medquantity2Box
            // 
            this.Medquantity2Box.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medquantity2Box.Location = new System.Drawing.Point(162, 393);
            this.Medquantity2Box.Multiline = true;
            this.Medquantity2Box.Name = "Medquantity2Box";
            this.Medquantity2Box.Size = new System.Drawing.Size(120, 27);
            this.Medquantity2Box.TabIndex = 14;
            this.Medquantity2Box.TextChanged += new System.EventHandler(this.Medquantity2Box_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Medicine Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Quantity";
            // 
            // PrescriptionIDBox
            // 
            this.PrescriptionIDBox.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrescriptionIDBox.Location = new System.Drawing.Point(162, 253);
            this.PrescriptionIDBox.Multiline = true;
            this.PrescriptionIDBox.Name = "PrescriptionIDBox";
            this.PrescriptionIDBox.Size = new System.Drawing.Size(120, 27);
            this.PrescriptionIDBox.TabIndex = 20;
            this.PrescriptionIDBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BillIDBox
            // 
            this.BillIDBox.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillIDBox.Location = new System.Drawing.Point(162, 67);
            this.BillIDBox.Multiline = true;
            this.BillIDBox.Name = "BillIDBox";
            this.BillIDBox.Size = new System.Drawing.Size(120, 27);
            this.BillIDBox.TabIndex = 21;
            this.BillIDBox.TextChanged += new System.EventHandler(this.BillIDBox_TextChanged);
            // 
            // SalesmanIDBox
            // 
            this.SalesmanIDBox.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesmanIDBox.Location = new System.Drawing.Point(162, 140);
            this.SalesmanIDBox.Multiline = true;
            this.SalesmanIDBox.Name = "SalesmanIDBox";
            this.SalesmanIDBox.Size = new System.Drawing.Size(120, 27);
            this.SalesmanIDBox.TabIndex = 22;
            this.SalesmanIDBox.TextChanged += new System.EventHandler(this.SalesmanIDBox_TextChanged);
            // 
            // TotalamountBox
            // 
            this.TotalamountBox.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalamountBox.Location = new System.Drawing.Point(341, 341);
            this.TotalamountBox.Multiline = true;
            this.TotalamountBox.Name = "TotalamountBox";
            this.TotalamountBox.Size = new System.Drawing.Size(166, 27);
            this.TotalamountBox.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "PrescriptionID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "BillingID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 22);
            this.label8.TabIndex = 26;
            this.label8.Text = "SalesmanID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(337, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 22);
            this.label9.TabIndex = 27;
            this.label9.Text = "TotalAmount";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 22);
            this.label10.TabIndex = 28;
            this.label10.Text = "CustomerName";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 22);
            this.label11.TabIndex = 29;
            this.label11.Text = "Date";
            // 
            // CustomerNameBox
            // 
            this.CustomerNameBox.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameBox.Location = new System.Drawing.Point(162, 178);
            this.CustomerNameBox.Multiline = true;
            this.CustomerNameBox.Name = "CustomerNameBox";
            this.CustomerNameBox.Size = new System.Drawing.Size(120, 27);
            this.CustomerNameBox.TabIndex = 30;
            // 
            // DateBox
            // 
            this.DateBox.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBox.Location = new System.Drawing.Point(162, 104);
            this.DateBox.Multiline = true;
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(120, 27);
            this.DateBox.TabIndex = 31;
            this.DateBox.TextChanged += new System.EventHandler(this.DateBox_TextChanged);
            // 
            // MakeBill
            // 
            this.MakeBill.BackColor = System.Drawing.Color.AliceBlue;
            this.MakeBill.Location = new System.Drawing.Point(341, 383);
            this.MakeBill.Name = "MakeBill";
            this.MakeBill.Size = new System.Drawing.Size(130, 37);
            this.MakeBill.TabIndex = 32;
            this.MakeBill.Text = "Make Bill";
            this.MakeBill.UseVisualStyleBackColor = false;
            this.MakeBill.Click += new System.EventHandler(this.MakeBill_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(203, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(334, 28);
            this.label13.TabIndex = 34;
            this.label13.Text = "Pharmacy Management System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "DoctorName";
            // 
            // DoctorNameBox
            // 
            this.DoctorNameBox.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorNameBox.Location = new System.Drawing.Point(162, 219);
            this.DoctorNameBox.Multiline = true;
            this.DoctorNameBox.Name = "DoctorNameBox";
            this.DoctorNameBox.Size = new System.Drawing.Size(120, 27);
            this.DoctorNameBox.TabIndex = 36;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.AliceBlue;
            this.Back.Location = new System.Drawing.Point(659, 383);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(89, 37);
            this.Back.TabIndex = 37;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.AliceBlue;
            this.Clear.Location = new System.Drawing.Point(539, 383);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(94, 37);
            this.Clear.TabIndex = 38;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Billing
            // 
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(832, 440);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.DoctorNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.MakeBill);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.CustomerNameBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalamountBox);
            this.Controls.Add(this.SalesmanIDBox);
            this.Controls.Add(this.BillIDBox);
            this.Controls.Add(this.PrescriptionIDBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Medquantity2Box);
            this.Controls.Add(this.Medname2Box);
            this.Controls.Add(this.Medquantity1Box);
            this.Controls.Add(this.Medname1Box);
            this.Controls.Add(this.MedquantityBox);
            this.Controls.Add(this.MednameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.StockInformation);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Billing";
            this.Text = "Billing";
            ((System.ComponentModel.ISupportInitialize)(this.StockInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StockInfo;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.DataGridView StockInformation;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MednameBox;
        private System.Windows.Forms.TextBox MedquantityBox;
        private System.Windows.Forms.TextBox Medname1Box;
        private System.Windows.Forms.TextBox Medquantity1Box;
        private System.Windows.Forms.TextBox Medname2Box;
        private System.Windows.Forms.TextBox Medquantity2Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrescriptionIDBox;
        private System.Windows.Forms.TextBox BillIDBox;
        private System.Windows.Forms.TextBox SalesmanIDBox;
        private System.Windows.Forms.TextBox TotalamountBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CustomerNameBox;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Button MakeBill;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DoctorNameBox;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Clear;
    }
}