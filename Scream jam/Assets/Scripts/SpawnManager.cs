using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject terrain;
    public GameObject player;
    [SerializeField] List<Vector3> playerSpawnPositions = null;
    public GameObject birdTriggers;

    private float heightY = 0.0f;

    void Start()
    { 
        int randomIndex = Random.Range(0, playerSpawnPositions.Count);
        Instantiate(player.gameObject, playerSpawnPositions[randomIndex], player.transform.rotation);
        
        SpawnBirdTriggers();
    }

    void Update()
    {

    }

    private void SpawnBirdTriggers()
    {

        for(int i = 0; i < 10; i++)
        {
            Vector3 randomPos = GenerateSpawnPosition();
            Terrain terrainData = terrain.GetComponent<Terrain>();
            heightY = terrainData.SampleHeight(randomPos);
            randomPos.y = heightY;

            Instantiate(birdTriggers.gameObject, randomPos, birdTriggers.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-250, 1250);
        float spawnPosZ = Random.Range(-250, 1250);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return spawnPos;
    }
}
