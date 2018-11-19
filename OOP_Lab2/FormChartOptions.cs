using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab2
{
    public partial class FormChartOptions : Form
    {
        public FormChartOptions()
        {
            InitializeComponent();
        }

        private void tBoxN_TextChanged(object sender, EventArgs e)
        {
            uint val;
            if (!uint.TryParse(tBoxN.Text, out val))
            {

                tBoxN.Text = "";
            }

            if (val <= 0)
                tBoxN.Text = "";
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {

        }

        private void btnPressure_Click(object sender, EventArgs e)
        {

        }

        private void btnHumidity_Click(object sender, EventArgs e)
        {

        }
    }
}
