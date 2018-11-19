using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClasses
{
    public abstract class WeatherData
    {
        protected double _value;
        public double Value { get => _value; set => _value = value; }
        abstract public void DifferentMeasure(); // pretvaranje iz C u F odnosno kPa u mmHg
        abstract public string Identify(); // vraca gresku za opseg 
        abstract public WeatherData Parse(String p);

        public object Val()
        {
            return _value;
        }// vrednost koja mora da se prekastuje
        public static bool operator >(WeatherData x, double y)
        {
            return x._value>y;
        }
        public static bool operator <(WeatherData x, double y)
        {
            return x._value<y;
        }
        public String test() { return "test"; }
       
    }
    public class Temperature:WeatherData
    {
        
        private bool _state = false; //mogucnost za C / F
        
        public bool State { get => _state; set => _state = value; }
        public Temperature() { }
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

        public override string Identify()
        {
            return " temperaturu ";
        }

        public override WeatherData Parse(String p)
        {
            return new Temperature(double.Parse(p));
        }

    }
    public class Pressure : WeatherData
    {
        private bool _state = false; //mogucnost za kPa/mmHg

        public bool State { get => _state; set => _state = value; }
        public Pressure() {  }
        public Pressure(double x)
        {
            _value = x;
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
    }
    public class Humidity : WeatherData
    {
        public Humidity() {  }
        public override void DifferentMeasure()
        {
            return;
        }
        public Humidity(double x)
        {
            _value = x;
        }
        public override string Identify()
        {
            return " vlaznost ";
        }

        public override WeatherData Parse(string p)
        {
            return new Humidity(double.Parse(p));
        }
    }
}
