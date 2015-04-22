namespace pcl_gui
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oBJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rAWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLYToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vTKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCDFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCDFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lICENSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rEADMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertToolStripMenuItem,
            this.clipToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pLYToolStripMenuItem,
            this.pCDToolStripMenuItem});
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.convertToolStripMenuItem.Text = "Convert";
            // 
            // pLYToolStripMenuItem
            // 
            this.pLYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oBJToolStripMenuItem,
            this.pCDToolStripMenuItem1,
            this.rAWToolStripMenuItem});
            this.pLYToolStripMenuItem.Image = global::pcl_gui.Properties.Resources.link1;
            this.pLYToolStripMenuItem.Name = "pLYToolStripMenuItem";
            this.pLYToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pLYToolStripMenuItem.Text = "PLY File";
            this.pLYToolStripMenuItem.Click += new System.EventHandler(this.pLYToolStripMenuItem_Click);
            // 
            // oBJToolStripMenuItem
            // 
            this.oBJToolStripMenuItem.Image = global::pcl_gui.Properties.Resources.link1;
            this.oBJToolStripMenuItem.Name = "oBJToolStripMenuItem";
            this.oBJToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oBJToolStripMenuItem.Text = "PLY to OBJ";
            this.oBJToolStripMenuItem.Click += new System.EventHandler(this.oBJToolStripMenuItem_Click);
            // 
            // pCDToolStripMenuItem1
            // 
            this.pCDToolStripMenuItem1.Image = global::pcl_gui.Properties.Resources.link1;
            this.pCDToolStripMenuItem1.Name = "pCDToolStripMenuItem1";
            this.pCDToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.pCDToolStripMenuItem1.Text = "PLY to PCD";
            this.pCDToolStripMenuItem1.Click += new System.EventHandler(this.pCDToolStripMenuItem1_Click);
            // 
            // rAWToolStripMenuItem
            // 
            this.rAWToolStripMenuItem.Image = global::pcl_gui.Properties.Resources.link1;
            this.rAWToolStripMenuItem.Name = "rAWToolStripMenuItem";
            this.rAWToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rAWToolStripMenuItem.Text = "PLY to RAW";
            this.rAWToolStripMenuItem.Click += new System.EventHandler(this.rAWToolStripMenuItem_Click);
            // 
            // pCDToolStripMenuItem
            // 
            this.pCDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pLYToolStripMenuItem1,
            this.vTKToolStripMenuItem});
            this.pCDToolStripMenuItem.Image = global::pcl_gui.Properties.Resources.link1;
            this.pCDToolStripMenuItem.Name = "pCDToolStripMenuItem";
            this.pCDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pCDToolStripMenuItem.Text = "PCD File";
            // 
            // pLYToolStripMenuItem1
            // 
            this.pLYToolStripMenuItem1.Image = global::pcl_gui.Properties.Resources.link1;
            this.pLYToolStripMenuItem1.Name = "pLYToolStripMenuItem1";
            this.pLYToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.pLYToolStripMenuItem1.Text = "PCD to PLY";
            this.pLYToolStripMenuItem1.Click += new System.EventHandler(this.pLYToolStripMenuItem1_Click);
            // 
            // vTKToolStripMenuItem
            // 
            this.vTKToolStripMenuItem.Image = global::pcl_gui.Properties.Resources.link1;
            this.vTKToolStripMenuItem.Name = "vTKToolStripMenuItem";
            this.vTKToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vTKToolStripMenuItem.Text = "PCD to VTK";
            this.vTKToolStripMenuItem.Click += new System.EventHandler(this.vTKToolStripMenuItem_Click);
            // 
            // clipToolStripMenuItem
            // 
            this.clipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pCDFileToolStripMenuItem});
            this.clipToolStripMenuItem.Name = "clipToolStripMenuItem";
            this.clipToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.clipToolStripMenuItem.Text = "Edit";
            // 
            // pCDFileToolStripMenuItem
            // 
            this.pCDFileToolStripMenuItem.Image = global::pcl_gui.Properties.Resources.link1;
            this.pCDFileToolStripMenuItem.Name = "pCDFileToolStripMenuItem";
            this.pCDFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pCDFileToolStripMenuItem.Text = "Clip PCD file";
            this.pCDFileToolStripMenuItem.Click += new System.EventHandler(this.pCDFileToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 345);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(530, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(174, 17);
            this.toolStripStatusLabel1.Text = "GUI for pcl console applications";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pCDFileToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // pCDFileToolStripMenuItem1
            // 
            this.pCDFileToolStripMenuItem1.Image = global::pcl_gui.Properties.Resources.link1;
            this.pCDFileToolStripMenuItem1.Name = "pCDFileToolStripMenuItem1";
            this.pCDFileToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.pCDFileToolStripMenuItem1.Text = "PCD file";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEADMEToolStripMenuItem,
            this.lICENSEToolStripMenuItem,
            this.githubToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // lICENSEToolStripMenuItem
            // 
            this.lICENSEToolStripMenuItem.Image = global::pcl_gui.Properties.Resources.link1;
            this.lICENSEToolStripMenuItem.Name = "lICENSEToolStripMenuItem";
            this.lICENSEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lICENSEToolStripMenuItem.Text = "License";
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Image = global::pcl_gui.Properties.Resources.link1;
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.githubToolStripMenuItem.Text = "Github";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(341, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "Ready";
            // 
            // rEADMEToolStripMenuItem
            // 
            this.rEADMEToolStripMenuItem.Image = global::pcl_gui.Properties.Resources.link1;
            this.rEADMEToolStripMenuItem.Name = "rEADMEToolStripMenuItem";
            this.rEADMEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rEADMEToolStripMenuItem.Text = "Read me";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(530, 367);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pcl-gui";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oBJToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pCDToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rAWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pCDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLYToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vTKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pCDFileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pCDFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEADMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lICENSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

