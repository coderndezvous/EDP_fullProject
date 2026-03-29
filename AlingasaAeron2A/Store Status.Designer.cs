namespace AlingasaAeron2A
{
    partial class frmStoreStatus
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
            this.lblStoreStatusForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStoreStatusForm
            // 
            this.lblStoreStatusForm.AutoSize = true;
            this.lblStoreStatusForm.Font = new System.Drawing.Font("Century", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreStatusForm.Location = new System.Drawing.Point(209, 9);
            this.lblStoreStatusForm.Name = "lblStoreStatusForm";
            this.lblStoreStatusForm.Size = new System.Drawing.Size(352, 44);
            this.lblStoreStatusForm.TabIndex = 1;
            this.lblStoreStatusForm.Text = "Store Status Form";
            // 
            // frmStoreStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStoreStatusForm);
            this.Name = "frmStoreStatus";
            this.Text = "frmStoreStatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStoreStatusForm;
    }
}