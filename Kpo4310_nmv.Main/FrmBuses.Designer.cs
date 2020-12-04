namespace Kpo4310_nmv.Main
{
    partial class FrmBuses
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
            this.txtBoxBuses = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxBuses
            // 
            this.txtBoxBuses.Location = new System.Drawing.Point(83, 160);
            this.txtBoxBuses.Multiline = true;
            this.txtBoxBuses.Name = "txtBoxBuses";
            this.txtBoxBuses.Size = new System.Drawing.Size(498, 20);
            this.txtBoxBuses.TabIndex = 0;
            // 
            // FrmBuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxBuses);
            this.Name = "FrmBuses";
            this.Text = "FrmBuses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxBuses;
    }
}