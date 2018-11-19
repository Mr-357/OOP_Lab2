namespace OOP_Lab2
{
    partial class FormStandardValue
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
            this.tBoxMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTypeMin = new System.Windows.Forms.Label();
            this.lblTypeMax = new System.Windows.Forms.Label();
            this.tBoxMax = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uneti minimum za ";
            // 
            // tBoxMin
            // 
            this.tBoxMin.Location = new System.Drawing.Point(30, 67);
            this.tBoxMin.Name = "tBoxMin";
            this.tBoxMin.Size = new System.Drawing.Size(100, 20);
            this.tBoxMin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Uneti maksimum za";
            // 
            // lblTypeMin
            // 
            this.lblTypeMin.AutoSize = true;
            this.lblTypeMin.Location = new System.Drawing.Point(125, 30);
            this.lblTypeMin.Name = "lblTypeMin";
            this.lblTypeMin.Size = new System.Drawing.Size(35, 13);
            this.lblTypeMin.TabIndex = 3;
            this.lblTypeMin.Text = "label3";
            // 
            // lblTypeMax
            // 
            this.lblTypeMax.AutoSize = true;
            this.lblTypeMax.Location = new System.Drawing.Point(131, 123);
            this.lblTypeMax.Name = "lblTypeMax";
            this.lblTypeMax.Size = new System.Drawing.Size(35, 13);
            this.lblTypeMax.TabIndex = 4;
            this.lblTypeMax.Text = "label3";
            // 
            // tBoxMax
            // 
            this.tBoxMax.Location = new System.Drawing.Point(30, 159);
            this.tBoxMax.Name = "tBoxMax";
            this.tBoxMax.Size = new System.Drawing.Size(100, 20);
            this.tBoxMax.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(207, 184);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormStandardValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 219);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tBoxMax);
            this.Controls.Add(this.lblTypeMax);
            this.Controls.Add(this.lblTypeMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxMin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormStandardValue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podesi standarne vrednosti za";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTypeMin;
        private System.Windows.Forms.Label lblTypeMax;
        private System.Windows.Forms.TextBox tBoxMax;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}