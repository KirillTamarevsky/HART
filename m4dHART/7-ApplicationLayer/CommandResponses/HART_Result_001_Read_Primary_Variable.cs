using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommandResponses
{
    public class HART_Result_001_Read_Primary_Variable : CommandResponse
    {
        public byte PVUnitCode => Data[0];
        public Single PVValue => new byte[] { Data[1], Data[2], Data[3], Data[4] }.To_HART_Single();
        public HART_Result_001_Read_Primary_Variable(HARTDatagram command) : base(command)
        {
        }
    }
}
