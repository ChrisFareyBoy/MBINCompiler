﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x400, GUID = 0xFF00FFEE7B6EA198, NameHash = 0xE831C8A241FD8276)]
    public class GcProductData : NMSTemplate
    {
        [NMSDescription("Internal item name. This is the ID that will be used to refer to this product in other files (eg. rewardtable)")]
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Id;
        [NMSDescription("Uppercase item real name. This name is referenced in each language file for translation")]
        [NMS(Size = 0x80)]
        /* 0x010 */ public string Name;
        [NMSDescription("Lowercase item real name. This name is referenced in each language file for translation")]
        [NMS(Size = 0x80)]
        /* 0x090 */ public string NameLower;
        [NMSDescription("Item subtitle. This string is referenced in each language file for translation")]
        /* 0x110 */ public VariableSizeString Subtitle;
        [NMSDescription("Item description. This string is referenced in each language file for translation")]
        /* 0x120 */ public VariableSizeString Description;
        [NMS(Size = 0x20)]
        /* 0x130 */ public string Hint;
        [NMS(Size = 0x10)]
        /* 0x150 */ public string GroupID;
        /* 0x160 */ public TkModelResource DebrisFile;
        [NMSDescription("Base item value in units")]
        /* 0x1E4 */ public int BaseValue;
        /* 0x1E8 */ public int Level;
        [NMSDescription("Item icon texture path")]
        /* 0x1EC */ public TkModelResource Icon;
        /* 0x270 */ public TkModelResource HeroIcon;
        [NMSDescription("Icon background colour. Applies under icon transparent parts")]
        /* 0x300 */ public Colour Colour;
        /* 0x310 */ public GcRealitySubstanceCategory SubstanceCategory;
        /* 0x314 */ public GcProductCategory Type;
        /* 0x318 */ public GcRarity Rarity;
        /* 0x31C */ public GcLegality Legality;
        /* 0x320 */ public bool Consumable;
        /* 0x324 */ public int ChargeValue;
        /* 0x328 */ public int StackMultiplier;
        /* 0x32C */ public int DefaultCraftAmount;
        /* 0x330 */ public int CraftAmountStepSize;
        /* 0x334 */ public int CraftAmountMultiplier;
        /* 0x338 */ public List<GcTechnologyRequirement> Requirements;
        /* 0x348 */ public List<GcTechnologyRequirement> AltRequirements;
        /* 0x358 */ public GcItemPriceModifiers Cost;
        /* 0x36C */ public int RecipeCost;
        /* 0x370 */ public bool SpecificChargeOnly;
        /* 0x374 */ public float NormalisedValueOnWorld;
        /* 0x378 */ public float NormalisedValueOffWorld;
        /* 0x37C */ public GcTradeCategory TradeCategory;
        public enum WikiCategoryEnum { NotEnabled, Crafting, Tech, Construction, Trade, Curio, Cooking }
        /* 0x380 */ public WikiCategoryEnum WikiCategory;
        /* 0x384 */ public bool IsCraftable;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x385 */ public byte[] Padding385;
        [NMS(Size = 0x10)]
        /* 0x388 */ public string DeploysInto;
        /* 0x398 */ public float EconomyInfluenceMultiplier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x39C */ public byte[] Padding39C;
        [NMSDescription("Notification when this substance has to be crafted. This string is referenced in each language file for translation")]
        [NMS(Size = 0x20)]
        /* 0x3A0 */ public string PinObjeective;
        [NMSDescription("Notification hints to collect this item. This string is referenced in each language file for translation")]
        [NMS(Size = 0x20)]
        /* 0x3C0 */ public string PinObjeectiveTip;
        /* 0x3E0 */ public bool CookingIngredient;
        /* 0x3E4 */ public float CookingValue;
        /* 0x3E8 */ public bool GoodForSelling;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x3E9 */ public byte[] Padding3E9;
        [NMS(Size = 0x10)]
        /* 0x3F0 */ public string GiveRewardOnSpecialPurchase;
    }
}
