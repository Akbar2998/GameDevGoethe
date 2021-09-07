using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtivnikSpawn : MonoBehaviour
{
    public GameObject Protivnik;
   /* public float maxX;
    public float minX;
    public float maxY;
    public float minY; */
    public float timeBetweenSpawn;
    private float SpawnTime;
    
    // Update is called once per frame
    void Update()
    {
        if (Time.time > SpawnTime)
        {
            Spawn();
            SpawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
      /*  float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY); */
        Instantiate(Protivnik, transform.position + new Vector3(0, 0, 0), transform.rotation);

    }
}
