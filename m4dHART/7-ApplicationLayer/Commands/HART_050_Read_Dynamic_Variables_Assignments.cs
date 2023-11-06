using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommandResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.Commands
{
    public class HART_050_Read_Dynamic_Variables_Assignments : HARTCommand
    {
        public HART_050_Read_Dynamic_Variables_Assignments() : base(050)
        {
        }
        protected override CommandResponse GetCommandResult(HARTDatagram datagram)
        {
            return new HART_Result_050_Read_Dynamic_Variables_Assignments(datagram);
        }
    }
}
