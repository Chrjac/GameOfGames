using Assets.Scripts.Items.Enums;

namespace Assets.Scripts.Items
{
    //Vi lager disse når vi leser fra json

    public class WeaponConstructed
    {
        public string ItemName;
        public int ItemId;
        public string ItemDesc;
        public int ItemValue;
        public WeaponTypeDefines WeaponType;
        public int Power;
        public int Range;
        public int Spray;
        public string ItemIcon;
        public string WeaponModelpath;
        public int KnockbackX;
        public int KnockbackY;
        public string ProjectilePath;
    }

    public class ConsumableConstructed
    {
        public string ItemName;
        public int ItemId;
        public string ItemDesc;
        public int ItemValue;
        public ConsumableTypeDefines ConsumableType;
        public int AppendValue;
        public string ItemIcon;
    }
}
