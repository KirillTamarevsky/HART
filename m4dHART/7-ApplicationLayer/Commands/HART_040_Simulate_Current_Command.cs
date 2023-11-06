using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommandResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.Commands
{
    public class HART_040_Simulate_Current_Command : HARTCommand
    {
        public override byte[] Data => CurrentToSimulate.Single_to_HART_bytearray();
        public float CurrentToSimulate { get; }
        public HART_040_Simulate_Current_Command(float currentReading) : base(40)
        {
            CurrentToSimulate = currentReading;
        }

        protected override CommandResponse GetCommandResult(HARTDatagram datagram)
        {
            return new HART_Result_040_Simulate_Current_Command(datagram);
        }
    }
}
