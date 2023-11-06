using m4dHART._2_DataLinkLayer;
using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommonTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.CommandResponses
{
    public class HART_Result_000_Zero_Command_v5 : CommandResponse, IReadUniqueIdetifierCommand
    {
        internal HART_Result_000_Zero_Command_v5(HARTDatagram command) : base(command)
        {
        }
        public byte[] ExpandedDeviceTypeCode => new byte[] { Data[1], Data[2] };
        public int MinNumberOfPreamblesRequiredFromMaster => Data[3];
        public int HARTProtocolMajorRevisionImplementedByThisDevice => Data[4];
        public int DeviceRevisionLevel => Data[5];
        public int SoftwareRevisionLevelOfThisDevice => Data[6];
        public int HardwareRevisionLevelOfTheElectronicsInThisDevice => (Data[7] & 0b11111000) >> 3;
        public _010_Physical_Signaling_Code PhysicalSignalingCode => (_010_Physical_Signaling_Code)(Data[7] & 0b00000111);
        public _011_Flag_Assignments Flags => (_011_Flag_Assignments)Data[8];
        public byte[] DeviceID => new byte[] { Data[9], Data[10], Data[11] };

        public LongAddress LongAddress => new LongAddress(ExpandedDeviceTypeCode.Concat(DeviceID).ToArray());
    }
}
