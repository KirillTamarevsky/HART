using m4dHART;
using m4dHART._2_DataLinkLayer.Wired_Token_Passing;
using m4dHART._7_ApplicationLayer.CommonTables;

namespace m4dHARTTests
{
    [TestClass]
    public class DelimiterTest
    {
        [TestMethod]
        public void DelimiterTest1()
        {
            var delimiter = new Delimiter(AddressType.Polling, 0, _024_Physical_Layer_Type_Code.Asyncronous, FrameType.STX);
            Assert.AreEqual(0b00000010, delimiter.ToByte());
        }
        [TestMethod]
        public void DelimiterTest2()
        {
            var delimiter = new Delimiter(AddressType.Unique, 0, _024_Physical_Layer_Type_Code.Asyncronous, FrameType.STX);
            Assert.AreEqual(0b10000010, delimiter.ToByte());
        }
        [TestMethod]
        public void DelimiterTest3()
        {
            var delimiter = new Delimiter(AddressType.Unique, 2, _024_Physical_Layer_Type_Code.Asyncronous, FrameType.STX);
            Assert.AreEqual(0b11000010, delimiter.ToByte());
        }
        [TestMethod]
        public void DelimiterTest4()
        {
            var delimiter = new Delimiter(AddressType.Polling, 0, _024_Physical_Layer_Type_Code.Asyncronous, FrameType.ACK);
            Assert.AreEqual(0b00000110, delimiter.ToByte());
        }
    }
}