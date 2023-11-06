using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommandResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.Commands
{
    public class HART_045_Trim_Loop_Current_Zero : HARTCommand
    {
        public override byte[] Data => CurrentReadingToTrim.Single_to_HART_bytearray();
        private float CurrentReadingToTrim { get; }
        public HART_045_Trim_Loop_Current_Zero(float currentReading) : base(45)
        {
            CurrentReadingToTrim = currentReading;
        }

        protected override CommandResponse GetCommandResult(HARTDatagram datagram)
        {
            return new HART_Result_045_Trim_Loop_Current_Zero(datagram);
        }
    }
}
