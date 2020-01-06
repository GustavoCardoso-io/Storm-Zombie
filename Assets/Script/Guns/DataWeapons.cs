using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapons
{  
    public class DataWeapons : MonoBehaviour
    { 
        public Weapon[] weapons; 
        public Weapon weaponAtual;
         private void Awake()
        {
            weaponAtual = weapons[1];
        }
        public void GetWepon(int idWeapon)
        {
         for(int i = 0; i < weapons.Length; i++) 
         {
          if( weapons[i].idWeapon == idWeapon)
          {
              weaponAtual = weapons[i];
          }
         }
        }
        public string  GetName()
        {
            return weaponAtual.nome;
        }
        public int GetMaxBullet()
        {
            return weaponAtual.maxBullet;
        }
        public int GetIdWeapon()
        {
            return weaponAtual.idWeapon;
        }
        public int GetBulletAtual()
        {
            return weaponAtual.bulletAtual;
        }
        public Sprite GetWeaponSprite()
        {
            return weaponAtual.weaponSprite;
        }
        public Weapon GetWeapon()
        {
            return weaponAtual;
        }
    }
};
