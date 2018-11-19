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
            this.menuForms = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFormGen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFormChart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFormStats = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFormChartT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFormChartP = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFormChartH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuForms});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuForms
            // 
            this.menuForms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuForms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFormGen,
            this.menuItemFormChart,
            this.menuItemFormStats});
            this.menuForms.Name = "menuForms";
            this.menuForms.Size = new System.Drawing.Size(82, 20);
            this.menuForms.Text = "Nove forme";
            // 
            // menuItemFormGen
            // 
            this.menuItemFormGen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuItemFormGen.Name = "menuItemFormGen";
            this.menuItemFormGen.Size = new System.Drawing.Size(180, 22);
            this.menuItemFormGen.Text = "Forma Generator";
            this.menuItemFormGen.Click += new System.EventHandler(this.menuItemFormGen_Click);
            // 
            // menuItemFormChart
            // 
            this.menuItemFormChart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFormChartT,
            this.menuItemFormChartP,
            this.menuItemFormChartH});
            this.menuItemFormChart.Name = "menuItemFormChart";
            this.menuItemFormChart.Size = new System.Drawing.Size(180, 22);
            this.menuItemFormChart.Text = "Forma Grafikon";
            this.menuItemFormChart.Click += new System.EventHandler(this.menuItemFormChart_Click);
            // 
            // menuItemFormStats
            // 
            this.menuItemFormStats.Name = "menuItemFormStats";
            this.menuItemFormStats.Size = new System.Drawing.Size(180, 22);
            this.menuItemFormStats.Text = "Forma Statistike";
            this.menuItemFormStats.Click += new System.EventHandler(this.menuItemFormStats_Click);
            // 
            // menuItemFormChartT
            // 
            this.menuItemFormChartT.Name = "menuItemFormChartT";
            this.menuItemFormChartT.Size = new System.Drawing.Size(180, 22);
            this.menuItemFormChartT.Text = "Temperatura";
            this.menuItemFormChartT.Click += new System.EventHandler(this.menuItemFormChartT_Click);
            // 
            // menuItemFormChartP
            // 
            this.menuItemFormChartP.Name = "menuItemFormChartP";
            this.menuItemFormChartP.Size = new System.Drawing.Size(180, 22);
            this.menuItemFormChartP.Text = "Pritisak";
            this.menuItemFormChartP.Click += new System.EventHandler(this.menuItemFormChartP_Click);
            // 
            // menuItemFormChartH
            // 
            this.menuItemFormChartH.Name = "menuItemFormChartH";
            this.menuItemFormChartH.Size = new System.Drawing.Size(180, 22);
            this.menuItemFormChartH.Text = "Vlaznost";
            this.menuItemFormChartH.Click += new System.EventHandler(this.menuItemFormChartH_Click);
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
        private System.Windows.Forms.ToolStripMenuItem menuForms;
        private System.Windows.Forms.ToolStripMenuItem menuItemFormGen;
        private System.Windows.Forms.ToolStripMenuItem menuItemFormChart;
        private System.Windows.Forms.ToolStripMenuItem menuItemFormStats;
        private System.Windows.Forms.ToolStripMenuItem menuItemFormChartT;
        private System.Windows.Forms.ToolStripMenuItem menuItemFormChartP;
        private System.Windows.Forms.ToolStripMenuItem menuItemFormChartH;
    }
}

