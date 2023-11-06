using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommandResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.Commands
{
    public class HART_054_Read_Device_Variable_Information : HARTCommand
    {
        public byte DeviceVariableCode { get; }
        public override byte[] Data => new byte[] { DeviceVariableCode }; 
        public HART_054_Read_Device_Variable_Information(byte deviceVariableCode) : base(054)
        {
            DeviceVariableCode = deviceVariableCode;
        }
        protected override CommandResponse GetCommandResult(HARTDatagram datagram)
        {
            return new HART_Result_054_Read_Device_Variable_Information_cs(datagram);
        }
    }
}
