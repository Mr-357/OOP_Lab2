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
using DataClasses;

namespace OOP_Lab2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        #region EventHandlers
        private void menuItemFormGen_Click(object sender, EventArgs e)
        {
            FormGenerator f = new FormGenerator(this); // (this)
            f.MdiParent = this;
            f.Show();
        }

        private void menuItemFormChart_Click(object sender, EventArgs e)
        {
            FormChart f = new FormChart(); // (this,string,null)
            f.MdiParent = this;
            f.Show();
            menuForms.HideDropDown();
           // menuForms.Owner.Hide();
        }

        private void menuItemFormChartN_Click(object sender, EventArgs e)
        {
            FormChart f = new FormChart(); // dialog box? message box? for numbers
            f.MdiParent = this;
            f.Show();
        }

        private void menuItemFormStats_Click(object sender, EventArgs e)
        {
            FormStatisticalData f = new FormStatisticalData(); // (this)
            f.MdiParent = this;
            f.Show();
        }
        public void SendUpdates(Temperature t,Pressure p,Humidity h)
        {
            foreach (Form f in this.MdiChildren)
            {
                IUpdate update = f as IUpdate;
                if(update!=null)
                {
                    update.Update(t, p, h);
                }
            }
        }
        #endregion
    }
}
