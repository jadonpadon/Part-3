using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject bigTank;
    public GameObject smallTank;
    float min = -10;
    float max = 10;
    float bigTimer = 0;
    float smallTimer = 0;
    float bigSpawnRate = 4;
    float smallSpawnRate = 2;

    void Start()
    {
        
    }


    void Update()
    {
        if (bigTimer < bigSpawnRate)
        {
            bigTimer += Time.deltaTime;
        }
        else
        {
            Instantiate(bigTank, new Vector3(Random.Range(min, max), 5, 0), transform.rotation);
            bigTimer = 0;
        }

        if (smallTimer < smallSpawnRate)
        {
            smallTimer += Time.deltaTime;
        }
        else
        {
            Instantiate(smallTank, new Vector3(Random.Range(min, max), 5, 0), transform.rotation);
            smallTimer = 0;
        }

    }
}
