using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommandResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.Commands
{
    public class HART_034_Write_Primary_Variable_Damping_Value : HARTCommand
    {
        public override byte[] Data => PVDampingValue.Single_to_HART_bytearray();
        public float PVDampingValue { get; }
        public HART_034_Write_Primary_Variable_Damping_Value(float pvDampingValue) : base(34)
        {
            PVDampingValue = pvDampingValue;
        }
        protected override CommandResponse GetCommandResult(HARTDatagram datagram)
        {
            return new HART_Result_034_Write_Primary_Variable_Damping_Value(datagram);
        }
    }
}
