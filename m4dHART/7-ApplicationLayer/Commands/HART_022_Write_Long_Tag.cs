using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommandResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.Commands
{
    public class HART_022_Write_Long_Tag : HARTCommand
    {
        public override byte[] Data => ToByteArray();


        private string NewLongTag { get; set; }
        public HART_022_Write_Long_Tag(string newLongTag) : base(22)
        {
            if (string.IsNullOrEmpty(newLongTag))
            {
                newLongTag = string.Empty;
            }
            if (newLongTag.Length > 32)
            {
                newLongTag = newLongTag.Substring(0, 32);
            }
            NewLongTag = newLongTag;
        }


        private byte[] ToByteArray()
        {
            var res = new byte[32];

            var strbytes = Encoding.ASCII.GetBytes(NewLongTag);

            Array.Copy(strbytes, 0, res, 0, strbytes.Length);

            return res;
        }

        protected override CommandResponse GetCommandResult(HARTDatagram datagram)
        {
            return new HART_Result_022_Write_Long_Tag(datagram);
        }
    }
}
