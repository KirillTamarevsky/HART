using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommonTables
{
    public enum _020_Device_Variable_Family_Code
    {
        Temperature = 4,
        Pressure = 5,
        Valve_Actuator = 6,
        Simple_PID_Control = 7,
        pH = 8,
        Conductivity = 9,
        Totalizer = 10,
        Level = 11,
        Vortex_Flow = 12,
        Mag_Flow = 13,
        Coriolis_Flow = 14,
        Modulating_Final_Control = 15,

        Not_Used = 250
    }
}
