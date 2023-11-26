using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommonTables
{
    [Flags]
    public enum _032_Standardized_Status_3_WirelessHART
    {
        Capacity_Denied = 0x01,
        Reserved = 0x02,
        Bandwidth_allocation_pending = 0x04,
        Block_Transfer_Pending = 0x08,
        Radio_Failure = 0x10
    }
}
