using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommonTables
{
    [Flags]
    public enum _011_Flag_Assignments
    {
        MultiSensor_Field_Device = 0x01,
        EEPROM_Control = 0x02,
        Protocol_Bridge_Device = 0x04,
        IEEE802_15_4_24GHz_DSSS_with_O_QPSK_Modulation = 0x08,
        C8PSK_Capable_Field_Device = 0x40,
        C8PSK_in_MultiDrop_Only = 0x80
    }
}
