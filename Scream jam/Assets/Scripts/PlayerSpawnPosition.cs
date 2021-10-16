using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnPosition : MonoBehaviour
{
    [SerializeField] List<Vector3> spawnPositions;

    void Awake()
    {
        int randomIndex = Random.Range(0, spawnPositions.Count);
        transform.position = spawnPositions[randomIndex];
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
