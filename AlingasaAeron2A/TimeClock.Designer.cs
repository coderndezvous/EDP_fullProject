namespace AlingasaAeron2A
{
    partial class frmTimeClock
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
            this.lblTimeClockForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTimeClockForm
            // 
            this.lblTimeClockForm.AutoSize = true;
            this.lblTimeClockForm.Font = new System.Drawing.Font("Century", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeClockForm.Location = new System.Drawing.Point(213, 9);
            this.lblTimeClockForm.Name = "lblTimeClockForm";
            this.lblTimeClockForm.Size = new System.Drawing.Size(332, 44);
            this.lblTimeClockForm.TabIndex = 5;
            this.lblTimeClockForm.Text = "Time Clock Form";
            // 
            // frmTimeClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimeClockForm);
            this.Name = "frmTimeClock";
            this.Text = "frmTimeClock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeClockForm;
    }
}