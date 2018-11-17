using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IChecker
    {
        bool Check(string toCheck, out String error);
    }

    public class Temperature : IChecker
    {
        public bool Check(string toCheck, out string error)
        {
            try
            {
                double check = double.Parse(toCheck);
                // if(notInRange(check,temp?) return "not in range" false
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
}
