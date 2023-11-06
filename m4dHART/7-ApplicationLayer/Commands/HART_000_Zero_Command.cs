using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommandResponses;

namespace m4dHART._7_ApplicationLayer.Commands
{
    public class HART_000_Zero_Command : HARTCommand
    {
        public HART_000_Zero_Command() : base(0) { }

        protected override CommandResponse GetCommandResult(HARTDatagram datagram)
        {
            var res = new HART_Result_000_Zero_Command_v5(datagram);
            if (res.HARTProtocolMajorRevisionImplementedByThisDevice == 6)
            {
                return new HART_Result_000_Zero_Command_v6(datagram);
            }
            if (res.HARTProtocolMajorRevisionImplementedByThisDevice == 7)
            {
                return new HART_Result_000_Zero_Command_v7(datagram);
            }
            return res;
        }

    }

}
