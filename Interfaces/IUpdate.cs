using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataClasses;

namespace Interfaces
{
    public interface IUpdate
    {
        void Update(Temperature Temp, Pressure Pressure, Humidity Humidity);
    }
}
