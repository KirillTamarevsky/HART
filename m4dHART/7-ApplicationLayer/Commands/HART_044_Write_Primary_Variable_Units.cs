using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommandResponses;

namespace m4dHART._7_ApplicationLayer.Commands
{
    public class HART_044_Write_Primary_Variable_Units : HARTCommand
    {
        public override byte[] Data => new byte[] { _unitCode };

        private byte _unitCode;
        public HART_044_Write_Primary_Variable_Units(byte unitCode) : base(44)
        {
            _unitCode = unitCode;
        }

        protected override CommandResponse GetCommandResult(HARTDatagram datagram)
        {
            return new HART_Result_044_Write_Primary_Variable_Units(datagram);
        }
    }
}
