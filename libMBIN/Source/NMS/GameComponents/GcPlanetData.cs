using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3D80, GUID = 0x5E2ACA9D52277BA4, NameHash = 0x25EDFA0EC4C3AF0A)]
    public class GcPlanetData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x0000 */ public string Name;
        /* 0x0080 */ public GcPlanetLife Life;
        /* 0x0084 */ public GcPlanetLife CreatureLife;
        /* 0x0088 */ public GcPlanetHazardData Hazard;
        public enum ResourceLevelEnum { Low, High }
        /* 0x00D8 */ public ResourceLevelEnum ResourceLevel;
        /* 0x00DC */ public GcBuildingDensityLevels BuildingLevel;
        [NMS(Size = 0x10)]
        /* 0x00E0 */ public string CommonSubstanceID;
        [NMS(Size = 0x10)]
        /* 0x00F0 */ public string UncommonSubstanceID;
        [NMS(Size = 0x10)]
        /* 0x0100 */ public string RareSubstanceID;
        /* 0x0110 */ public List<GcPlanetDataResourceHint> ExtraResourceHints;
        /* 0x0120 */ public GcPlanetColourData Colours;
        [NMS(Size = 0x17)]
        /* 0x1930 */ public Colour[] TileColours;
        /* 0x1AA0 */ public GcPlanetWeatherData Weather;
        /* 0x1BF0 */ public GcPlanetCloudProperties Clouds;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x1C38 */ public byte[] Padding1C38; 
        /* 0x1C40 */ public GcPlanetWaterData Water;
        [NMS(Size = 0x80)]
        /* 0x1DC0 */ public string TerrainFile;
        /* 0x1E40 */ public TkVoxelGeneratorData Terrain;
        /* 0x3410 */ public int TileTypeSet;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3414 */ public byte[] Padding3414; 
        /* 0x3418 */ public List<int> TileTypeIndices;
        /* 0x3428 */ public GcEnvironmentSpawnData SpawnData;
        /* 0x3488 */ public GcAlienRace InhabitingRace;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x348C */ public byte[] Padding348C; 
        /* 0x3490 */ public GcPlanetBuildingData BuildingData;
        /* 0x3500 */ public GcPlanetGenerationIntermediateData GenerationData;
        /* 0x3968 */ public Vector2f SentinelTimer;
        /* 0x3970 */ public Vector2f FlybyTimer;
        /* 0x3978 */ public GcPlanetInfo PlanetInfo;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x3CFB */ public byte[] Padding3CFB; 
        /* 0x3CFC */ public GcPlanetSentinelData SentinelData;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x3D04 */ public byte[] Padding3D04; 
        /* 0x3D10 */ public GcPlanetRingData Rings;
        /* 0x3D70 */ public bool InEmptySystem;
        /* 0x3D74 */ public float FuelMultiplier;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x3D78 */ public byte[] EndPadding;

    }
}
