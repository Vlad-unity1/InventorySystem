using EffectApply;
using ItemScriptable;
using PlayerStats;
using UnityEngine;

namespace Armor 
{
    [CreateAssetMenu(fileName = "ArmorItemData", menuName = "ScriptableObjects/ArmorItemData", order = 56)]
    public class ArmorEffect : ItemData, IEffect
    {
        public void Apply(Player player)
        {
            player.EquipArmor(this);
        }
    }
}