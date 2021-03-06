﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xB8, Alignment = 0x8, GUID = 0xC3D61DFE9D3AB5CD, NameHash = 0xE09F11724D654285)]
    public class TkLSystemRule : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Name;
        [NMS(Size = 0x80)]
        public string Model;

        public List<TkLSystemInnerRule> Rules;

		public enum RuleTypeEnum { Default, BaseRule }
		public RuleTypeEnum RuleType;

        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingB4;
    }
}
