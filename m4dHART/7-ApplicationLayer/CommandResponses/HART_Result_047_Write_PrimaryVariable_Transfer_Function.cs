using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommonTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommandResponses
{
    public class HART_Result_047_Write_PrimaryVariable_Transfer_Function : CommandResponse
    {
        public _003_Transfer_Function_Code PVTransferFunctionCode => (_003_Transfer_Function_Code)Data[0];
        public HART_Result_047_Write_PrimaryVariable_Transfer_Function(HARTDatagram command) : base(command)
        {
        }
    }
}
