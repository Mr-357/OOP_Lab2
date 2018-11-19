using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataClasses;
using Interfaces;

namespace OOP_Lab2
{
    public partial class FormGenerator : Form
    {
        private Form LocalParent { get; set; }
        public FormGenerator()
        {
            InitializeComponent();
        }
        public FormGenerator(Form parent)
        {
            InitializeComponent();
            LocalParent = parent;
            CheckSV();
        }

        private void debug()
        {
            /***/
            lblError.Text = Checker<Temperature>.Instance.Min.ToString() + " " + Checker<Pressure>.Instance.Min.ToString() + " " + Checker<Humidity>.Instance.Min.ToString();
            lblError.Visible = true;
            /***/
        }

        private void CheckSV()
        {
            tBoxTemp.Enabled = tBoxPressure.Enabled = tBoxHumidity.Enabled = true;
            if(!Checker<Pressure>.Instance.Enabled)
            {
                tBoxPressure.Enabled = false;
            }
            if (!Checker<Temperature>.Instance.Enabled)
            {
                tBoxTemp.Enabled = false;
            }
            if (!Checker<Humidity>.Instance.Enabled)
            {
                tBoxHumidity.Enabled = false;
            }
        }
        private DialogResult SVDialog(IChecker ch)
        {
            Form f = new FormStandardValue(ch);
            f.ShowDialog();
            return f.DialogResult;
        }
        private void btnSVTemp_Click(object sender, EventArgs e)
        {
            if (SVDialog(Checker<Temperature>.Instance) == DialogResult.OK)
                CheckSV();
        }

        private void btnSVPressure_Click(object sender, EventArgs e)
        {
            if (SVDialog(Checker<Pressure>.Instance) == DialogResult.OK)
                CheckSV();
        }

        private void btnSVHumidity_Click(object sender, EventArgs e)
        {
            if (SVDialog(Checker<Humidity>.Instance) == DialogResult.OK)
                CheckSV();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          // CheckBounds();

        }

        private void tBoxInterval_TextChanged(object sender, EventArgs e)
        {
            uint val;
            if(!uint.TryParse(tBoxInterval.Text,out val))
            {
                tBoxInterval.Text = "1";
            }
            if(val<1 || val >9)
            {
                tBoxInterval.Text = "1";
            }
        }
    }
}
