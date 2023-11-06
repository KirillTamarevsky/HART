using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommandResponses
{
    public class HART_Result_034_Write_Primary_Variable_Damping_Value : CommandResponse
    {
        public float ActualPVDampingValue => new byte[] { Data[0], Data[1], Data[2], Data[3] }.To_HART_Single();
        public HART_Result_034_Write_Primary_Variable_Damping_Value(HARTDatagram command) : base(command)
        {
        }
    }
}
