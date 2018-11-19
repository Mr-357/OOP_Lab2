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
    public partial class FormStatisticalData : Form,IUpdate
    {
        private List<Temperature> listT= new List<Temperature>();
        private List<Pressure> listP= new List<Pressure>();
        private List<Humidity> listH= new List<Humidity>();
        public FormStatisticalData()
        {
            InitializeComponent();
        }

        public void Update(Temperature Temp, Pressure Pressure, Humidity Humidity)
        {
          if(Temp!=null)
            {
                if (Checker<Temperature>.Instance.Check(Temp.Value.ToString(), out string tmp))
                {
                    tBoxTemp.Text = Temp.ToString();
                    listT.Add(Temp);
                }
            }
          if(Pressure!=null)
            {
                if (Checker<Pressure>.Instance.Check(Pressure.Value.ToString(), out string tmp))
                {
                    tBoxPressure.Text = Pressure.ToString();
                    listP.Add(Pressure);
                }
            }
          if(Humidity!=null)
            {
                if (Checker<Humidity>.Instance.Check(Humidity.Value.ToString(), out string tmp))
                { 
                tBoxHumidity.Text = Humidity.ToString();
                listH.Add(Humidity);
                }
            }
            Calculate();

        }


        #region LongerFuncs 
        private double AverageT(int n)
        {
            double sum = 0;
            if (n == 0)
            {
                foreach (Temperature t in listT)
                {
                    sum = sum + t.Value;
                }
                sum = sum / listT.Count;
            }
            else
            {
                listT.Reverse();
                for (int i = 0; i < n; i++)
                {
                    sum = sum + listT[i].Value;
                }
                listT.Reverse();
                sum = sum / n;

            }
            return sum;
        }
        private double AverageP(int n)
        {
            double sum = 0;
            if (n == 0)
            {
                foreach (Pressure p in listP)
                {
                    sum = sum + p.Value;
                }
                sum = sum / listT.Count;
            }
            else
            {
                listP.Reverse();
                for (int i = 0; i < n; i++)
                {
                    sum = sum + listP[i].Value;
                }
                listP.Reverse();
                sum = sum / n;

            }
            return sum;
        }
        private double AverageH(int n)
        {
            double sum = 0;
            if (n == 0)
            {
                foreach (Humidity h in listH)
                {
                    sum = sum + h.Value;
                }
                sum = sum / listH.Count;
            }
            else
            {
                listH.Reverse();
                for (int i = 0; i < n; i++)
                {
                    sum = sum + listH[i].Value;
                }
                listH.Reverse();
                sum = sum / n;

            }
            return sum;
        }
        private double MinT(int n)
        {
            double min = Checker<Temperature>.Instance.Min;
            double minL = min - 1;
            if (n == 0)
            {
                if (listT.Count != 0)
                    minL = listT.Min().Value;
                if (minL <= min)
                    minL = min;
               
            }
            else
            {
                listT.Reverse();
                minL = listT[0].Value;
                for(int i=0;i <n;i++)
                {
                    if (listT[i].Value < minL)
                        minL = listT[i].Value;
                }
                listT.Reverse();
            }
            return minL;
        }
        private double MaxT(int n)
        {
            double max = Checker<Temperature>.Instance.Max;
            double maxL = max + 1;
            if (n == 0)
            {
                if (listT.Count != 0)
                    maxL = listT.Max().Value;
                if (maxL >= max)
                    maxL = max;
            }
            else
            {
                listT.Reverse();
                maxL = listT[0].Value;
                for (int i = 0; i < n; i++)
                {
                    if (listT[i].Value > maxL)
                        maxL = listT[i].Value;
                }
                listT.Reverse();
            }
            return maxL;
        }
        private double MinP(int n)
        {
            double min = Checker<Pressure>.Instance.Min;
            double minL = min - 1;
            if (n == 0)
            {
                if (listP.Count != 0)
                    minL = listP.Min().Value;
                if (minL <= min)
                    minL = min;

            }
            else
            {
                listP.Reverse();
                minL = listP[0].Value;
                for (int i = 0; i < n; i++)
                {
                    if (listP[i].Value < minL)
                        minL = listP[i].Value;
                }
                listP.Reverse();
            }
            return minL;
        }
        private double MaxP(int n)
        {
            double max = Checker<Pressure>.Instance.Max;
            double maxL = max + 1;
            if (n == 0)
            {
                if (listP.Count != 0)
                    maxL = listP.Max().Value;
                if (maxL >= max)
                    maxL = max;
            }
            else
            {
                listP.Reverse();
                maxL = listP[0].Value;
                for (int i = 0; i < n; i++)
                {
                    if (listP[i].Value > maxL)
                        maxL = listP[i].Value;
                }
                listP.Reverse();
            }
            return maxL;
        }
        private double MinH(int n)
        {
            double min = Checker<Humidity>.Instance.Min;
            double minL = min - 1;
            if (n == 0)
            {
                if (listH.Count != 0)
                    minL = listH.Min().Value;
                if (minL <= min)
                    minL = min;

            }
            else
            {
                listH.Reverse();
                minL = listH[0].Value;
                for (int i = 0; i < n; i++)
                {
                    if (listH[i].Value < minL)
                        minL = listH[i].Value;
                }
                listH.Reverse();
            }
            return minL;
        }
        private double MaxH(int n)
        {
            double max = Checker<Humidity>.Instance.Max;
            double maxL = max + 1;
            if (n == 0)
            {
                if (listH.Count != 0)
                    maxL = listH.Max().Value;
                if (maxL >= max)
                    maxL = max;
            }
            else
            {
                listH.Reverse();
                maxL = listH[0].Value;
                for (int i = 0; i < n; i++)
                {
                    if (listH[i].Value > maxL)
                        maxL = listH[i].Value;
                }
                listH.Reverse();
            }
            return maxL;
        }
        #endregion
        private void Calculate() 
        {
            int n = 0;
            if(chBoxStatN.Checked==true)
            {
                int.TryParse(tBoxNum.Text,out n);
            }
           
           
            
            lblStatsTemp.Text = "AVG: " +AverageT(n).ToString()+ " MIN: "+MinT(n).ToString() + " MAX: "+MaxT(n).ToString();
            lblStatsPressure.Text = "AVG: " + AverageP(n).ToString() + " MIN: " + MinP(n).ToString() + " MAX: " + MaxP(n).ToString();
            lblStatsHumidity.Text = "AVG: " + AverageH(n).ToString() + " MIN: " + MinH(n).ToString() + " MAX: " + MaxH(n).ToString();

        }

        private void tBoxNum_TextChanged(object sender, EventArgs e)
        {
            uint val;
            if (!uint.TryParse(tBoxNum.Text, out val))
            {
                
                tBoxNum.Text = "";
            }

            if (val <= 0)
                tBoxNum.Text = "";
        }

        private void chBoxStatN_CheckedChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
