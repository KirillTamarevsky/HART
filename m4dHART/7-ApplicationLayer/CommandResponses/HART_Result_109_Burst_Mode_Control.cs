using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommonTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommandResponses
{
    public class HART_Result_109_Burst_Mode_Control : CommandResponse
    {
        internal HART_Result_109_Burst_Mode_Control(HARTDatagram command) : base(command)
        {
        }
        public _009_Burst_Mode_Control_Code Burst_Mode_Control_Code => (_009_Burst_Mode_Control_Code)Data[0];
        public byte BurstMessage => Data[1];
    }
}
