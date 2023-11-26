using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommonTables
{
    [Flags]
    public enum _027_Analog_Channel_Saturated_Flags
    {
        Secondary_Analog_Channel_Saturated = 0x01,
        Tertiary_Analog_Channel_Saturated = 0x02,
        Quaternary_Analog_Channel_Saturated = 0x04,
        Quinary_Analog_Channel_Saturated = 0x08
    }
}
