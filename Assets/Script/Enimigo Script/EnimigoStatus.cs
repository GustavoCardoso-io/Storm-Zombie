using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerControler;
public class EnimigoStatus : MonoBehaviour
{
    public DataPlayer dataPlayer = null;
    static public EnimigoStatus instance;
    [SerializeField] private int vida = 1;
    [SerializeField] private float velocidadeEnimgo = 1f;
    public int Vida { get => vida; set => vida = value; }
    public float VelocidadeEnimgo { get => velocidadeEnimgo; set => velocidadeEnimgo = value; }
    private void Awake()
    {
        MakeInstance();
        dataPlayer = GameObject.FindGameObjectWithTag("DataPlayer").GetComponent<DataPlayer>();
    }
    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void DecreaseLife(int lifeDescrease)
    {
        if (vida > 0)
        {
            vida -= lifeDescrease;
        }
        else
        {
            dataPlayer.SetPlayerPontos();
            dataPlayer.SetScorePointPlayer();
            Destroy(gameObject);
        }
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
