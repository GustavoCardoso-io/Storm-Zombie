using UnityEngine;
using UnityEngine.UI;
using Weapons;

namespace WeponsUI
{
    public class SetWeponUI : MonoBehaviour
    {
         public  DataWeapons DataWeapons;
         public Text weponBulletCount =  null;
         public Text weaponName = null;
         public Image weaponSprite = null;
        void Start()
        {
         weponBulletCount.text = DataWeapons.weaponAtual.bulletAtual.ToString();
          weaponName.text = DataWeapons.weaponAtual.nome;
          weaponSprite.sprite = DataWeapons.weaponAtual.weaponSprite;
        }

        public void SetUiInteraction()
        {
    
        weponBulletCount.text = DataWeapons.weaponAtual.bulletAtual.ToString();
        weaponName.text = DataWeapons.weaponAtual.nome;
        weaponSprite.sprite = DataWeapons.weaponAtual.weaponSprite;

        }  
    }
};