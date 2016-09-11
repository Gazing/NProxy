﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NillyProxy.Packets.ClientPackets
{
    public class EscapePacket : Packet
    {
        public override PacketType Type
        {
            get
            {
                return PacketType.ESCAPE;
            }
        }

        public override void Read(PacketReader r)
        {
        }

        public override void Write(PacketWriter w)
        {
        }
    }
}
