namespace Kpo4310_nmv.Main
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
            this.MMenu = new System.Windows.Forms.MenuStrip();
            this.mmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mmBuses = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpenBuses = new System.Windows.Forms.ToolStripMenuItem();
            this.SStatus = new System.Windows.Forms.StatusStrip();
            this.dgvBuses = new System.Windows.Forms.DataGridView();
            this.MMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuses)).BeginInit();
            this.SuspendLayout();
            // 
            // MMenu
            // 
            this.MMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmMenu,
            this.mmBuses});
            this.MMenu.Location = new System.Drawing.Point(0, 0);
            this.MMenu.Name = "MMenu";
            this.MMenu.Size = new System.Drawing.Size(800, 24);
            this.MMenu.TabIndex = 0;
            this.MMenu.Text = "menuStrip1";
            this.MMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mmMenu
            // 
            this.mmMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnExit,
            this.mnOpen});
            this.mmMenu.Name = "mmMenu";
            this.mmMenu.Size = new System.Drawing.Size(48, 20);
            this.mmMenu.Text = "Файл";
            this.mmMenu.Click += new System.EventHandler(this.mmBuses_Click);
            // 
            // mnExit
            // 
            this.mnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(121, 22);
            this.mnExit.Text = "Выход";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // mnOpen
            // 
            this.mnOpen.Name = "mnOpen";
            this.mnOpen.Size = new System.Drawing.Size(121, 22);
            this.mnOpen.Text = "Открыть";
            this.mnOpen.Click += new System.EventHandler(this.mnOpen_Click);
            // 
            // mmBuses
            // 
            this.mmBuses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnOpenBuses});
            this.mmBuses.Name = "mmBuses";
            this.mmBuses.Size = new System.Drawing.Size(73, 20);
            this.mmBuses.Text = "Автобусы";
            // 
            // mnOpenBuses
            // 
            this.mnOpenBuses.Name = "mnOpenBuses";
            this.mnOpenBuses.Size = new System.Drawing.Size(240, 22);
            this.mnOpenBuses.Text = "Открыть данные об автобусах";
            this.mnOpenBuses.Click += new System.EventHandler(this.mnOpenBuses_Click);
            // 
            // SStatus
            // 
            this.SStatus.Location = new System.Drawing.Point(0, 428);
            this.SStatus.Name = "SStatus";
            this.SStatus.Size = new System.Drawing.Size(800, 22);
            this.SStatus.TabIndex = 1;
            this.SStatus.Text = "statusStrip1";
            // 
            // dgvBuses
            // 
            this.dgvBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuses.Location = new System.Drawing.Point(12, 36);
            this.dgvBuses.Name = "dgvBuses";
            this.dgvBuses.Size = new System.Drawing.Size(776, 175);
            this.dgvBuses.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBuses);
            this.Controls.Add(this.SStatus);
            this.Controls.Add(this.MMenu);
            this.MainMenuStrip = this.MMenu;
            this.Name = "FrmMain";
            this.Text = "КПО:4310:Вдовичев";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MMenu.ResumeLayout(false);
            this.MMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MMenu;
        private System.Windows.Forms.ToolStripMenuItem mmMenu;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.ToolStripMenuItem mnOpen;
        private System.Windows.Forms.StatusStrip SStatus;
        private System.Windows.Forms.DataGridView dgvBuses;
        private System.Windows.Forms.ToolStripMenuItem mmBuses;
        private System.Windows.Forms.ToolStripMenuItem mnOpenBuses;
    }
}

