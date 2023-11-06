using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer;
using m4dHART._7_ApplicationLayer.CommandResponses;
using System;

namespace m4dHART._7_ApplicationLayer.CommandResponses
{
    public abstract class CommandResponseBase
    {
        protected readonly HARTDatagram _ACKdatagram;
        //public byte Delimiter => _ACKdatagram.StartDelimiter; 
        //public IAddress Address => _ACKdatagram.Address; 
        public byte CommandNumber => _ACKdatagram.CommandNumber;
        public FieldDeviceStatus DeviceStatus { get; }
        //public byte Checksum => _ACKdatagram.CalculateChecksum(); 

        //public FrameType FrameType => _ACKdatagram.FrameType;
        //public MasterAddress MasterAddress => _ACKdatagram.MasterAddress;
        public bool BURST => _ACKdatagram.FrameType == FrameType.BACK || _ACKdatagram.Address._fieldDeviceInBurstMode;
        protected CommandResponseBase(HARTDatagram command)
        {
            DeviceStatus = new FieldDeviceStatus(command.CommandStatusBytes[1]);
            _ACKdatagram = command;
        }
    }

    public class CommandResponseCommError : CommandResponseBase
    {
        public CommandComminicationStatus CommunicationStatus { get; }
        public CommandResponseCommError(HARTDatagram command) : base(command)
        {
            CommunicationStatus = new CommandComminicationStatus(_ACKdatagram.CommandStatusBytes[0]);
        }
        public override string ToString()
        {
            return $"{nameof(CommandResponseCommError)} Command = {CommandNumber}, Communication Status = {CommunicationStatus}, Device Status = {DeviceStatus}";
        }
    }
    public class CommandResponse : CommandResponseBase
    {
        public byte[] Data => _ACKdatagram.Data;

        public CommandResponseCode ResponseCode { get; }
        public CommandResponse(HARTDatagram command) : base(command)
        {
            ResponseCode = new CommandResponseCode(_ACKdatagram.CommandStatusBytes[0]);
        }
        public override string ToString()
        {
            return $"{nameof(CommandResponse)} Command = {CommandNumber}, ResponseCode = {ResponseCode}, Data = {BitConverter.ToString(Data)}";
        }
    }

    public class CommandResponseMasterCommandError : CommandResponseBase
    {
        public CommandResponseCode ResponseCode { get; }
        public CommandResponseMasterCommandError(HARTDatagram command) : base(command)
        {
            ResponseCode = new CommandResponseCode(_ACKdatagram.CommandStatusBytes[0]);
        }
        public override string ToString()
        {
            return $"{nameof(CommandResponseMasterCommandError)} Command = {CommandNumber}, Response Code = {ResponseCode}, Device Status = {DeviceStatus}";
        }
    }

}
