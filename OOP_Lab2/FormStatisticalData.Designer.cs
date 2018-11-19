namespace OOP_Lab2
{
    partial class FormStatisticalData
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxTemp = new System.Windows.Forms.TextBox();
            this.tBoxPressure = new System.Windows.Forms.TextBox();
            this.tBoxHumidity = new System.Windows.Forms.TextBox();
            this.lblStatsTemp = new System.Windows.Forms.Label();
            this.lblStatsPressure = new System.Windows.Forms.Label();
            this.lblStatsHumidity = new System.Windows.Forms.Label();
            this.chBoxStatN = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pritisak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vlaznost";
            // 
            // tBoxTemp
            // 
            this.tBoxTemp.Location = new System.Drawing.Point(104, 21);
            this.tBoxTemp.Name = "tBoxTemp";
            this.tBoxTemp.Size = new System.Drawing.Size(100, 20);
            this.tBoxTemp.TabIndex = 3;
            // 
            // tBoxPressure
            // 
            this.tBoxPressure.Location = new System.Drawing.Point(104, 61);
            this.tBoxPressure.Name = "tBoxPressure";
            this.tBoxPressure.Size = new System.Drawing.Size(100, 20);
            this.tBoxPressure.TabIndex = 4;
            // 
            // tBoxHumidity
            // 
            this.tBoxHumidity.Location = new System.Drawing.Point(104, 103);
            this.tBoxHumidity.Name = "tBoxHumidity";
            this.tBoxHumidity.Size = new System.Drawing.Size(100, 20);
            this.tBoxHumidity.TabIndex = 5;
            // 
            // lblStatsTemp
            // 
            this.lblStatsTemp.AutoSize = true;
            this.lblStatsTemp.Location = new System.Drawing.Point(248, 24);
            this.lblStatsTemp.Name = "lblStatsTemp";
            this.lblStatsTemp.Size = new System.Drawing.Size(0, 13);
            this.lblStatsTemp.TabIndex = 6;
            // 
            // lblStatsPressure
            // 
            this.lblStatsPressure.AutoSize = true;
            this.lblStatsPressure.Location = new System.Drawing.Point(248, 64);
            this.lblStatsPressure.Name = "lblStatsPressure";
            this.lblStatsPressure.Size = new System.Drawing.Size(0, 13);
            this.lblStatsPressure.TabIndex = 7;
            // 
            // lblStatsHumidity
            // 
            this.lblStatsHumidity.AutoSize = true;
            this.lblStatsHumidity.Location = new System.Drawing.Point(248, 106);
            this.lblStatsHumidity.Name = "lblStatsHumidity";
            this.lblStatsHumidity.Size = new System.Drawing.Size(0, 13);
            this.lblStatsHumidity.TabIndex = 8;
            // 
            // chBoxStatN
            // 
            this.chBoxStatN.AutoSize = true;
            this.chBoxStatN.Location = new System.Drawing.Point(15, 201);
            this.chBoxStatN.Name = "chBoxStatN";
            this.chBoxStatN.Size = new System.Drawing.Size(145, 17);
            this.chBoxStatN.TabIndex = 9;
            this.chBoxStatN.Text = "Uradi statistiku za zadnjih";
            this.chBoxStatN.UseVisualStyleBackColor = true;
            this.chBoxStatN.CheckedChanged += new System.EventHandler(this.chBoxStatN_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "vrednosti";
            // 
            // tBoxNum
            // 
            this.tBoxNum.Location = new System.Drawing.Point(183, 199);
            this.tBoxNum.Name = "tBoxNum";
            this.tBoxNum.Size = new System.Drawing.Size(21, 20);
            this.tBoxNum.TabIndex = 11;
            this.tBoxNum.TextChanged += new System.EventHandler(this.tBoxNum_TextChanged);
            // 
            // FormStatisticalData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 249);
            this.Controls.Add(this.tBoxNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chBoxStatN);
            this.Controls.Add(this.lblStatsHumidity);
            this.Controls.Add(this.lblStatsPressure);
            this.Controls.Add(this.lblStatsTemp);
            this.Controls.Add(this.tBoxHumidity);
            this.Controls.Add(this.tBoxPressure);
            this.Controls.Add(this.tBoxTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormStatisticalData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxTemp;
        private System.Windows.Forms.TextBox tBoxPressure;
        private System.Windows.Forms.TextBox tBoxHumidity;
        private System.Windows.Forms.Label lblStatsTemp;
        private System.Windows.Forms.Label lblStatsPressure;
        private System.Windows.Forms.Label lblStatsHumidity;
        private System.Windows.Forms.CheckBox chBoxStatN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBoxNum;
    }
}