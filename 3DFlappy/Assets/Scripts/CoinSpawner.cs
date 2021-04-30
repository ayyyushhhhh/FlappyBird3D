using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    private float SpawnTime = 0f;
    private float timer = 0;
    private float xAxisDistance = 0f;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= SpawnTime)
        {
            GameObject obstacle = Instantiate(coinPrefab);
            obstacle.transform.position = new Vector3(xAxisDistance, Random.Range(5,12f), 0);
            xAxisDistance += -5f;
            SpawnTime += 0.5f;
        }
    }
}
