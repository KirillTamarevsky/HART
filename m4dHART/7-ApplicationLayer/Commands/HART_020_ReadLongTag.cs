using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommandResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.Commands
{
    public class HART_020_ReadLongTag : HARTCommand
    {
        public HART_020_ReadLongTag() : base(20)
        {
        }

        protected override CommandResponse GetCommandResult(HARTDatagram datagram)
        {
            return new HART_Result_020_Read_Long_Tag(datagram);
        }
    }
}
