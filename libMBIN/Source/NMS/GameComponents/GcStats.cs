﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xABB94C527B567CD, NameHash = 0x9C20970E839B65D9)]
    public class GcStats : NMSTemplate
    {
        public List<GcStatsGroup> Stats;
    }
}
