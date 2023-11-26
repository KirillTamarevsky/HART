using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommonTables
{
    [Flags]
    public enum _030_Standardized_Status_1
    {
        Status_Simulation_Active = 0x01,
        Discrete_Variable_Simulation_Active = 0x02,
        Event_Notification_Overflow = 0x04,
        Battery_or_Power_Supply_needs_Maintenance = 0x08,
        Reserved_Must_be_reset_To_ZERO = 0x10
    }
}
