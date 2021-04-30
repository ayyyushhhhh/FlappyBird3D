using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class ObsctacleCreator : MonoBehaviour
{
    [SerializeField] private GameObject[] obsctaclePrefabs;
    private float SpawnTime = 0f;
    private float timer = 0;
    private float xAxisDistance = 0f;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= SpawnTime)
        {
            int ran = Random.Range(0, obsctaclePrefabs.Length);
            GameObject obstacle = Instantiate(obsctaclePrefabs[ran]);
            obstacle.transform.position = new Vector3(xAxisDistance, 2.5f, 0);
            xAxisDistance += -2f;
            SpawnTime += 0.2f;
        }
    }
}
