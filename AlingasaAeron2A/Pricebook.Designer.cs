namespace AlingasaAeron2A
{
    partial class frmPricebook
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
            this.lblPricebookForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPricebookForm
            // 
            this.lblPricebookForm.AutoSize = true;
            this.lblPricebookForm.Font = new System.Drawing.Font("Century", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricebookForm.Location = new System.Drawing.Point(236, 9);
            this.lblPricebookForm.Name = "lblPricebookForm";
            this.lblPricebookForm.Size = new System.Drawing.Size(305, 44);
            this.lblPricebookForm.TabIndex = 2;
            this.lblPricebookForm.Text = "Pricebook Form";
            // 
            // frmPricebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPricebookForm);
            this.Name = "frmPricebook";
            this.Text = "frmPricebook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPricebookForm;
    }
}