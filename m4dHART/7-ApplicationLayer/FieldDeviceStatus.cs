using System.Text;

namespace m4dHART._7_ApplicationLayer
{
    public class FieldDeviceStatus
    {
        private byte Data;
        public FieldDeviceStatus(byte databyte)
        {
            Data = databyte;
        }
        public bool DeviceMalfunction => (Data & 0x80) == 0x80;
        public bool ConfigurationChanged => (Data & 0x40) == 0x40;
        public bool ColdStart => (Data & 0x20) == 0x20;
        public bool MoreStatusAvailable => (Data & 0x10) == 0x10;
        public bool LoopCurrentFixed => (Data & 0x08) == 0x08;
        public bool LoopCurrentSaturated => (Data & 0x04) == 0x04;
        public bool NonPrimaryVariableOutOfLimits => (Data & 0x02) == 0x02;
        public bool PrimaryVariableOutOfLimits => (Data & 0x01) == 0x01;
        public override string ToString()
        {
            var res = new StringBuilder();
            if (DeviceMalfunction) res.Append("[Device Malfunction]");
            if (ConfigurationChanged) res.Append("[Configuration Changed]");
            if (ColdStart) res.Append("[Cold Start]");
            if (MoreStatusAvailable) res.Append("[More Status Available]");
            if (LoopCurrentFixed) res.Append("[Loop Current Fixed]");
            if (LoopCurrentSaturated) res.Append("[Loop Current Satureted]");
            if (NonPrimaryVariableOutOfLimits) res.Append("[Non Primary Variable Out Of Limits]");
            if (PrimaryVariableOutOfLimits) res.Append("[Primary Variable Out Of Limits]");
            return res.ToString();
        }
    }
}
