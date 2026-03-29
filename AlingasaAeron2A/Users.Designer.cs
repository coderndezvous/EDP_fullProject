namespace AlingasaAeron2A
{
    partial class frmUsers
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
            this.lblUsersForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsersForm
            // 
            this.lblUsersForm.AutoSize = true;
            this.lblUsersForm.Font = new System.Drawing.Font("Century", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersForm.Location = new System.Drawing.Point(252, 9);
            this.lblUsersForm.Name = "lblUsersForm";
            this.lblUsersForm.Size = new System.Drawing.Size(231, 44);
            this.lblUsersForm.TabIndex = 4;
            this.lblUsersForm.Text = "Users Form";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUsersForm);
            this.Name = "frmUsers";
            this.Text = "frmUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsersForm;
    }
}