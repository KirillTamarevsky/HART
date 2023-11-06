using m4dHART._2_DataLinkLayer;
using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommonTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommandResponses
{
    public class HART_Result_000_Zero_Command_v6 : HART_Result_000_Zero_Command_v5
    {
        internal HART_Result_000_Zero_Command_v6(HARTDatagram command) : base(command)
        {
        }
        public int NumberOfPreablesToBeSentFromThisSlaveToMaster => Data[12];
        public int LastDeviceVariableCode => Data[13];
        public int ConfigurationChangeCounter => BitConverter.ToInt16(new byte[] { Data[14], Data[15] }, 0);
        public int ExtendedFieldDeviceStatus => Data[16];

    }
}
