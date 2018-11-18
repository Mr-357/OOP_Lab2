using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClasses
{
    public abstract class WeatherData
    {
        abstract public void DifferentMeasure(); // pretvaranje iz C u F odnosno kPa u mmHg
        abstract public string Error(); // vraca gresku za opseg 
        abstract public WeatherData Parse(String p);
        protected abstract bool CompareG(object x);
        protected abstract bool CompareL(object x);
        public abstract object Val();  // vrednost koja mora da se prekastuje
        public static bool operator >(WeatherData x, object y)
        {
            return x.CompareG(y);
        }
        public static bool operator <(WeatherData x, object y)
        {
            return x.CompareL(y);
        }
        public String test() { return "test"; }
       
    }
    public class Temperature:WeatherData
    {
        private double _value;
        private bool _state = false; //mogucnost za C / F
        public double Value { get => _value; set => _value = value; }
        public bool State { get => _state; set => _state = value; }
        public Temperature(double x)
        {
            _value = x;
        }
        public override void DifferentMeasure()
        {
           if(!_state)
            {
                _value = _value * 9.0 / 5.0 + 32;
            }
           else
            {
                _value = (_value - 32) * 5.0 / 9.0;
            }
        }

        public override string Error()
        {
            return "Temperatura nije u opsegu";
        }

        public override WeatherData Parse(String p)
        {
            return new Temperature(double.Parse(p));
        }

        protected override bool CompareG(object x)
        {
            return this.Value > (double)x;
        }

        protected override bool CompareL(object x)
        {
            return this.Value < (double)x;
        }

        public override object Val()
        {
            return _value;
        }
    }
}
