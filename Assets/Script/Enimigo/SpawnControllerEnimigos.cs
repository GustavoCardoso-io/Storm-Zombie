using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControllerEnimigos : MonoBehaviour
{
    public GameObject[] EnimigosEasy = null;
    public int currentEnimigosSpawn = 3;
    public float waitForSpawnWaveEnimies = 5f;
    public float waitForSpawnEnimiesWave = 1f;
    void Start()
    {
        StartCoroutine(SpawnController());
    }
    IEnumerator SpawnController()
    {
        for (int i = 0; i < currentEnimigosSpawn; i++)
        {
            Instantiate(EnimigosEasy[Random.Range(0, EnimigosEasy.Length)], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(waitForSpawnEnimiesWave);
        }
        yield return new WaitForSeconds(waitForSpawnWaveEnimies);
        StartCoroutine(SpawnController());
    }

}
