namespace NorthwindWindowsFormsApp
{
    partial class CategoriesMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesMenu));
            this.btnExit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCATName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCATID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(109, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 46);
            this.btnExit.TabIndex = 67;
            this.btnExit.Text = "RETURN MAİN MENU";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(179, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 35);
            this.button3.TabIndex = 64;
            this.button3.Text = "SAVE CATEGORY";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(-2, 361);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 35);
            this.btnUpdate.TabIndex = 65;
            this.btnUpdate.Text = "UPDATE CATEGORY";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCATName
            // 
            this.txtCATName.Location = new System.Drawing.Point(211, 281);
            this.txtCATName.Name = "txtCATName";
            this.txtCATName.Size = new System.Drawing.Size(210, 22);
            this.txtCATName.TabIndex = 74;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(211, 220);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(210, 22);
            this.txtDescription.TabIndex = 73;
            // 
            // txtCATID
            // 
            this.txtCATID.Location = new System.Drawing.Point(211, 156);
            this.txtCATID.Name = "txtCATID";
            this.txtCATID.Size = new System.Drawing.Size(210, 22);
            this.txtCATID.TabIndex = 72;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(438, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(768, 564);
            this.dataGridView1.TabIndex = 71;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(4, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 22);
            this.label3.TabIndex = 70;
            this.label3.Text = "CATEGORY NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 22);
            this.label2.TabIndex = 69;
            this.label2.Text = "DESCRIPTION:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 68;
            this.label1.Text = "CATEGORIES ID:";
            // 
            // CategoriesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1218, 605);
            this.Controls.Add(this.txtCATName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCATID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnUpdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CategoriesMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoriesMenu";
            this.Load += new System.EventHandler(this.CategoriesMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCATName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCATID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}