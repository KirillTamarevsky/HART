using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommandResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.Commands
{
    public class HART_046_Trim_Trim_Loop_Current_Gain : HARTCommand
    {
        public override byte[] Data => CurrentReadingToTrim.Single_to_HART_bytearray();
        private float CurrentReadingToTrim { get; }
        public HART_046_Trim_Trim_Loop_Current_Gain(float currentReading) : base(46)
        {
            CurrentReadingToTrim = currentReading;
        }

        protected override CommandResponse GetCommandResult(HARTDatagram datagram)
        {
            return new HART_Result_046_Trim_Trim_Loop_Current_Gain(datagram);
        }
    }
}
