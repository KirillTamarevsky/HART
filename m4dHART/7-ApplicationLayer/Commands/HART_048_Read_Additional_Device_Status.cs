using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommandResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.Commands
{
    public class HART_048_Read_Additional_Device_Status : HARTCommand
    {
        public HART_048_Read_Additional_Device_Status() : base(048)
        {
        }
        public HART_048_Read_Additional_Device_Status(byte[] databytes) : base(048, databytes)
        {
        }

        protected override CommandResponse GetCommandResult(HARTDatagram datagram)
        {
            return new HART_Result_048_Read_Additional_Device_Status(datagram);
        }
    }
}
