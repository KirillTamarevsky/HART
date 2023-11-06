using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommonTables
{
    /// <summary>
    /// Asyncronous = 0 (FSK)
    /// Syncronous = 1 (i.e. PSK)
    /// </summary>
    public enum _024_Physical_Layer_Type_Code
    {
        Asyncronous = 0,
        Syncronous = 1
    }
}
