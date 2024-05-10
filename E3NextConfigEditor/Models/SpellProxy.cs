﻿using E3Core.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace E3NextConfigEditor.Models
{
	public class SpellProxy
	{
		private Spell _spell;
		public SpellProxy(E3Core.Data.Spell spell) 
		{
			_spell = spell;
		
		}
		[Category("Spell Data")]
		[Description("Spell Name")]
		public string SpellName
		{
			get { return _spell.SpellName; }
			
		}
		[Category("Spell Data")]
		[Description("Icon assoicated with the spell data")]
		public Int32 SpellIcon
		{
			get { return _spell.SpellIcon; }

		}
		[Category("Spell Data")]
		[Description("Description")]
		public String Description
		{
			get { return _spell.Description; }

		}
		[Category("Spell Data")]
		[Description("ResistType")]
		public String ResistType
		{
			get { return _spell.ResistType; }

		}
		[Category("Spell Data")]
		[Description("Resist Adjustment")]
		public Int32 ResistAdj
		{
			get { return _spell.ResistAdj; }

		}
		[Category("Spell Data")]
		[Description("Level")]
		public Int32 Level
		{
			get { return _spell.Level; }

		}
		[Category("Flags")]
		[Description("Prevent this from being interrupted")]
		public bool NoInterrupt
		{
			get { return _spell.NoInterrupt; }
			set { _spell.NoInterrupt = value; }
		}
		[Category("Flags")]
		[Description("Ifs Keys to be used, comma seperated")]
		public string IfsKeys
		{
			get { return _spell.IfsKeys; }
			set { _spell.IfsKeys = value; }
		}
		
		[Category("Flags")]
		[Description("Check for, comma seperated. For Detremental it is the debuff on the mob. For Buffs/songs its the buff on you.")]
		public string CheckFor
		{
			get { return String.Join(",", _spell.CheckForCollection.Keys.ToList()); }
			set
			{
				if(!String.IsNullOrWhiteSpace(value))
				{
					string[] splitArray = value.Split(',');
					_spell.CheckForCollection.Clear();
					foreach(var spell in splitArray)
					{
						_spell.CheckForCollection.Add(spell, 0);
					}
				}
				else
				{
					_spell.CheckForCollection.Clear();
				}
			}
		}
		[Category("Spell Gem Flags")]
		[Description("Spell Gem")]
		public Int32 SpellGem
		{
			get { return _spell.SpellGem; }
			set { _spell.SpellGem = value; }
		}
		[Category("Spell Target Flags")]
		[Description("Spell Target. Self or Name of toon is valid")]
		public String CastTarget
		{
			get { return _spell.CastTarget; }
			set { _spell.CastTarget = value; }
		}

		[Category("Flags")]
		[Description("After Spell Name, follows normal heircy rules")]
		public string AfterSpell
		{
			get { return _spell.AfterSpell; }
			set { _spell.AfterSpell = value; }
		}
		[Category("Flags")]
		[Description("Before Spell Name, follows normal heircy rules")]
		public string BeforeSpell
		{
			get { return _spell.BeforeSpell; }
			set { _spell.BeforeSpell = value; }
		}
		[Category("Flags")]
		[Description("After Event Name, follows normal heircy rules")]
		public string AfterEvent
		{
			get { return _spell.AfterEvent; }
			set { _spell.AfterEvent = value; }
		}
		[Category("Flags")]
		[Description("Before Event Name, follows normal heircy rules")]
		public string BeforeEvent
		{
			get { return _spell.BeforeEvent; }
			set { _spell.BeforeEvent = value; }
		}
		[Category("Flags")]
		[Description("Zone to Enable in. Honetly not sure this works!")]
		public string Zone
		{
			get { return _spell.Zone; }
			set { _spell.Zone = value; }
		}
		[Category("Heal Flags")]
		[Description("For heals, Heal Percentage you start casting")]
		public Int32 HealPct
		{
			get { return _spell.HealPct; }
			set { _spell.HealPct = value; }
		}
		[Category("Heal Flags")]
		[Description("For Heals, cancel heal if above this health level")]
		public Int32 HealthMax
		{
			get { return _spell.HealthMax; }
			set { _spell.HealthMax = value; }
		}
		[Category("Cure Flags")]
		[Description("Min sickness before cast, only used for cures")]
		public Int32 MinSick
		{
			get { return _spell.MinSick; }
			set { _spell.MinSick = value; }
		}
		[Category("Flags")]
		[Description("Minimum mana level before try and cast the spell")]
		public Int32 MinMana
		{
			get { return _spell.MinMana; }
			set { _spell.MinMana = value; }
		}
		[Category("Flags")]
		[Description("Don't cast spell if you are above this mana level")]
		public Int32 MaxMana
		{
			get { return _spell.MaxMana; }
			set { _spell.MaxMana = value; }
		}
		[Category("Flags")]
		[Description("Min endurance before you try and cast an ability")]
		public Int32 MinEnd
		{
			get { return _spell.MinEnd; }
			set { _spell.MinEnd = value; }
		}
		[Category("Flags")]
		[Description("Don't use internal stacking rules for debuffs")]
		public bool IgnoreStackRules
		{
			get { return _spell.IgnoreStackRules; }
			set { _spell.IgnoreStackRules = value; }
		}
		[Category("Flags")]
		[Description("Cast if this debuff/debuff exists")]
		public string CastIf
		{
			get { return _spell.CastIF; }
			set { _spell.CastIF = value; }
		}
		[Category("Flags")]
		[Description("Cast type, valid are Spell/AA/Item/Disc")]
		public string CastType
		{
			get { return _spell.CastType.ToString(); }
			set { Enum.TryParse(value,true,out _spell.CastType); }
		}

	}
	public class SpellDataProxy
	{
		private SpellData _spell;
		public SpellDataProxy(SpellData spell)
		{
			_spell = spell;

		}
		[Category("Spell Data")]
		[Description("Spell Name")]
		public string SpellName
		{
			get { return _spell.SpellName; }

		}
		[Category("Spell Data")]
		[Description("Icon assoicated with the spell data")]
		public Int32 SpellIcon
		{
			get { return _spell.SpellIcon; }

		}
		[Category("Spell Data")]
		[Description("Description")]
		public String Description
		{
			get { return _spell.Description; }

		}
		[Category("Spell Data")]
		[Description("ResistType")]
		public String ResistType
		{
			get { return _spell.ResistType; }

		}
		[Category("Spell Data")]
		[Description("Resist Adjustment")]
		public Int32 ResistAdj
		{
			get { return _spell.ResistAdj; }

		}
		[Category("Spell Data")]
		[Description("Level")]
		public Int32 Level
		{
			get { return _spell.Level; }

		}
		[Category("Flags")]
		[Description("Prevent this from being interrupted")]
		public bool NoInterrupt
		{
			get { return _spell.NoInterrupt; }
			set { _spell.NoInterrupt = value; }
		}
		[Category("Flags")]
		[Description("Ifs Keys to be used, comma seperated")]
		public string IfsKeys
		{
			get { return _spell.IfsKeys; }
			set { _spell.IfsKeys = value; }
		}

		[Category("Flags")]
		[Description("Check for, comma seperated. For Detremental it is the debuff on the mob. For Buffs/songs its the buff on you.")]
		public string CheckFor
		{
			get { return String.Join(",", _spell.CheckForCollection.ToList()); }
			set
			{
				if (!String.IsNullOrWhiteSpace(value))
				{
					string[] splitArray = value.Split(',');
					_spell.CheckForCollection.Clear();
					foreach (var spell in splitArray)
					{
						_spell.CheckForCollection.Add(spell);
					}
				}
				else
				{
					_spell.CheckForCollection.Clear();
				}
			}
		}
		[Category("Spell Gem Flags")]
		[Description("Spell Gem")]
		public Int32 SpellGem
		{
			get { return _spell.SpellGem; }
			set { _spell.SpellGem = value; }
		}
		[Category("Spell Target Flags")]
		[Description("Spell Target. Self or Name of toon is valid")]
		public String CastTarget
		{
			get { return _spell.CastTarget; }
			set { _spell.CastTarget = value; }
		}
		[Category("Flags")]
		[Description("After Spell Name, follows normal heircy rules")]
		public string AfterSpell
		{
			get { return _spell.AfterSpell; }
			set { _spell.AfterSpell = value; }
		}
		[Category("Flags")]
		[Description("Before Spell Name, follows normal heircy rules")]
		public string BeforeSpell
		{
			get { return _spell.BeforeSpell; }
			set { _spell.BeforeSpell = value; }
		}
		[Category("Flags")]
		[Description("After Event Name, follows normal heircy rules")]
		public string AfterEvent
		{
			get { return _spell.AfterEvent; }
			set { _spell.AfterEvent = value; }
		}
		[Category("Flags")]
		[Description("Before Event Name, follows normal heircy rules")]
		public string BeforeEvent
		{
			get { return _spell.BeforeEvent; }
			set { _spell.BeforeEvent = value; }
		}
		[Category("Flags")]
		[Description("Zone to Enable in. Honetly not sure this works!")]
		public string Zone
		{
			get { return _spell.Zone; }
			set { _spell.Zone = value; }
		}
		[Category("Heal Flags")]
		[Description("For heals, Heal Percentage you start casting")]
		public Int32 HealPct
		{
			get { return _spell.HealPct; }
			set { _spell.HealPct = value; }
		}
		[Category("Heal Flags")]
		[Description("For Heals, cancel heal if above this health level")]
		public Int32 HealthMax
		{
			get { return _spell.HealthMax; }
			set { _spell.HealthMax = value; }
		}
		[Category("Cure Flags")]
		[Description("Min sickness before cast, only used for cures")]
		public Int32 MinSick
		{
			get { return _spell.MinSick; }
			set { _spell.MinSick = value; }
		}
		[Category("Flags")]
		[Description("Minimum mana level before try and cast the spell")]
		public Int32 MinMana
		{
			get { return _spell.MinMana; }
			set { _spell.MinMana = value; }
		}
		[Category("Flags")]
		[Description("Don't cast spell if you are above this mana level")]
		public Int32 MaxMana
		{
			get { return _spell.MaxMana; }
			set { _spell.MaxMana = value; }
		}
		[Category("Flags")]
		[Description("Min endurance before you try and cast an ability")]
		public Int32 MinEnd
		{
			get { return _spell.MinEnd; }
			set { _spell.MinEnd = value; }
		}
		[Category("Flags")]
		[Description("Don't use internal stacking rules for debuffs")]
		public bool IgnoreStackRules
		{
			get { return _spell.IgnoreStackRules; }
			set { _spell.IgnoreStackRules = value; }
		}
		[Category("Flags")]
		[Description("Cast if this debuff/debuff exists")]
		public string CastIf
		{
			get { return _spell.CastIF; }
			set { _spell.CastIF = value; }
		}
		[Category("Flags")]
		[Description("Cast type, valid are Spell/AA/Item/Disc")]
		public string CastType
		{
			get { return _spell.CastType.ToString(); }
			set
			{
				CastingType tempType = CastingType.None;
				if(Enum.TryParse(value, true, out tempType))
				{
					_spell.CastType = (SpellData.Types.CastingType)tempType;
				}

			}
		}

	}
	public class SpellRequestDataProxy:SpellProxy
	{
		private SpellRequest _spell;

		public SpellRequestDataProxy(SpellRequest spell) : base(spell)
		{
			_spell = spell;

		}
	}
}
