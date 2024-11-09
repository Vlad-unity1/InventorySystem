using EffectApply;
using ItemScriptable;
using PlayerStats;
using UnityEngine;

namespace Weapon
{
    [CreateAssetMenu(fileName = "WeaponItemData", menuName = "ScriptableObjects/WeaponItemData", order = 54)]
    public class WeaponEffect : ItemData, IEffect
    {
        public void Apply(Player player)
        {
            player.EquipWeapon(this);
        }
    }
}