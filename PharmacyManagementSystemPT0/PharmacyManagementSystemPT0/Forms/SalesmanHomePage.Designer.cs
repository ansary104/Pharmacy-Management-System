namespace PharmacyManagementSystemPT0
{
    partial class SalesmanHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesmanHomePage));
            this.label1 = new System.Windows.Forms.Label();
            this.Billing = new System.Windows.Forms.Button();
            this.BillingDetails = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pharmacy Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Billing
            // 
            this.Billing.BackColor = System.Drawing.Color.Transparent;
            this.Billing.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billing.Location = new System.Drawing.Point(454, 126);
            this.Billing.Name = "Billing";
            this.Billing.Size = new System.Drawing.Size(170, 41);
            this.Billing.TabIndex = 2;
            this.Billing.Text = "Billing and Stock";
            this.Billing.UseVisualStyleBackColor = false;
            this.Billing.Click += new System.EventHandler(this.button1_Click);
            // 
            // BillingDetails
            // 
            this.BillingDetails.BackColor = System.Drawing.Color.Transparent;
            this.BillingDetails.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillingDetails.Location = new System.Drawing.Point(454, 199);
            this.BillingDetails.Name = "BillingDetails";
            this.BillingDetails.Size = new System.Drawing.Size(170, 41);
            this.BillingDetails.TabIndex = 3;
            this.BillingDetails.Text = "Billing Details";
            this.BillingDetails.UseVisualStyleBackColor = false;
            this.BillingDetails.Click += new System.EventHandler(this.BillingDetails_Click);
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.Transparent;
            this.LogOut.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.Location = new System.Drawing.Point(454, 276);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(149, 43);
            this.LogOut.TabIndex = 4;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Salesman Homepage";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PharmacyManagementSystemPT0.Properties.Resources.medicine_20;
            this.pictureBox1.Location = new System.Drawing.Point(23, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SalesmanHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(687, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.BillingDetails);
            this.Controls.Add(this.Billing);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesmanHomePage";
            this.Text = "Salesman HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Billing;
        private System.Windows.Forms.Button BillingDetails;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}