using System;
using System.IO;

namespace M0LTE.WsjtxUdpLib.Messages
{
    /*
     * Halt Tx       In        8
     *                         Id (unique key)        utf8
     *                         Auto Tx Only           bool
     *
     *      The server may stop a client from transmitting messages either
     *      immediately or at  the end of the  current transmission period
     *      using this message.
     */

    public class HaltTxMessage : WsjtxMessage, IWsjtxCommandMessageGenerator
    {
        public UInt32 SchemaVersion { get; set; }
        public string Id { get; set; }
        public bool AutoOnly { get; set; }
        public byte[] GetBytes()
        {
            using (MemoryStream m = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(m))
                {
                    writer.Write(WsjtxMessage.MAGIC_NUMBER);
                    writer.Write(EncodeQUInt32(SchemaVersion));
                    writer.Write(EncodeQUInt32(8));    //msg type
                    writer.Write(EncodeString(Id));
                    writer.Write(EncodeBoolean(AutoOnly));
                }
                return m.ToArray();
            }
        }
    }
}
