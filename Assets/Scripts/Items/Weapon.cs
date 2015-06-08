using Assets.Scripts.Items.Enums;
using UnityEngine;

namespace Assets.Scripts.Items
{
	public class Weapon : Item
	{
		public WeaponTypeDefines Type;
		public int Power;
	    public int Range;
	    public int Spray;
	    public bool Explosive;
	    public Sprite WeaponModel;
	    public Vector3 Knockback;
		
		public Weapon(string name, int id, string desc, int value, WeaponTypeDefines type, int power, int range, int spray, string iconpath, string modelpath, int knockbackX, int knockbackY)
		{
			ItemName = name;
			ItemId = id;
			ItemDesc = desc;
			ItemValue = value;
			Type = type;
			Power = power;
		    Range = range;
		    Spray = spray;
			ItemIcon = Resources.Load<Sprite>(iconpath);
            WeaponModel = Resources.Load<Sprite>(modelpath);
            Knockback = new Vector3(knockbackX, knockbackY);
		}


	    public Weapon()
		{
			
		}
	}
}
