﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x924E997629C58E31, NameHash = 0x7C5208D16FF2D5BF)]
    public class GcMissionConditionProductKnown : NMSTemplate
    {
        public GcProductTableEnum Product;
    }
}
