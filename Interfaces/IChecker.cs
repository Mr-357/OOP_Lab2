using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataClasses;

namespace Interfaces
{
    public interface IChecker
    {
        bool Check(string toCheck, out String error);
        String TypeName();
        void SetMin(string x);
        void SetMax(string x);
    }

    public class Checker<T> : IChecker where T:WeatherData, new()   // pravimo instance za T u ovom slucaju temp,pressure,humidity, trebalo bi da radi?
    {
        private double _min;
        private double _max;
        private bool _enabled=false;
        public String _type;
        private WeatherData check;
        private static Checker<T> _instance = null;
        private Checker()
        {
        }
        public void SetMin(string x) { _min = double.Parse(x); _enabled = true; }
        public void SetMax(string x) { _max = double.Parse(x); }
        public double Min { get => _min; set => _min = value; }
        public double Max { get => _max; set => _max = value; }
        public String TypeName()
        {

            switch (typeof(T).Name)
            {
                case "Temperature":
                    {
                        _type = "temperaturu";
                        break;
                    }
                case "Pressure":
                    {
                        _type = "pritisak";
                        break;
                    }
                case "Humidity":
                    {
                        _type = "vlaznost";
                        break;
                    }
                default:
                    _type = "greska";
                    break;
            }
            return _type;
        }
        public static Checker<T> Instance
        {
            get
            {
                if(_instance==null)
                {
                    _instance = new Checker<T>();
                }
                return _instance;
            }
        }

        public bool Enabled { get => _enabled; set => _enabled = value; }

        public bool Check(string toCheck, out string error)
        {

            try
            {
                check = new T();
                check=check.Parse(toCheck);
                if(!Range.InRange(check,Instance.Min,Instance.Max)&&_enabled)
                {
                    error = "Vrednosti za"+check.Identify()+"nisu u validnom opsegu";
                    return false;
                }
                error = null;
                return true;
            }
            catch(Exception ex)
            {
                error = "Losa vrednost za"+check.Identify()+","+ex.Message;
                return false;
            }
        }
        
    }

    public class Range  // mozda bespotrebno?
    {
        public static bool InRange(WeatherData x,double min,double max)
        {
            return x > min && x < max;
        }
    }
}
/************************************************************************* maybe useful stuff*/
//public class ConverterTo<T>
//{
//    public static T ConvertTo(object val)
//    {
//        T returnValue;

//        if (val is T variable)
//            returnValue = variable;
//        else
//            //try
//            {
//                //Handling Nullable types i.e, int?, double?, bool? .. etc
//                if (Nullable.GetUnderlyingType(typeof(T)) != null)
//                {
//                    TypeConverter conv = TypeDescriptor.GetConverter(typeof(T));
//                    returnValue = (T)conv.ConvertFrom(val);
//                }
//                else
//                {
//                    returnValue = (T)Convert.ChangeType(val, typeof(T));
//                }
//            }
//            //catch (Exception)
//            //{
//            //    returnValue = default(T);
//            //}

//        return returnValue;
//    }
//}
// private String name;
// private static List<Checker<T>> instances;

//private Checker(string n)
//{
//    name = n;
//}
//public static Checker<T> CheckerInstance (string type)
//{
//    Checker<T> checker = Instances.Find(ch => ch.Name == type);
//   if (checker!=null)
//    {
//        return checker;
//    }
//    Instances.Add(new Checker<T>(type));
//    return Instances.Find(ch => ch.Name == type);
//}
//public string Name { get => name; set => name = value; }