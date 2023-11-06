using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommonTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommandResponses
{
    public class HART_Result_015_Read_Device_Information : CommandResponse
    {
        internal HART_Result_015_Read_Device_Information(HARTDatagram command) : base(command)
        {
        }

        public _006_Alarm_Selection_Code PVAlarmSelectionCode => (_006_Alarm_Selection_Code)Data[0];
        public _003_Transfer_Function_Code PVTransferFunctionCode => (_003_Transfer_Function_Code)Data[1];
        public byte PVUpperAndLowerRangeValuesUnitCode => Data[2];
        public float PVUpperRangeValue => new byte[] { Data[3], Data[4], Data[5], Data[6] }.To_HART_Single();
        public float PVLowerRangeValue => new byte[] { Data[7], Data[8], Data[9], Data[10] }.To_HART_Single();
        public float PVDampingValue_in_seconds => new byte[] { Data[11], Data[12], Data[13], Data[14] }.To_HART_Single();
        public _007_Write_Protect_Code WriteProtectCode => (_007_Write_Protect_Code)Data[15];
        public byte PVAnalogChannelFlags => Data[17];

    }
}
