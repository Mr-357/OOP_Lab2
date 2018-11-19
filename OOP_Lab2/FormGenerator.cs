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
        private FormMain LocalParent { get; set; }
        public FormGenerator()
        {
            InitializeComponent();
        }
        public FormGenerator(FormMain parent)
        {
            InitializeComponent();
            LocalParent = parent;
            CheckSV();
        }

        
        private void ClearErrors()
        {
            eProvideTemp.Clear();
            eProvidePressure.Clear();
            eProvideHumidity.Clear();
        }
        private void CheckBounds()
        {
            String eT, eP, eH;
            ClearErrors();
            if(!Checker<Temperature>.Instance.Check(tBoxTemp.Text,out eT))
            {
                eProvideTemp.SetError(tBoxTemp, eT);
                tBoxTemp.Text = "";
            }
            if (!Checker<Pressure>.Instance.Check(tBoxPressure.Text, out eP))
            {
                eProvidePressure.SetError(tBoxPressure, eP);
                tBoxPressure.Text = "";
            }
            if (!Checker<Humidity>.Instance.Check(tBoxHumidity.Text, out eH))
            {
                eProvideHumidity.SetError(tBoxHumidity, eH);
                tBoxHumidity.Text = "";
            }
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
             if(SVDialog(Checker<Temperature>.Instance)==DialogResult.OK)
             CheckSV();
        }

        private void btnSVPressure_Click(object sender, EventArgs e)
        {
            if(SVDialog(Checker<Pressure>.Instance)==DialogResult.OK)
            CheckSV();
        }

        private void btnSVHumidity_Click(object sender, EventArgs e)
        {
            if(SVDialog(Checker<Humidity>.Instance) == DialogResult.OK)
            CheckSV();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CheckEmpty();
            if (chBoxIgnoreLimits.Checked == true)
            {
                CheckBounds();
            }
            SendData();
        }

        private void SendData()
        {
            String tT = tBoxTemp.Text;
            Temperature t = null;
            if (tT != "")
                t = new Temperature(tT);
            String tP = tBoxPressure.Text;
            Pressure p = null;
            if (tP != "")
                p = new Pressure(tP);
            String tH = tBoxHumidity.Text;
            Humidity h = null;
            if (tH != "")
                h = new Humidity(tH);
            
            LocalParent.SendUpdates(t, p, h);
        }

        private void CheckEmpty()
        {
            ClearErrors();
            
            if(tBoxTemp.Text=="")
            {
                eProvideTemp.SetError(tBoxTemp, "Nije uneta vrednost");
            }
            if(tBoxPressure.Text == "")
            {
                eProvidePressure.SetError(tBoxPressure, "Nije uneta vrednost");
            }
            if(tBoxHumidity.Text == "")
            {
                eProvideHumidity.SetError(tBoxHumidity, "Nije uneta vrednost");
            }
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

        private void chBoxAutoSend_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxAutoSend.Checked)
            {
                timerAutoUpdate.Interval = 1000 * int.Parse(tBoxInterval.Text);
                timerAutoUpdate.Enabled = true;
                btnUpdate.Enabled = false;
               
                return;
            }
            timerAutoUpdate.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void SendAutoValues()
        {
            Random random = new Random();
            Temperature t = null;
            Pressure p = null;
            Humidity h = null;
            if (Checker<Temperature>.Instance.Enabled)
            { 
            double rngT = random.NextDouble() * (Checker<Temperature>.Instance.Max - Checker<Temperature>.Instance.Min) + Checker<Temperature>.Instance.Min;
            t = new Temperature(rngT);
            }
            if (Checker<Pressure>.Instance.Enabled)
            {
                double rngP = random.NextDouble() * (Checker<Pressure>.Instance.Max - Checker<Pressure>.Instance.Min) + Checker<Pressure>.Instance.Min;
                p = new Pressure(rngP);
            }
            if(Checker<Humidity>.Instance.Enabled)
            {
                double rngH = random.NextDouble() * (Checker<Humidity>.Instance.Max - Checker<Humidity>.Instance.Min) + Checker<Humidity>.Instance.Min;
                h = new Humidity(rngH);
            }
            LocalParent.SendUpdates(t, p, h);
        }

        private void timerAutoUpdate_Tick(object sender, EventArgs e)
        {
            SendAutoValues();
        }
    }
}
