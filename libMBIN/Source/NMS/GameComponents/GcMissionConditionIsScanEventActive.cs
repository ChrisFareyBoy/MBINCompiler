using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x28, GUID = 0x91BCAD8698C88021, NameHash = 0xDF80EC28C687305E)]
    public class GcMissionConditionIsScanEventActive : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Event;
        public bool MustMatchThisMissionSeed;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
