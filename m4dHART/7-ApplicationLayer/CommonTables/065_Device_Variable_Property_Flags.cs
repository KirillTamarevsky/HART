using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommonTables
{
    [Flags]
    public enum _065_Device_Variable_Property_Flags
    {
        /// <summary>
        /// e.g. written to the Field Device
        /// </summary>
        Device_Variable_Is_Input = 0x01,
        /// <summary>
        /// This bit must not be set if Device Variable is not calculated in the Field Device
        /// (e.g., Device Variable is setpoint or remote sensor value)
        /// </summary>
        Device_Variable_Is_Being_simulated = 0x80
    }
}
