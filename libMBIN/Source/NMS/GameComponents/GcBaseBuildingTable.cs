﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1B70, GUID = 0x3245F764D8D0FF1C, NameHash = 0x69B43206529CA591)]
    public class GcBaseBuildingTable : NMSTemplate
    {
        /* 0x0000 */ public TkModelResource LegModel;
        /* 0x0084 */ public TkModelResource GhostHeart;
        /* 0x0108 */ public TkModelResource GhostHeartSelected;
        /* 0x018C */ public TkMaterialResource BuildEffectMaterial;
        /* 0x0210 */ public TkModelResource RotateScaleGizmo;
        /* 0x0294 */ public TkModelResource WiringFirefly;
        /* 0x0318 */ public TkModelResource WiringSnapPoint;
        /* 0x039C */ public TkModelResource WiringSnapSelected;
        /* 0x0420 */ public List<GcBaseBuildingEntry> Objects;
        /* 0x0430 */ public List<GcBaseBuildingGroup> Groups;
        [NMS(Size = 0x10)]
        /* 0x0440 */ public GcBaseBuildingPalette[] Palettes;
        [NMS(Size = 0x4)]
        /* 0x0840 */ public GcBaseBuildingMaterial[] Materials;
        [NMS(Size = 0x10)]
        /* 0x1B40 */ public string DefaultInBaseObject;
        [NMS(Size = 0x10)]
        /* 0x1B50 */ public string DefaultOnTerrainObject;
        [NMS(Size = 0x10)]
        /* 0x1B60 */ public string DefaultInFreighterObject;
    }
}
