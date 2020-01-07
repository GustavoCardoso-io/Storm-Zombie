using UnityEngine;
using UnityEngine.UI;
using Weapons;

namespace WeponsUI
{
    public class SetWeponUI : MonoBehaviour
    {
        public DataWeapons DataWeapons = null;
        public Text weponBulletCount = null;
        public Text weaponName = null;
        public Image weaponSprite = null;
        private void Awake()
        {
            DataWeapons = GameObject.FindGameObjectWithTag("DataWeapon").GetComponent<DataWeapons>();
        }
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