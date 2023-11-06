using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommandResponses
{
    public class HART_Result_035_Write_PrimaryVariableRangeValues : CommandResponse
    {
        internal HART_Result_035_Write_PrimaryVariableRangeValues(HARTDatagram command) : base(command)
        {
        }
        public byte UnitsCode => Data[0];
        public double PVUpperRangeValue => (new byte[] { Data[1], Data[2], Data[3], Data[4] }).To_HART_Single();
        public double PVLowerRangeValue => (new byte[] { Data[5], Data[6], Data[7], Data[8] }).To_HART_Single();
    }
}
