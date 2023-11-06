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
    public class HART_Result_000_Zero_Command_v7 : HART_Result_000_Zero_Command_v6
    {
        internal HART_Result_000_Zero_Command_v7(HARTDatagram command) : base(command)
        {
        }
        public byte[] ManufacturerIdentificationCode => new byte[] { Data[17], Data[18] };
        public byte[] PrivateLabelDistributorCode => new byte[] { Data[19], Data[20] };
        public int DeviceProfile => Data[21];
    }
}
