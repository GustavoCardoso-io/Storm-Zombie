using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ProjetilScript : MonoBehaviour
{
     private float velocidadeProjetil = 100.0f;
    private void Start()
    {
        Transform player;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        float playerLookAt = player.lossyScale.x;
        Vector2 movement = new Vector2(1, 0);
        Rigidbody2D rbShoot = GetComponent<Rigidbody2D>();
        rbShoot.AddForce((movement * playerLookAt) * velocidadeProjetil);
        
    }
    void FixedUpdate()
    {
        DestroyProjetil();
    }
    void DestroyProjetil()
    {
        Destroy(this.gameObject, 5f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enimigo" || other.gameObject.tag == "ForaDoMapa")
        {
            Destroy(this.gameObject);
        }    
    }

}
