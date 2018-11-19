namespace OOP_Lab2
{
    partial class FormChartOptions
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tBoxN = new System.Windows.Forms.TextBox();
            this.btnTemp = new System.Windows.Forms.Button();
            this.btnPressure = new System.Windows.Forms.Button();
            this.btnHumidity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(102, 76);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "zadnjih N vrednosti:";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tBoxN
            // 
            this.tBoxN.Location = new System.Drawing.Point(235, 73);
            this.tBoxN.Name = "tBoxN";
            this.tBoxN.Size = new System.Drawing.Size(24, 20);
            this.tBoxN.TabIndex = 1;
            this.tBoxN.TextChanged += new System.EventHandler(this.tBoxN_TextChanged);
            // 
            // btnTemp
            // 
            this.btnTemp.Location = new System.Drawing.Point(12, 142);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(141, 23);
            this.btnTemp.TabIndex = 2;
            this.btnTemp.Text = "Prikaz Temperature";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // btnPressure
            // 
            this.btnPressure.Location = new System.Drawing.Point(159, 142);
            this.btnPressure.Name = "btnPressure";
            this.btnPressure.Size = new System.Drawing.Size(100, 23);
            this.btnPressure.TabIndex = 3;
            this.btnPressure.Text = "Prikaz Pritiska";
            this.btnPressure.UseVisualStyleBackColor = true;
            this.btnPressure.Click += new System.EventHandler(this.btnPressure_Click);
            // 
            // btnHumidity
            // 
            this.btnHumidity.Location = new System.Drawing.Point(276, 142);
            this.btnHumidity.Name = "btnHumidity";
            this.btnHumidity.Size = new System.Drawing.Size(118, 23);
            this.btnHumidity.TabIndex = 4;
            this.btnHumidity.Text = "Prikaz vlaznosti";
            this.btnHumidity.UseVisualStyleBackColor = true;
            this.btnHumidity.Click += new System.EventHandler(this.btnHumidity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Otvori grafik za:";
            // 
            // FormChartOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 186);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHumidity);
            this.Controls.Add(this.btnPressure);
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.tBoxN);
            this.Controls.Add(this.checkBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormChartOptions";
            this.Text = "Opcije za grafik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tBoxN;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.Button btnPressure;
        private System.Windows.Forms.Button btnHumidity;
        private System.Windows.Forms.Label label1;
    }
}