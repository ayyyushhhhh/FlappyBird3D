using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PathMaker : MonoBehaviour
{
    [SerializeField] private GameObject[] obsctaclePrefabs;
    [SerializeField]private float SpawnTime = 3f;
    private float timer = 0;
    private float xAxisDistance = -90f;
    private int maxTiles = 2;

    private void Update()
    {
      
        timer += Time.deltaTime;
        if ( timer >= SpawnTime )
        {
            int ran = Random.Range(0, obsctaclePrefabs.Length);
            GameObject obstacleBelow = Instantiate(obsctaclePrefabs[ran]);
            GameObject obstacleAbove = Instantiate(obsctaclePrefabs[ran]);
            obstacleBelow.transform.position = new Vector3(xAxisDistance, 0, 0);
            obstacleAbove.transform.position = new Vector3(xAxisDistance, 12, 0);
            xAxisDistance += -30f;
            SpawnTime += 3f;
           
            maxTiles += 2;
            
            
        }
    }


    
    
}
