﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, Alignment = 0x8, GUID = 0x7104FBF2DB682458, NameHash = 0xA8FBF05C737FA4E2)]
    public class GcSelectableObjectSpawnList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Name;
        public List<GcSelectableObjectSpawnData> Objects;
    }
}
