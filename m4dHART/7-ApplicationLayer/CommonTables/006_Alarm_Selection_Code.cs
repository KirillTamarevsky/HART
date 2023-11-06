using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommonTables
{
    public enum _006_Alarm_Selection_Code
    {
        High = 0,
        Low = 1,
        Hold_Last_Value = 239,

        Manufacturer_Specific_240 = 240,
        Manufacturer_Specific_241 = 241,
        Manufacturer_Specific_242 = 242,
        Manufacturer_Specific_243 = 243,
        Manufacturer_Specific_244 = 244,
        Manufacturer_Specific_245 = 245,
        Manufacturer_Specific_246 = 246,
        Manufacturer_Specific_247 = 247,
        Manufacturer_Specific_248 = 248,
        Manufacturer_Specific_249 = 249,

        Not_Used = 250,
        None = 251,
        Unknown = 252,
        Special = 253
    }
}
