using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommonTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommandResponses
{
    public class HART_Result_054_Read_Device_Variable_Information_cs : CommandResponse
    {
        public HART_Result_054_Read_Device_Variable_Information_cs(HARTDatagram command) : base(command)
        {
        }
        public byte DeviceVariableCode => Data[0];
        public byte[] TransducerSerialNumber => new byte[] { Data[1], Data[2], Data[3] };
        public byte UnitCode => Data[4];
        public Single UpperTransducerLimit => new byte[] { Data[5], Data[6], Data[7], Data[8] }.To_HART_Single();
        public Single LowerTransducerLimit => new byte[] { Data[9], Data[10], Data[11], Data[12] }.To_HART_Single();
        public Single DampingValue => new byte[] { Data[13], Data[14], Data[15], Data[16] }.To_HART_Single();
        public Single MinimumSpan => new byte[] { Data[17], Data[18], Data[19], Data[20] }.To_HART_Single();
        public _021_Device_Variable_Classification_Code VariableClassification => (_021_Device_Variable_Classification_Code)Data[21];
        public _020_Device_Variable_Family_Code VariableFamily => (_020_Device_Variable_Family_Code)Data[22];
        public TimeSpan AcquisitionPeriod => new byte[] { Data[23], Data[24], Data[25], Data[26], }.To_Hart_Time();
        public _065_Device_Variable_Property_Flags PropertiesFlags => (_065_Device_Variable_Property_Flags)Data[27];
    }
}
