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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertToolStripMenuItem,
            this.clipToolStripMenuItem});
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
            this.pLYToolStripMenuItem.Name = "pLYToolStripMenuItem";
            this.pLYToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pLYToolStripMenuItem.Text = "PLY File";
            this.pLYToolStripMenuItem.Click += new System.EventHandler(this.pLYToolStripMenuItem_Click);
            // 
            // oBJToolStripMenuItem
            // 
            this.oBJToolStripMenuItem.Name = "oBJToolStripMenuItem";
            this.oBJToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oBJToolStripMenuItem.Text = "PLY to OBJ";
            // 
            // pCDToolStripMenuItem1
            // 
            this.pCDToolStripMenuItem1.Name = "pCDToolStripMenuItem1";
            this.pCDToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.pCDToolStripMenuItem1.Text = "PLY to PCD";
            // 
            // rAWToolStripMenuItem
            // 
            this.rAWToolStripMenuItem.Name = "rAWToolStripMenuItem";
            this.rAWToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rAWToolStripMenuItem.Text = "PLY to RAW";
            // 
            // pCDToolStripMenuItem
            // 
            this.pCDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pLYToolStripMenuItem1,
            this.vTKToolStripMenuItem});
            this.pCDToolStripMenuItem.Name = "pCDToolStripMenuItem";
            this.pCDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pCDToolStripMenuItem.Text = "PCD File";
            // 
            // pLYToolStripMenuItem1
            // 
            this.pLYToolStripMenuItem1.Name = "pLYToolStripMenuItem1";
            this.pLYToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.pLYToolStripMenuItem1.Text = "PCD to PLY";
            this.pLYToolStripMenuItem1.Click += new System.EventHandler(this.pLYToolStripMenuItem1_Click);
            // 
            // vTKToolStripMenuItem
            // 
            this.vTKToolStripMenuItem.Name = "vTKToolStripMenuItem";
            this.vTKToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vTKToolStripMenuItem.Text = "PCD to VTK";
            // 
            // clipToolStripMenuItem
            // 
            this.clipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pCDFileToolStripMenuItem});
            this.clipToolStripMenuItem.Name = "clipToolStripMenuItem";
            this.clipToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.clipToolStripMenuItem.Text = "Clip";
            // 
            // pCDFileToolStripMenuItem
            // 
            this.pCDFileToolStripMenuItem.Name = "pCDFileToolStripMenuItem";
            this.pCDFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pCDFileToolStripMenuItem.Text = "PCD File";
            this.pCDFileToolStripMenuItem.Click += new System.EventHandler(this.pCDFileToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 367);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "pcl-gui";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

