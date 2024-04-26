using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusSpawn : MonoBehaviour
{
    public GameObject Cactus;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    void Start()
    {
        spawnCactus();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnCactus();
            timer = 0;
        }

    }

    void spawnCactus()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        
        Instantiate(Cactus, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
