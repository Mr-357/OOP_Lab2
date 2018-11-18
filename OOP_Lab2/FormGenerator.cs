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
            CheckBounds();
        }

        private void CheckBounds()
        {
            
        }
    }
}
