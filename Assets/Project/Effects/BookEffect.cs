using EffectApply;
using ItemScriptable;
using PlayerStats;
using System;
using UnityEngine;

namespace Book
{
    [CreateAssetMenu(fileName = "BookItemData", menuName = "ScriptableObjects/BookItemData", order = 55)]
    public class BookEffect : ItemData, IEffect
    {
        [SerializeField] private bool _isRead = false;
        [field: SerializeField] public int EXP { get; private set; }

        public void Apply(Player player)
        {
            if (!_isRead)
            {
                _isRead = true;
                player.Expirience(EXP);
            }
            else
            {
                Console.WriteLine("isUsed.");
            }
        }
    }
}