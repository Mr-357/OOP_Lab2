using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClasses
{
    public abstract class WeatherData:IComparable
    {
        protected double _value;
        private DateTime created;
        public double Value { get => _value; set => _value = value; }
        public DateTime Created { get => created; set => created = value; }

        abstract public void DifferentMeasure(); // pretvaranje iz C u F odnosno kPa u mmHg
        abstract public string Identify(); // vraca gresku za opseg 
        abstract public WeatherData Parse(String p);

        public object Val()
        {
            return _value;
        }// vrednost koja mora da se prekastuje

        public int CompareTo(object obj)
        {
            Type objt = obj.GetType();
            if ((objt == typeof(Temperature)) ||(objt==typeof(Pressure))||(objt==typeof(Humidity)))
            {
                if ((WeatherData)obj > this._value)
                {
                    return -1;
                }
                else if ((WeatherData)obj < this._value)
                {
                    return 1;
                    }
                else return 0;
            }
            else throw new Exception("error");
        }

        public static bool operator >(WeatherData x, double y)
        {
            return x._value>y;
        }
        public static bool operator <(WeatherData x, double y)
        {
            return x._value<y;
        }
     
    }
    public class Temperature:WeatherData
    {
        
        private bool _state = false; //mogucnost za C / F
        
        public bool State { get => _state; set => _state = value; }
        public Temperature() { }
        public Temperature(String x)
        {
            if (x != "")
                _value = double.Parse(x);
            Created = DateTime.Now;

        }
        public Temperature(double x)
        {
            _value = x;
            Created = DateTime.Now;
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

        public override string Identify()
        {
            return " temperaturu ";
        }

        public override WeatherData Parse(String p)
        {
            return new Temperature(double.Parse(p));
        }
        public override string ToString()
        {
            return Math.Round(_value)+ " °C";
        }

    }
    public class Pressure : WeatherData
    {
        private bool _state = false; //mogucnost za kPa/mmHg

        public bool State { get => _state; set => _state = value; }
        public Pressure() {  }
        public Pressure(String x)
        {
            if (x != "")
                _value = double.Parse(x);
            Created = DateTime.Now;
        }
        public Pressure(double x)
        {
            _value = x;
            Created = DateTime.Now;
        }
        public override void DifferentMeasure()
        {
            throw new NotImplementedException();
        }

        public override string Identify()
        {
            return " pritisak ";
        }

        public override WeatherData Parse(string p)
        {
            return new Pressure(double.Parse(p));
        }
        public override string ToString()
        {
            return Math.Round(_value) + " kPa";
        }
    }
    public class Humidity : WeatherData
    {
        public Humidity() {  }
        public Humidity(String x)
        {
            if (x != "")
                _value = double.Parse(x);
            Created = DateTime.Now;
        }
        public override void DifferentMeasure()
        {
            return;
        }
        public Humidity(double x)
        {
            _value = x;
            Created = DateTime.Now;
        }
        public override string Identify()
        {
            return " vlaznost ";
        }

        public override WeatherData Parse(string p)
        {
            return new Humidity(double.Parse(p));
        }
        public override string ToString()
        {
            return Math.Round(_value) + " %";
        }
    }
    public static class Logarithm
    {
        public static double log10 (double x)
        {
            return Math.Log10(x);
        }
    }
}
