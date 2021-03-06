﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x5E0, Alignment = 0x8, GUID = 0x165F471395DA30AC, NameHash = 0x7BBBCE7D7BC0F1F4)]
    public class GcScanEventData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string Name;
        [NMS(Size = 0x20)]
        /* 0x020 */ public string ForceInteraction;
        /* 0x040 */ public GcInteractionType ForceInteractionType;
        /* 0x044 */ public bool ForceBroken;
        /* 0x045 */ public bool ForceFixed;
        /* 0x046 */ public bool ForceOverridesAll;
        /* 0x047 */ public bool IsCommunityPortalOverride;
        /* 0x048 */ public bool ClearForcedInteractionOnCompletion;
        /* 0x04C */ public float BuildingPreventionRadius;
        /* 0x050 */ public bool AlwaysShow;
        /* 0x051 */ public bool NeverShow;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x052 */ public byte[] Padding52;
        [NMS(Size = 0x20)]
        /* 0x058 */ public string PlanetLabelText;
        /* 0x078 */ public float SurveyDistance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x07C */ public byte[] Padding7C;
        [NMS(Size = 0x20)]
        /* 0x080 */ public string SurveyDiscoveryOSDMessage;
        public enum EventStartTypeEnum { None, Special, Discovered, Timer, ObjectScan, LeaveBuilding }
		/* 0x0A0 */ public EventStartTypeEnum EventStartType;
		public enum EventEndTypeEnum { None, Proximity, Interact, EnterBuilding, TimedInteract }
		/* 0x0A4 */ public EventEndTypeEnum EventEndType;
		public enum EventPriorityEnum { Regular, High }
		/* 0x0A8 */ public EventPriorityEnum EventPriority;
        /* 0x0AC */ public bool CanEndFromOutsideMission;
        /* 0x0AD */ public bool DisableMultiplayerSync;
        /* 0x0AE */ public bool ReplaceEventIfAlreadyActive;
        public enum BuildingLocationEnum { Nearest, AllNearest, Random, RandomOnNearPlanet, RandomOnFarPlanet, PlanetSearch }
		/* 0x0B0 */ public BuildingLocationEnum BuildingLocation;
		public enum BuildingTypeEnum { Any, AnyShelter, AnyNPC, BuildingClass, SpaceStation, SpaceAnomaly, Atlas, Freighter, FreighterBase,
            ExternalPlanetBase, PlanetBaseTerminal, Expedition, TutorialShelter, MPMissionFreighter, Nexus, InitialDistressSignal }
		/* 0x0B4 */ public BuildingTypeEnum BuildingType;
        /* 0x0B8 */ public GcBuildingClassification BuildingClass;
        /* 0x0BC */ public bool AllowFriendBases;
        /* 0x0BD */ public bool ForceWideRandom;
        /* 0x0BE */ public bool MustFindSystem;
        /* 0x0BF */ public bool AllowOverriddenBuildings;
		public enum SolarSystemLocationEnum { Local, Near, LocalOrNear, NearWithNoExpeditions, FromList }
		/* 0x0C0 */ public SolarSystemLocationEnum SolarSystemLocation;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x0C4 */ public byte[] PaddingC4;
        /* 0x0C8 */ public GcScanEventSolarSystemLookup SolarSystemAttributes;
        /* 0x138 */ public GcScanEventSolarSystemLookup SolarSystemAttributesFallback;
        /* 0x1A8 */ public bool ForceRestartInteraction;
        [NMS(Size = 7, Ignore = true)]
        /* 0x1A9 */ public byte[] Padding1A9;
        [NMS(Size = 0x10)]
        /* 0x1B0 */ public string HasReward;
        [NMS(Size = 0x20)]
        /* 0x1C0 */ public string NextOption;
        /* 0x1E0 */ public GcScanEventTriggers TriggerActions;
        /* 0x200 */ public List<NMSString0x100> UAsList;
        /* 0x210 */ public GcTechnologyCategory TechShopType;
        [NMS(Size = 0x20)]
        /* 0x214 */ public string OSDMessage;
        [NMS(Size = 0x20)]
        /* 0x234 */ public string InterstellarOSDMessage;
        [NMS(Size = 0x20)]
        /* 0x254 */ public string MarkerLabel;
        /* 0x274 */ public TkTextureResource MarkerIcon;
        /* 0x2F8 */ public float StartTime;
        /* 0x2FC */ public float MessageTime;
        /* 0x300 */ public float MessageDisplayTime;
        /* 0x304 */ public GcAudioWwiseEvents MessageAudio;
        /* 0x308 */ public float IconTime;
        /* 0x30C */ public float TooltipTime;
        /* 0x310 */ public bool TooltipRepeats;
        /* 0x311 */ public bool ShowEndTooltip;
        [NMS(Size = 0x20)]
        /* 0x312 */ public string TooltipMessage;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x332 */ public byte[] Padding332;
        /* 0x338 */ public GcResourceElement ResourceOverride;
    }
}