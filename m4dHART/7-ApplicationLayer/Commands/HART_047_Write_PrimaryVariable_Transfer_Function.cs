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
    public class HART_047_Write_PrimaryVariable_Transfer_Function : HARTCommand
    {
        public override byte[] Data => new byte[] { (byte)NewXferCode };
        public _003_Transfer_Function_Code NewXferCode { get; }
        public HART_047_Write_PrimaryVariable_Transfer_Function(_003_Transfer_Function_Code newXferCode) : base(047)
        {
            NewXferCode = newXferCode;
        }
        protected override CommandResponse GetCommandResult(HARTDatagram datagram)
        {
            return new HART_Result_047_Write_PrimaryVariable_Transfer_Function(datagram);
        }
    }
}
