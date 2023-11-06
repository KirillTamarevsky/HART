using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommandResponses;

namespace m4dHART._7_ApplicationLayer.Commands
{
    public class HART_015_Read_Device_Information : HARTCommand
    {
        public HART_015_Read_Device_Information() : base(15)
        {
        }

        protected override CommandResponse GetCommandResult(HARTDatagram datagram)
        {
            return new HART_Result_015_Read_Device_Information(datagram);
        }
    }
}
