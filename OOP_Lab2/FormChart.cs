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
    public partial class FormChart : Form,IUpdate
    {
        private List<WeatherData> _list=new List<WeatherData>();
        private String _type;
        private int _n;
        private List<WeatherData> _logList = new List<WeatherData>();
      
        
        public List<WeatherData> LogList
        {
            get
            {
                _logList = new List<WeatherData>(List.Count);
                foreach (WeatherData item in List)
                {
                    if (_type == "Temperature")
                    {
                        _logList.Add(new Temperature(Math.Log10(item.Value)));
                    }
                    else if (_type == "Pressure")
                    {
                        _logList.Add(new Pressure(Math.Log10(item.Value)));
                    }
                    else if (_type == "Humidity")
                    {
                        _logList.Add(new Pressure(Math.Log10(item.Value)));
                    }
                }
                return _logList;
            }
        }

        public List<WeatherData> List { get => _list; set => _list = value; }

        public FormChart()
        {
            InitializeComponent();
        }
        public FormChart(String type,int n)
        {
            InitializeComponent();
            _type = type;
            
            if(n>0)
            _n = n;
            
            chartMain.DataSource = List;
            chartMain.DataBind();
            chartMain.Series[0].Name = _type;
            chartMain.Series[0].YValueMembers = "Value";
        }
        private void UpdateChart()
        {
            List<WeatherData> data = List;
            if (cBoxLog.Checked)
                data = LogList;
            chartMain.DataSource = data;
            chartMain.DataBind();
        }
        public void Update(Temperature Temp, Pressure Pressure, Humidity Humidity)
        {
           if(_type=="Temperature" && Temp!=null)
            {
                List.Add(Temp);
                this.Text = Temp.Value.ToString();
            }
           else if (_type == "Pressure" && Pressure != null)
            {
                List.Add(Pressure);
                this.Text = Pressure.Value.ToString();
            }
           else if(_type == "Humidity" && Humidity!=null)
            {
                List.Add(Humidity);
                this.Text = Humidity.Value.ToString();
            }
            UpdateChart();
        }

        private void cBoxLog_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }

        private void chartMain_DoubleClick(object sender, EventArgs e)
        {
            Form f = new ListForm(List);
            f.Show();
        }
    }
}
