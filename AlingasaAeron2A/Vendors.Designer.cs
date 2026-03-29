namespace AlingasaAeron2A
{
    partial class frmVendors
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
            this.lblvendorsForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblvendorsForm
            // 
            this.lblvendorsForm.AutoSize = true;
            this.lblvendorsForm.Font = new System.Drawing.Font("Century", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvendorsForm.Location = new System.Drawing.Point(256, 9);
            this.lblvendorsForm.Name = "lblvendorsForm";
            this.lblvendorsForm.Size = new System.Drawing.Size(276, 44);
            this.lblvendorsForm.TabIndex = 3;
            this.lblvendorsForm.Text = "Vendors Form";
            // 
            // frmVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblvendorsForm);
            this.Name = "frmVendors";
            this.Text = "frmVendors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvendorsForm;
    }
}