using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommonTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommandResponses
{
    public class HART_Result_048_Read_Additional_Device_Status : CommandResponse
    {
        public byte[] Device_Specific_Status { get; }
        public _017_Extended_Device_Status Extended_Field_Device_Status { get; }
        public byte Device_Operating_Mode { get; }
        public _029_Standardized_Status_0 Standardized_Status_0 { get; }
        public _030_Standardized_Status_1? Standardized_Status_1 { get; } = null;
        public _027_Analog_Channel_Saturated_Flags? Analog_Channel_Saturated { get; } = null;
        public _031_Standardizes_Status_2? Standardized_Status_2 { get; } = null;
        public _032_Standardized_Status_3_WirelessHART? Standardized_Status_3 { get; } = null;
        public _028_Analog_Channel_Fixed_Flags? Analog_Channel_Fixed { get; } = null;
        public byte[]? Device_Specific_Status_2 { get; } = null;
        public HART_Result_048_Read_Additional_Device_Status(HARTDatagram command) : base(command)
        {
            Device_Specific_Status = new byte[6] { Data[0], Data[1], Data[2], Data[3], Data[4], Data[5] };
            Extended_Field_Device_Status = (_017_Extended_Device_Status)Data[6];
            Device_Operating_Mode = Data[7];
            Standardized_Status_0 = (_029_Standardized_Status_0)Data[8];
            if (Data.Length > 9)
            {
                Standardized_Status_1 = (_030_Standardized_Status_1?)Data[9];
                if (Data.Length > 10)
                {
                    Analog_Channel_Saturated = (_027_Analog_Channel_Saturated_Flags?)Data[10];
                    if (Data.Length > 11)
                    {
                        Standardized_Status_2 = (_031_Standardizes_Status_2?)Data[11];
                        if (Data.Length > 12)
                        {
                            Standardized_Status_3 = (_032_Standardized_Status_3_WirelessHART?)Data[12];
                            if (Data.Length > 13)
                            {
                                Analog_Channel_Fixed = (_028_Analog_Channel_Fixed_Flags?)Data[13];
                                if (Data.Length > 14)
                                {
                                    var remain_len = Data.Length - 14;
                                    Device_Specific_Status_2 = new byte[remain_len];
                                    Array.Copy(Data, 14, Device_Specific_Status_2, 0, remain_len);
                                }
                            }
                        }
                    }
                }
            
            }
        }
    }
}
