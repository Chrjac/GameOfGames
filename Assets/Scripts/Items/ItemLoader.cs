using System.Collections.Generic;
using System.IO;
using Assets.Scripts.Items.Enums;
using LitJson;
using UnityEngine;

namespace Assets.Scripts.Items
{
    public class ItemLoader : MonoBehaviour
    {

        public List<Item> Items = new List<Item>();

        void Start()
        {
            var weaponlist = FillFromJson<WeaponConstructed>("Assets\\Scripts\\Items\\Storage\\weapondatabase.json");
            var consumableList = FillFromJson<ConsumableConstructed>("Assets\\Scripts\\Items\\Storage\\consumabledatabase.json");

            foreach (var weapon in weaponlist)
            {
                Items.Add(new Weapon(weapon.ItemName, weapon.ItemId, weapon.ItemDesc, weapon.ItemValue, weapon.WeaponType,
                    weapon.Power, weapon.Range, weapon.Spray, weapon.ItemIcon, weapon.WeaponModelpath, weapon.KnockbackX, weapon.KnockbackY));
                
            }

            foreach (var consumable in consumableList)
            {
                Items.Add(new Consumable(consumable.ItemName, consumable.ItemId, consumable.ItemDesc, consumable.ItemValue, consumable.ConsumableType, consumable.AppendValue, consumable.ItemIcon));
            }
        }

        public List<T> FillFromJson<T>(string path)
        {
            var fullpath = Path.GetFullPath(path);
            var json = File.ReadAllText(fullpath);
            return JsonMapper.ToObject<List<T>>(json);
        }
    }
}
