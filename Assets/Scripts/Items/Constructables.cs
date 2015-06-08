using Assets.Scripts.Items.Enums;

namespace Assets.Scripts.Items
{

    public class WeaponConstructed
    {
        public string ItemName;
        public int ItemId;
        public string ItemDesc;
        public int ItemValue;
        public WeaponTypeDefines WeaponType;
        public int WeaponStrength;
        public string ItemIcon;
        public string WeaponSprite;
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
