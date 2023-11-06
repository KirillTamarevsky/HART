using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommonTables
{

    [Flags]
    public enum _017_Extended_Device_Status
    {
        Maintenance_Required = 0x01,
        Device_Variable_Alert = 0x02,
        Critical_Power_Failure = 0x04,
        Failure = 0x08,
        Out_Of_Specification = 0x10,
        Function_Check = 0x20
    }
}
