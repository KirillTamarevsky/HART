using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommonTables
{
    [Flags]
    public enum _029_Standardized_Status_0
    {
        Device_Variable_Simulation_Active = 0x01,
        Non_Volatile_Memory_Defect = 0x02,
        Volatile_Memory_Defect = 0x04,
        Watchdog_Reset_Executed = 0x08,
        Power_Supply_Conditions_Out_of_Range = 0x10,
        Environmental_Conditions_Out_of_Range = 0x20,
        Electronic_Defect = 0x40,
        Device_Configuration_Locked = 0x80
    }
}
