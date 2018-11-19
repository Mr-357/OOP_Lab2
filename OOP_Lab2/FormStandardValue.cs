using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;

namespace OOP_Lab2
{
    public partial class FormStandardValue : Form
    {
        public IChecker checker { get; set; }
        public FormStandardValue()
        {
            InitializeComponent();
        }
        public FormStandardValue(IChecker check)
        {
            InitializeComponent();
            checker = check;
            this.Text = this.Text +" "+ check.TypeName();
            lblTypeMax.Text = lblTypeMin.Text = check.TypeName();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string tmp;
            checker.Check(tBoxMin.Text, out tmp);
            checker.SetMin(tBoxMin.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
