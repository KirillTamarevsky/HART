using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommandResponses
{
    public class HART_Result_050_Read_Dynamic_Variables_Assignments : CommandResponse
    {
        public byte DeviceVariable_assigned_to_PV => Data[0];
        public byte DeviceVariable_assigned_to_SV => Data[1];
        public byte DeviceVariable_assigned_to_TV => Data[2];
        public byte DeviceVariable_assigned_to_QV => Data[3];
        public HART_Result_050_Read_Dynamic_Variables_Assignments(HARTDatagram command) : base(command)
        {
        }
    }
}
