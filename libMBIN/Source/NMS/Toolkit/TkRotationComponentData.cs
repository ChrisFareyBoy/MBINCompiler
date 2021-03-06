﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x30, Alignment = 0x10, GUID = 0xA641C128A2F004F0, NameHash = 0xB808E542DB69E5FE)]
    public class TkRotationComponentData : NMSTemplate
    {
        /* 0x00 */ public float Speed;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        /* 0x10 */ public Vector4f Axis;
        /* 0x20 */ public int SyncGroup;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x24 */ public byte[] EndPadding;
    }
}
