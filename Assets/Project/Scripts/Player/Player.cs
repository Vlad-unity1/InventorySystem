﻿using Armor;
using UnityEngine;
using Weapon;

namespace PlayerStats
{
    public class Player
    {
        public int CurrentHP { get; private set; }
        public int MaxHP { get; private set; }
        public int Exp { get; private set; }

        public void Heal(int amount)
        {
            CurrentHP += amount;
        }

        public void EquipWeapon(WeaponEffect weapon)
        {
            Debug.Log($"WeaponEffect {weapon} equip.");
        }

        public void EquipArmor(ArmorEffect armor)
        {

            Debug.Log($"ArmorEffect {armor} equip.");
        }

        public void Experience(int experience)
        {
            Exp += experience;
        }
    }
}
