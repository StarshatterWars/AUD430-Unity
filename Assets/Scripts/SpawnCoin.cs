using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject coin;
    public Vector3 spawnPosition;
    int coinCounter = 0;
    int MAXCOINS = Backpack.capacity;
    float xMinMax = 5f;
    float zMinMax = 5f;
    float spawnTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CoinSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime = Random.Range(2, 4);
    }

    IEnumerator CoinSpawn()
    {
        yield return new WaitForSeconds(3);
        while (coinCounter < MAXCOINS)
        {
            spawnPosition = new Vector3(
                Random.Range(-xMinMax, xMinMax),
                0.97f,
                Random.Range(-zMinMax, zMinMax)
            );

            Instantiate(
                coin, 
                spawnPosition, 
                coin.transform.rotation
            );
            coinCounter++;
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
