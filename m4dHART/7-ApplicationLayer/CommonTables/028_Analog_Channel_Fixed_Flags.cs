using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommonTables
{
    [Flags]
    public enum _028_Analog_Channel_Fixed_Flags
    {
        Secondary_Analog_Channel_Fixed = 0x01,
        Tertiary_Analog_Channel_Fixed = 0x02,
        Quaternary_Analog_Channel_Fixed = 0x04,
        Quinary_Analog_Channel_Fixed = 0x08
    }
}
