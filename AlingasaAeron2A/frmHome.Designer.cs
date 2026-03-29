namespace AlingasaAeron2A
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnStoreStatus = new System.Windows.Forms.Button();
            this.btnPricebook = new System.Windows.Forms.Button();
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnTimeClock = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(28, 580);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 57);
            this.button7.TabIndex = 2;
            this.button7.Text = "back";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 596);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hi, Marcielle Fernandez!";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnRegister, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPricebook, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnVendors, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnUsers, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTimeClock, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnStoreStatus, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(167, 122);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 400);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.Location = new System.Drawing.Point(3, 3);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(210, 194);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnStoreStatus
            // 
            this.btnStoreStatus.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnStoreStatus.Image")));
            this.btnStoreStatus.Location = new System.Drawing.Point(219, 3);
            this.btnStoreStatus.Name = "btnStoreStatus";
            this.btnStoreStatus.Size = new System.Drawing.Size(210, 194);
            this.btnStoreStatus.TabIndex = 1;
            this.btnStoreStatus.Text = "Store Status";
            this.btnStoreStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStoreStatus.UseVisualStyleBackColor = true;
            this.btnStoreStatus.Click += new System.EventHandler(this.btnStoreStatus_Click);
            // 
            // btnPricebook
            // 
            this.btnPricebook.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPricebook.Image = ((System.Drawing.Image)(resources.GetObject("btnPricebook.Image")));
            this.btnPricebook.Location = new System.Drawing.Point(435, 3);
            this.btnPricebook.Name = "btnPricebook";
            this.btnPricebook.Size = new System.Drawing.Size(210, 194);
            this.btnPricebook.TabIndex = 2;
            this.btnPricebook.Text = "Pricebook";
            this.btnPricebook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPricebook.UseVisualStyleBackColor = true;
            this.btnPricebook.Click += new System.EventHandler(this.btnPricebook_Click);
            // 
            // btnVendors
            // 
            this.btnVendors.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendors.Image = ((System.Drawing.Image)(resources.GetObject("btnVendors.Image")));
            this.btnVendors.Location = new System.Drawing.Point(3, 203);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Size = new System.Drawing.Size(210, 194);
            this.btnVendors.TabIndex = 3;
            this.btnVendors.Text = "Vendors";
            this.btnVendors.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVendors.UseVisualStyleBackColor = true;
            this.btnVendors.Click += new System.EventHandler(this.btnVendors_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.Location = new System.Drawing.Point(219, 203);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(210, 194);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnTimeClock
            // 
            this.btnTimeClock.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeClock.Image = ((System.Drawing.Image)(resources.GetObject("btnTimeClock.Image")));
            this.btnTimeClock.Location = new System.Drawing.Point(435, 203);
            this.btnTimeClock.Name = "btnTimeClock";
            this.btnTimeClock.Size = new System.Drawing.Size(210, 194);
            this.btnTimeClock.TabIndex = 5;
            this.btnTimeClock.Text = "Time Clock";
            this.btnTimeClock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimeClock.UseVisualStyleBackColor = true;
            this.btnTimeClock.Click += new System.EventHandler(this.btnTimeClock_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(977, 649);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label1);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnStoreStatus;
        private System.Windows.Forms.Button btnPricebook;
        private System.Windows.Forms.Button btnVendors;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnTimeClock;
    }
}