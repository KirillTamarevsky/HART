using System;
using System.Data.Common;
using System.Text;

namespace m4dHART._7_ApplicationLayer.CommandResponses
{
    public class CommandComminicationStatus
    {
        private byte Data;
        internal CommandComminicationStatus(byte databyte)
        {
            Data = databyte;
        }
        public bool VerticalParityError => (Data & 0x40) == 0x40;
        public bool OverrunError => (Data & 0x20) == 0x20;
        public bool FramingError => (Data & 0x10) == 0x10;
        public bool LongitudinalParityError => (Data & 0x08) == 0x08;
        /// <summary>
        /// Only for master Data-Links and I/O systems to indicate
        /// communication to Field Device
        /// </summary>
        public bool CommunicationFailure => (Data & 0x04) == 0x04;
        public bool BufferOverflow => (Data & 0x02) == 0x02;
        //public bool Reserved => (Data & 0x01) == 0x01;

        public override string ToString()
        {
            var res = new StringBuilder();
            res.Append($"Status Byte = {Data}");
            if (VerticalParityError) res.Append("[Vertical Parity Error]");
            if (OverrunError) res.Append("[Overrun Error]");
            if (FramingError) res.Append("[Framing Error]");
            if (LongitudinalParityError) res.Append("[Longitudinal Parity Error]");
            if (CommunicationFailure) res.Append("[Communication Failure]");
            if (BufferOverflow) res.Append("[Buffer Overflow]");
            return res.ToString();
        }
    }
    public class CommandResponseCode
    {
        private byte Data;
        public CommandResponseCode(byte databyte)
        {
            Data = databyte;

        }
        public bool Success => Data == 0;
        public bool Busy => Data == 32;
        public bool NotImplemented => Data == 64;
        public override string ToString()
        {
            var res = new StringBuilder();
            res.Append($"ResponseCode = {Data}");
            if (Success) res.Append("[Success]");
            if (Busy) res.Append("[Busy]");
            if (NotImplemented) res.Append("[Not Implemented]");
            return res.ToString();
        }
    }
}
