using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommandResponses
{

    public class HART_Result_044_Write_Primary_Variable_Units : CommandResponse
    {
        internal HART_Result_044_Write_Primary_Variable_Units(HARTDatagram command) : base(command)
        {
        }
        public byte UnitCode => Data[0];
    }
}
