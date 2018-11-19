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
    public partial class FormZadatak : Form, IUpdate
    {
        private bool _accept = true;
        private int _rejected = 0;
        private int _count = 0;
        private int _timer = 1;
        public FormZadatak()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                listBoxItems.Items.Add("");
            }
            timerReject.Interval = 1 * 1000;
        }

        public void Update(Temperature Temp, Pressure Pressure, Humidity Humidity)
        {
            String toadd = null;
            if (_accept == true)
            {
                if (Temp != null)
                {
                    toadd += Temp.ToString();
                }
                if (Pressure != null)
                {
                    toadd += Pressure.ToString();
                }
                if (Humidity != null)
                {
                    toadd += Humidity.ToString();
                }
                if (toadd != null)
                {
                    _accept = false;
                    if (_count == 9)
                        _count = 0;
                    listBoxItems.Items[_count++] = toadd;
                    timerReject.Enabled = true;
                }
            }
            else
            {
                ++_rejected;
                tBoxRejected.Text = _rejected.ToString();
            }
        }

        private void tBoxRejected_TextChanged(object sender, EventArgs e)
        { 
        }

        private void timerReject_Tick(object sender, EventArgs e)
        {
           // timerReject.Interval = _timer * 1000;
            _accept = true;
            timerReject.Enabled = false;
        }

        private void tBoxTimer_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tBoxTimer.Text, out _timer))
            {
                tBoxTimer.Text = "";
            }

            if (_timer <= 0)
            {
                tBoxTimer.Text = "";
                _timer = 1;
            }

            timerReject.Interval = _timer * 1000;
        }
    }
}
