﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x4A0, Alignment = 0x10, GUID = 0xB55CC0128EA807DC, NameHash = 0xE39CB7AA4D818260)]
    public class TkMaterialMetaData : NMSTemplate {

        [NMS(Size = 0x80)]
        /* 0x000 */ public string ExternalMaterial;
		public enum ShaderEnum { UberShader, Sky, Screen, UberHack, UIScreen, SketchParticle, SketchUber }
		/* 0x080 */ public ShaderEnum Shader;
        /* 0x084 */ public bool Transparent;
        /* 0x088 */ public int TransparencyLayerID;
        /* 0x08C */ public bool Additive;
        /* 0x08D */ public bool VertexColour;
        /* 0x08E */ public bool DisableZTest;
        /* 0x08F */ public bool Unlit;
        /* 0x090 */ public bool ReceiveShadow;
        /* 0x091 */ public bool CastShadow;
        /* 0x092 */ public bool ShadowOnly;
        /* 0x093 */ public bool UISurface;
        /* 0x094 */ public float Roughness;
        /* 0x098 */ public bool RoughnessMask;
        /* 0x099 */ public bool Metallic;
        /* 0x09A */ public bool MetallicMask;
        /* 0x09B */ public bool SubsurfaceMask;
        /* 0x09C */ public bool ParallaxMapped;
        /* 0x09D */ public bool RefractionMap;
        [NMS(Size = 0x80)]
        /* 0x09E */ public string ForceDiffuse;
        [NMS(Size = 0x80)]
        /* 0x11E */ public string ForceNormal;
        [NMS(Size = 0x80)]
        /* 0x19E */ public string ForceMask;
        [NMS(Size = 0x80)]
        /* 0x21E */ public string DetailDiffuse;
        [NMS(Size = 0x80)]
        /* 0x29E */ public string DetailNormal;
        /* 0x320 */ public float DetailTiling;
        /* 0x324 */ public float MultiplyDetailTiling;
        /* 0x328 */ public int DetailImages;
        /* 0x32C */ public int MultiplyDetailImages;
        /* 0x330 */ public bool AOMap;
        /* 0x331 */ public bool MultiplySecondUVSet;
        /* 0x332 */ public bool VertexDetailBlend;
        /* 0x334 */ public float DetailHeightBlend;
        /* 0x338 */ public float NormalTiling;
        /* 0x33C */ public bool SpaceObject;
        /* 0x340 */ public float Glow;
        /* 0x344 */ public bool GlowMask;
        /* 0x345 */ public bool BrightEdge;
        /* 0x346 */ public bool CameraRelative;
        /* 0x347 */ public bool Colourisable;
        /* 0x348 */ public bool ColourMask;
        /* 0x349 */ public bool Multitexture;
        /* 0x34A */ public bool AlphaCutout;
        /* 0x34B */ public bool DetailedAlphaCutout;
        /* 0x34C */ public bool Wind;
        /* 0x34D */ public bool DetailOverlay;
        /* 0x34E */ public bool MatchGroundColour;
        /* 0x350 */ public float TerrainNormalFactor;
        /* 0x354 */ public bool ScreenSpaceFade;
        /* 0x355 */ public bool AcuteAngleFadeOut;
        /* 0x356 */ public bool ClampAmbientLight;
        /* 0x357 */ public bool DoubleSided;
        /* 0x358 */ public bool DecalDiffuse;
		public enum DecalNormalEnum { None, Decal, Vertex }
		/* 0x35C */ public DecalNormalEnum DecalNormal;
        /* 0x360 */ public bool Billboard;
        /* 0x361 */ public bool RotateAroundAt;
        /* 0x362 */ public bool MergedMeshBillboard;
        /* 0x364 */ public float BillboardSphereFactor;
        /* 0x368 */ public bool Imposter;
        /* 0x369 */ public bool ScanEffect;
        /* 0x36A */ public bool WriteLogZ;
        /* 0x36B */ public bool DisableAmbient;
        /* 0x36C */ public bool DisablePostProcess;
        /* 0x36D */ public bool WarpedDiffuseLighting;
        [NMS(Size = 0x20)]
        /* 0x36E */ public string MaterialClass;
        /* 0x38E */ public bool AnisotropicFilter;
        /* 0x390 */ public float TessellationHeight;
        /* 0x394 */ public float ShellsHeight;
        /* 0x398 */ public float FurNoiseScale;
        /* 0x39C */ public float FurNoiseThickness;
        /* 0x3A0 */ public float FurNoiseTurbulence;
        /* 0x3A4 */ public float FurTurbulenceScale;
        /* 0x3A8 */ public bool Dissolve;
        /* 0x3A9 */ public bool InvertAlpha;
        /* 0x3AA */ public bool BeforeUI;
        /* 0x3AB */ public bool DepthMaskUI;
        /* 0x3AC */ public bool AlwaysOnTopUI;
        /* 0x3AD */ public bool StretchyParticle;
        /* 0x3AE */ public bool UVScrolling;
        /* 0x3B0 */ public float UVScrollX;
        /* 0x3B4 */ public float UVScrollY;
        /* 0x3B8 */ public float UVScrollNormalX;
        /* 0x3BC */ public float UVScrollNormalY;
        /* 0x3C0 */ public float UVFrameTime;
        /* 0x3C4 */ public bool UVAnimation;
        /* 0x3C5 */ public bool UVTileAlts;
        /* 0x3C8 */ public float UVNumTilesX;
        /* 0x3CC */ public float UVNumTilesY;
        /* 0x3D0 */ public bool DisplacementWave;
        /* 0x3D1 */ public bool DisplacementPositionOffset;
        /* 0x3D4 */ public float WaveOneSpeed;
        /* 0x3E0 */ public Vector3f WaveOneAmplitude;
        /* 0x3F0 */ public Vector3f WaveOneFrequency;
        /* 0x400 */ public Vector3f WaveOneFallOff;
        /* 0x410 */ public float WaveTwoSpeed;
        /* 0x420 */ public Vector3f WaveTwoAmplitude;
        /* 0x430 */ public Vector3f WaveTwoFrequency;
        /* 0x440 */ public Vector3f WaveTwoFallOff;
        /* 0x450 */ public TkMaterialSketchData SketchData;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x498 */ public byte[] EndPadding;
    }

}
