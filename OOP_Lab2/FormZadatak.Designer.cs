namespace OOP_Lab2
{
    partial class FormZadatak
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
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.tBoxTimer = new System.Windows.Forms.TextBox();
            this.timerReject = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxRejected = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(12, 44);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(231, 238);
            this.listBoxItems.TabIndex = 0;
            // 
            // tBoxTimer
            // 
            this.tBoxTimer.Location = new System.Drawing.Point(143, 18);
            this.tBoxTimer.Name = "tBoxTimer";
            this.tBoxTimer.Size = new System.Drawing.Size(100, 20);
            this.tBoxTimer.TabIndex = 1;
            this.tBoxTimer.TextChanged += new System.EventHandler(this.tBoxTimer_TextChanged);
            // 
            // timerReject
            // 
            this.timerReject.Tick += new System.EventHandler(this.timerReject_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Broj odbacenih";
            // 
            // tBoxRejected
            // 
            this.tBoxRejected.Location = new System.Drawing.Point(143, 315);
            this.tBoxRejected.Name = "tBoxRejected";
            this.tBoxRejected.Size = new System.Drawing.Size(100, 20);
            this.tBoxRejected.TabIndex = 3;
            this.tBoxRejected.TextChanged += new System.EventHandler(this.tBoxRejected_TextChanged);
            // 
            // FormZadatak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 340);
            this.Controls.Add(this.tBoxRejected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxTimer);
            this.Controls.Add(this.listBoxItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormZadatak";
            this.Text = "FormZadatak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.TextBox tBoxTimer;
        private System.Windows.Forms.Timer timerReject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxRejected;
    }
}