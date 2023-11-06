using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommandResponses;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4dHART._7_ApplicationLayer.Commands
{
    public class HARTCommand
    {
        public byte Number { get; }
        public virtual byte[] Data { get; }
        public HARTCommand(byte number) : this(number, new byte[0]) { }
        public HARTCommand(byte number, byte[] data)
        {
            Number = number;
            Data = data;
        }
        public CommandResponseBase ToCommandResult(HARTDatagram datagram)
        {
            bool commError = (datagram.CommandStatusBytes[0] & 0b1000_0000) == 0b1000_0000;
            bool haveDataBytes = datagram.Data.Length > 0;
            if (commError)
                return new CommandResponseCommError(datagram);
            else
            {
                if (!haveDataBytes) return new CommandResponseMasterCommandError(datagram);
                if (datagram.CommandNumber == Number)
                {
                    return GetCommandResult(datagram);

                }
                else return new CommandResponse(datagram);
            }
        }
        protected virtual CommandResponse GetCommandResult(HARTDatagram datagram)
        {
            return new CommandResponse(datagram);
        }

    }

}
