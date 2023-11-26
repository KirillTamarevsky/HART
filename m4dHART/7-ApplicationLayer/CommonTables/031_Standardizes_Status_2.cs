using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommonTables
{
    [Flags]
    public enum _031_Standardizes_Status_2
    {
        Sub_Device_List_Changed = 0x01,
        Duplicate_Master_Detected = 0x02,
        Sub_Device_Mismatch = 0x04,
        Sub_Device_with_Duplicate_IDs_Found = 0x08,
        Stale_Data_Notice = 0x10
    }
}
