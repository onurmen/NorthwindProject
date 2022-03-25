namespace NorthwindWindowsFormsApp
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnEmployess = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnShippers = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.LBL = new System.Windows.Forms.Label();
            this.bntExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.Brown;
            this.btnCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategories.Location = new System.Drawing.Point(12, 176);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(183, 43);
            this.btnCategories.TabIndex = 0;
            this.btnCategories.Text = "CATEGORİES";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Brown;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomers.Location = new System.Drawing.Point(213, 176);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(183, 43);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "CUSTOMERS";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEmployess
            // 
            this.btnEmployess.BackColor = System.Drawing.Color.Brown;
            this.btnEmployess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmployess.Location = new System.Drawing.Point(413, 176);
            this.btnEmployess.Name = "btnEmployess";
            this.btnEmployess.Size = new System.Drawing.Size(183, 43);
            this.btnEmployess.TabIndex = 2;
            this.btnEmployess.Text = "EMPLOYESS";
            this.btnEmployess.UseVisualStyleBackColor = false;
            this.btnEmployess.Click += new System.EventHandler(this.btnEmployess_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Brown;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProducts.Location = new System.Drawing.Point(610, 176);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(183, 43);
            this.btnProducts.TabIndex = 5;
            this.btnProducts.Text = "PRODUCTS";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnShippers
            // 
            this.btnShippers.BackColor = System.Drawing.Color.Brown;
            this.btnShippers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShippers.Location = new System.Drawing.Point(299, 307);
            this.btnShippers.Name = "btnShippers";
            this.btnShippers.Size = new System.Drawing.Size(183, 43);
            this.btnShippers.TabIndex = 4;
            this.btnShippers.Text = "SHİPPERS";
            this.btnShippers.UseVisualStyleBackColor = false;
            this.btnShippers.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.Brown;
            this.btnSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSuppliers.Location = new System.Drawing.Point(538, 307);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(183, 43);
            this.btnSuppliers.TabIndex = 3;
            this.btnSuppliers.Text = "SUPPLİERS";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.Brown;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrders.Location = new System.Drawing.Point(64, 307);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(183, 43);
            this.btnOrders.TabIndex = 6;
            this.btnOrders.Text = "ORDERS";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // LBL
            // 
            this.LBL.AutoSize = true;
            this.LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL.ForeColor = System.Drawing.Color.Brown;
            this.LBL.Location = new System.Drawing.Point(153, 54);
            this.LBL.Name = "LBL";
            this.LBL.Size = new System.Drawing.Size(459, 91);
            this.LBL.TabIndex = 7;
            this.LBL.Text = "WELCOME";
            // 
            // bntExit
            // 
            this.bntExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bntExit.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExit.Location = new System.Drawing.Point(666, 417);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(127, 30);
            this.bntExit.TabIndex = 8;
            this.bntExit.Text = "EXIT";
            this.bntExit.UseVisualStyleBackColor = false;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.LBL);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnShippers);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnEmployess);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnCategories);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnEmployess;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnShippers;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Label LBL;
        private System.Windows.Forms.Button bntExit;
    }
}

