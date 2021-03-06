﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x310, GUID = 0xAB84214205BC3F36, NameHash = 0xF6415333939D5563)]
    public class GcAtlasSendSubmitBase : NMSTemplate
    {
        /* 0x000 */ public ulong ClientUserdata;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x008 */ public byte[] Padding8;
        /* 0x010 */ public GcGameMode GameMode;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x014 */ public byte[] Padding14;
        /* 0x020 */ public GcPersistentBase BaseData;
        /* 0x2D0 */ public GcAtlasRecvBlob TerrainData;
    }
}
