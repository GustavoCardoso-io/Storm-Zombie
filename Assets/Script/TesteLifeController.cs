using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayerControler;

public class TesteLifeController : MonoBehaviour
{
    DataPlayer dataPlayer;
    public Transform lifeBar = null;

    public float sizeXBarStatus;
    private void Start()
    {
        dataPlayer = GameObject.FindGameObjectWithTag("DataPlayer").GetComponent<DataPlayer>();
        sizeXBarStatus = lifeBar.localScale.x;
        
    }

    void SetLifeConrollerBar(){
        sizeXBarStatus = sizeXBarStatus*dataPlayer.GetLifePlayer()/5f;
        lifeBar.localScale=  new Vector2(sizeXBarStatus,0.4f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enimigo")
        {
            dataPlayer.SetLifePlayer(1f);
            SetLifeConrollerBar();
        }
    }

}
