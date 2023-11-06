using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommandResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.Commands
{
    public class HART_013_Read_Tag_Descriptor_Date : HARTCommand
    {
        public HART_013_Read_Tag_Descriptor_Date() : base(13)
        {
        }

        protected override CommandResponse GetCommandResult(HARTDatagram datagram)
        {
            return new HART_Result_013_Tag_Descriptor_Date(datagram);
        }
    }
}
