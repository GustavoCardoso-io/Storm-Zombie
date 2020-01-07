using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnimigoOnTriggerEnter : MonoBehaviour
{
    public EnimigoStatus instance;
    private void Awake()
    {
        instance = gameObject.GetComponent<EnimigoStatus>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Projetils")
        {
            instance.DecreaseLife(1);
            Debug.Log("HIT ENIMIGO");
        }
    }
}
