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
    }

    public class Checker<T> : IChecker where T:WeatherData   // pravimo instance za T u ovom slucaju temp,pressure,humidity, trebalo bi da radi?
    {
        private double _min;
        private double _max;
        public static String _type;
        private WeatherData check;
        private static Checker<T> _instance = null;
        private Checker()
        {
        }

        public double Min { get => _min; set => _min = value; }
        public double Max { get => _max; set => _max = value; }
        public String TypeName()
        {
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

        public bool Check(string toCheck, out string error)
        {

            try
            {
                check = check.Parse(toCheck);
                if(!Range.InRange(check,Instance.Min,Instance.Max))
                {
                    error = check.Error();
                    return false;
                }
                error = null;
                return true;
            }
            catch(Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
        
    }

    public class Range  // mozda bespotrebno?
    {
        public static bool InRange(WeatherData x,object min,object max)
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