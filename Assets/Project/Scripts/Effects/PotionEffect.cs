using EffectApply;
using ItemScriptable;
using PlayerStats;
using UnityEngine;

namespace Potion
{
    [CreateAssetMenu(fileName = "PotionItemData", menuName = "ScriptableObjects/PotionItemData", order = 53)]
    public class PotionEffect : ItemData, IEffect
    {
        [field: SerializeField] public int HealthAmount { get; private set; }

        public void Apply(Player player)
        {
            player.Heal(HealthAmount);
        }
    }
}
