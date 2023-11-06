using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommandResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.Commands
{
    public class HART_001_Read_Primary_Variable : HARTCommand
    {
        public HART_001_Read_Primary_Variable(byte number) : base(001)
        {
        }
        protected override CommandResponse GetCommandResult(HARTDatagram datagram)
        {
            return new HART_Result_001_Read_Primary_Variable(datagram);
        }
    }
}
