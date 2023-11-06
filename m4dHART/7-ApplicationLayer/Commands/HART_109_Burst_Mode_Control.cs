using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommandResponses;
using m4dHART._7_ApplicationLayer.CommonTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.Commands
{
    public class HART_109_Burst_Mode_Control : HARTCommand
    {
        public override byte[] Data => ToByteArray();

        _009_Burst_Mode_Control_Code _mode;
        byte _burstMessage;
        public HART_109_Burst_Mode_Control(_009_Burst_Mode_Control_Code mode, byte burstMessage) : base(109)
        {
            _mode = mode;
            _burstMessage = burstMessage;
        }
        private byte[] ToByteArray()
        {
            return new byte[2] { (byte)_mode, _burstMessage };
        }

        protected override CommandResponse GetCommandResult(HARTDatagram datagram)
        {
            return new HART_Result_109_Burst_Mode_Control(datagram);
        }
    }
}
