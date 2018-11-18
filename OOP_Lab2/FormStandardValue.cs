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
            lblTypeMax.Text = lblTypeMin.Text = check.TypeName();
        }

    }
}
