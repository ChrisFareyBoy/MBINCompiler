using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x138, GUID = 0x4B73FA0EFD8A48AE, NameHash = 0x1232AC16AD2DF95C)]
    public class GcCreatureCrystalMovementDataParams : NMSTemplate
    {
        /* 0x00 */ public List<GcBiomeSubType> ValidBiomes;
        /* 0x10 */ public List<NMSString0x10> ValidDescriptors;
        /* 0x20 */ public int NumShards;
        /* 0x24 */ public bool UseTerrainAngle;
        /* 0x25 */ public bool ScaleOnAppear;
        /* 0x28 */ public GcAudioWwiseEvents CreationAudio;
        /* 0x2C */ public float SpawnDist;
        /* 0x30 */ public float DespawnDist;
        /* 0x34 */ public float MaxOffset;
        /* 0x38 */ public float MaxOffsetZ;
        /* 0x3C */ public float MaxTilt;
        /* 0x40 */ public float OffsetTilt;
        /* 0x44 */ public float MinScale;
        /* 0x48 */ public float MaxScale;
        /* 0x4C */ public float MinAppearTime;
        /* 0x50 */ public float MaxAppearTime;
        /* 0x54 */ public float AppearOvershoot;
        /* 0x58 */ public float MinDisappearTime;
        /* 0x5C */ public float MaxDisappearTime;
        /* 0x60 */ public float ShowOffset;
        /* 0x64 */ public float HideOffset;
        /* 0x68 */ public float MinShowTime;
        /* 0x6C */ public bool CustomHideCurve;
        /* 0x70 */ public TkCurveType HideCurve;
        /* 0x74 */ public float IdleSpeedModifier;
        /* 0x78 */ public float WalkSpeedModifier;
        /* 0x7C */ public float RunSpeedModifier;
        /* 0x80 */ public float ParticleScale;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x84 */ public byte[] Padding84;
        [NMS(Size = 0x10)]
        /* 0x88 */ public string DustEffect;
        /* 0x98 */ public GcAudioWwiseEvents Audio;
        /* 0x9C */ public GcAudioWwiseEvents RetractAudio;
        /* 0xA0 */ public GcAudioWwiseEvents MoveStartAudio;
        /* 0xA4 */ public GcAudioWwiseEvents MoveStopAudio;
        /* 0xA8 */ public float DeathFadeStart;
        /* 0xAC */ public float DeathFadeTime;
        public enum DeathTypeEnum { Explode, Drop}
        /* 0xB0 */ public DeathTypeEnum DeathType;
        public enum SubTypeEnum { Crystal, Tentacle}
        /* 0xB4 */ public SubTypeEnum SubType;
        [NMS(Size = 0x20)]
        /* 0xB8 */ public string TentacleStartJoint;
        [NMS(Size = 0x20)]
        /* 0xD8 */ public string TentacleEndJoint;
        /* 0xF8 */ public float TentacleSpeed;
        /* 0xFC */ public float TentacleChurnSpeed;
        /* 0x100 */ public float TentacleIdleLookChance;
        /* 0x104 */ public float TentacleStretchMin;
        /* 0x108 */ public float TentacleStretchMax;
        /* 0x10C */ public float TentacleMoveSwingAngle;
        /* 0x110 */ public float TentacleWalkSwingSpeed;
        /* 0x114 */ public float TentacleRunSwingSpeed;
        /* 0x118 */ public float TentacleRotationApplyBase;
        /* 0x11C */ public float TentacleRotationApplyTip;
        /* 0x120 */ public float TentacleMoveTimeMin;
        /* 0x124 */ public float TentacleMoveTimeMax;
        /* 0x128 */ public float TentaclePitchRange;
        /* 0x12C */ public float TentacleYawRange;
        /* 0x130 */ public float TentacleRollRange;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x134 */ public byte[] EndPadding;
    }
}
