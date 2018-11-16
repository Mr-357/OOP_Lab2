namespace OOP_Lab2
{
    partial class FormMain
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
            this.noveFormeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.josNestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formaStatistikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noveFormeToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // noveFormeToolStripMenuItem
            // 
            this.noveFormeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.noveFormeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nestoToolStripMenuItem,
            this.josNestoToolStripMenuItem,
            this.formaStatistikeToolStripMenuItem});
            this.noveFormeToolStripMenuItem.Name = "noveFormeToolStripMenuItem";
            this.noveFormeToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.noveFormeToolStripMenuItem.Text = "Nove forme";
            // 
            // nestoToolStripMenuItem
            // 
            this.nestoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.nestoToolStripMenuItem.Name = "nestoToolStripMenuItem";
            this.nestoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nestoToolStripMenuItem.Text = "Forma Generator";
            // 
            // josNestoToolStripMenuItem
            // 
            this.josNestoToolStripMenuItem.Name = "josNestoToolStripMenuItem";
            this.josNestoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.josNestoToolStripMenuItem.Text = "Forma Grafikon";
            // 
            // formaStatistikeToolStripMenuItem
            // 
            this.formaStatistikeToolStripMenuItem.Name = "formaStatistikeToolStripMenuItem";
            this.formaStatistikeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formaStatistikeToolStripMenuItem.Text = "Forma Statistike";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem noveFormeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem josNestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formaStatistikeToolStripMenuItem;
    }
}

