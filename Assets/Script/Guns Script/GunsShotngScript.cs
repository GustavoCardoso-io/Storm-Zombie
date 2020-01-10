using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapons;
using WeponsUI;
public class GunsShotngScript : MonoBehaviour
{
    public DataWeapons dw = null;
    [SerializeField]
    private SetWeponUI sw = null;
    [SerializeField] private GameObject spawnPosition = null;
    [SerializeField] private GameObject projetil = null;

    private void Start()
    {
        dw = GameObject.FindGameObjectWithTag("DataWeapon").GetComponent<DataWeapons>();
    }
    public void Shoting()
    {
        if (dw.weaponAtual.bulletAtual > 0)
        {
            Instantiate(projetil, spawnPosition.transform.position, Quaternion.identity);
            dw.weaponAtual.bulletAtual -= 1;
            sw.SetUiInteraction();
        }
        else
        {
            StartCoroutine(WaitForReload());
            Debug.Log("Sem Munição");
        }
    }
    private IEnumerator WaitForReload()
    {
        yield return new WaitForSeconds(2.0f);
        Reload();
        sw.SetUiInteraction();
        Debug.Log("Carregando...");
        StopCoroutine(WaitForReload());
    }
    private void Reload()
    {
        dw.weaponAtual.bulletAtual = dw.weaponAtual.maxBullet;
    }
}
