using ItemStats;
using PlayerStats;
using System.Collections.Generic;

namespace InventorySystem
{
    public class Inventory
    {
        private readonly float _maxWeight;
        private float _currentWeight;
        private readonly Dictionary<Item, int> _items = new();

        public Inventory(float maxWeight)
        {
            _maxWeight = maxWeight;
            _currentWeight = 0;
        }

        private bool AddItem(Item item, int count = 1)
        {
            float itemTotalWeight = item.Weight * count;

            if (_currentWeight + itemTotalWeight > _maxWeight)
            {
                return false;
            }

            if (_items.ContainsKey(item))
            {
                if (item.IsStackable && _items[item] + count <= item.MaxStack)
                {
                    _items[item] += count;
                }
                else if (item.IsStackable && _items[item] + count > item.MaxStack)
                {
                    int remainingCount = (_items[item] + count) - item.MaxStack;
                    _items[item] = item.MaxStack;
                    return AddItem(item, remainingCount);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                _items[item] = count;
            }

            _currentWeight += itemTotalWeight;
            return true;
        }

        private bool RemoveItem(Item item, int count = 1)
        {
            if (_items.ContainsKey(item) && _items[item] >= count)
            {
                _items[item] -= count;
                if (_items[item] == 0) _items.Remove(item);
                _currentWeight -= item.Weight * count;
                return true;
            }

            return false;
        }

        private void UseItem(Item item, Player player) // метод для вьюшки сразу написал
        {
            if (_items.ContainsKey(item) && _items[item] > 0)
            {
                item.Effect.Apply(player);
                RemoveItem(item, 1);
            }
        }
    }
}