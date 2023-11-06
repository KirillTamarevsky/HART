using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommonTables
{
    [Flags]
    public enum _025_Lock_Device_Status
    {
        /// <summary>
        /// Must be set if any lock is asserted in the Field Device
        /// </summary>
        Device_Locked = 0x01,
        /// <summary>
        /// Must be set if lock does not clear on Device Reset or Power Loss
        /// </summary>
        Lock_is_Permanent = 0x02,
        /// <summary>
        /// Reset if Secondary Master. Must be set if Locked by the Primary Master or the Gateway
        /// </summary>
        Locked_by_Primary_Master = 0x04,
        /// <summary>
        /// Must be set if "Lock All" code is received (see Common Table 18)
        /// </summary>
        Configuration_Locked_and_cannot_be_changed_by_any_application = 0x08,
        /// <summary>
        /// Must be set (along with "Locked by Primary Master") if locked by Gateway
        /// </summary>
        Locked_by_Gateway = 0x10
    }
}
