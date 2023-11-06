using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommandResponses
{
    public class HART_Result_022_Write_Long_Tag : CommandResponse
    {
        internal HART_Result_022_Write_Long_Tag(HARTDatagram command) : base(command)
        {
        }
        public string LongTag => Encoding.ASCII.GetString(Data);
    }
}
