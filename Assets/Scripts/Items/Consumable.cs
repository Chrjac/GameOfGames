using Assets.Scripts.Items.Enums;
using UnityEngine;

namespace Assets.Scripts.Items
{
	public class Consumable : Item
	{
		public ConsumableTypeDefines ConsumableType;
		public int AppendValue;

		public Consumable(string name, int id, string desc, int value, ConsumableTypeDefines type, int plusvalue, string iconpath)
		{
			ItemName = name;
			ItemId = id;
			ItemDesc = desc;
			ItemValue = value;
			ConsumableType = type;
            AppendValue = plusvalue;
			ItemIcon = Resources.Load<Sprite>(iconpath);
		}

		public Consumable()
		{
			
		}
	}
}
