namespace OOP_Lab2
{
    partial class FormGenerator
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxTemp = new System.Windows.Forms.TextBox();
            this.tBoxPressure = new System.Windows.Forms.TextBox();
            this.tBoxHumidity = new System.Windows.Forms.TextBox();
            this.btnSVTemp = new System.Windows.Forms.Button();
            this.btnSVPressure = new System.Windows.Forms.Button();
            this.btnSVHumidity = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chBoxIgnoreLimits = new System.Windows.Forms.CheckBox();
            this.chBoxAutoSend = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.eProvideTemp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eProvideTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pritisak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vlaznost";
            // 
            // tBoxTemp
            // 
            this.tBoxTemp.Location = new System.Drawing.Point(155, 37);
            this.tBoxTemp.Name = "tBoxTemp";
            this.tBoxTemp.Size = new System.Drawing.Size(100, 20);
            this.tBoxTemp.TabIndex = 3;
            // 
            // tBoxPressure
            // 
            this.tBoxPressure.Location = new System.Drawing.Point(155, 72);
            this.tBoxPressure.Name = "tBoxPressure";
            this.tBoxPressure.Size = new System.Drawing.Size(100, 20);
            this.tBoxPressure.TabIndex = 4;
            // 
            // tBoxHumidity
            // 
            this.tBoxHumidity.Location = new System.Drawing.Point(155, 107);
            this.tBoxHumidity.Name = "tBoxHumidity";
            this.tBoxHumidity.Size = new System.Drawing.Size(100, 20);
            this.tBoxHumidity.TabIndex = 5;
            // 
            // btnSVTemp
            // 
            this.btnSVTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSVTemp.Location = new System.Drawing.Point(293, 36);
            this.btnSVTemp.Name = "btnSVTemp";
            this.btnSVTemp.Size = new System.Drawing.Size(30, 20);
            this.btnSVTemp.TabIndex = 6;
            this.btnSVTemp.Text = "*";
            this.btnSVTemp.UseVisualStyleBackColor = true;
            // 
            // btnSVPressure
            // 
            this.btnSVPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSVPressure.Location = new System.Drawing.Point(293, 71);
            this.btnSVPressure.Name = "btnSVPressure";
            this.btnSVPressure.Size = new System.Drawing.Size(30, 20);
            this.btnSVPressure.TabIndex = 7;
            this.btnSVPressure.Text = "*";
            this.btnSVPressure.UseVisualStyleBackColor = true;
            // 
            // btnSVHumidity
            // 
            this.btnSVHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSVHumidity.Location = new System.Drawing.Point(293, 103);
            this.btnSVHumidity.Name = "btnSVHumidity";
            this.btnSVHumidity.Size = new System.Drawing.Size(30, 20);
            this.btnSVHumidity.TabIndex = 8;
            this.btnSVHumidity.Text = "*";
            this.btnSVHumidity.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(187, 145);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 42);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Prosledi";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // chBoxIgnoreLimits
            // 
            this.chBoxIgnoreLimits.AutoSize = true;
            this.chBoxIgnoreLimits.Location = new System.Drawing.Point(12, 214);
            this.chBoxIgnoreLimits.Name = "chBoxIgnoreLimits";
            this.chBoxIgnoreLimits.Size = new System.Drawing.Size(97, 17);
            this.chBoxIgnoreLimits.TabIndex = 10;
            this.chBoxIgnoreLimits.Text = "Ignorisi granice";
            this.chBoxIgnoreLimits.UseVisualStyleBackColor = true;
            // 
            // chBoxAutoSend
            // 
            this.chBoxAutoSend.AutoSize = true;
            this.chBoxAutoSend.Location = new System.Drawing.Point(12, 237);
            this.chBoxAutoSend.Name = "chBoxAutoSend";
            this.chBoxAutoSend.Size = new System.Drawing.Size(294, 17);
            this.chBoxAutoSend.TabIndex = 11;
            this.chBoxAutoSend.Text = "Automatsko generisanje podataka,interval u sekundama:";
            this.chBoxAutoSend.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(312, 234);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(24, 20);
            this.textBox4.TabIndex = 12;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(9, 145);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(93, 13);
            this.lblError.TabIndex = 13;
            this.lblError.Text = "Lose vrednosti za:";
            this.lblError.Visible = false;
            // 
            // eProvideTemp
            // 
            this.eProvideTemp.ContainerControl = this;
            // 
            // FormGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(355, 276);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.chBoxAutoSend);
            this.Controls.Add(this.chBoxIgnoreLimits);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSVHumidity);
            this.Controls.Add(this.btnSVPressure);
            this.Controls.Add(this.btnSVTemp);
            this.Controls.Add(this.tBoxHumidity);
            this.Controls.Add(this.tBoxPressure);
            this.Controls.Add(this.tBoxTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGenerator";
            this.Text = "Form Generator";
            ((System.ComponentModel.ISupportInitialize)(this.eProvideTemp)).EndInit();
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
        private System.Windows.Forms.Button btnSVTemp;
        private System.Windows.Forms.Button btnSVPressure;
        private System.Windows.Forms.Button btnSVHumidity;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chBoxIgnoreLimits;
        private System.Windows.Forms.CheckBox chBoxAutoSend;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ErrorProvider eProvideTemp;
    }
}