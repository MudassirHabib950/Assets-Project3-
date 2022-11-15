using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(15.2f,0f,0.46f);
    private float startDelay = 2.0f;
    private float repeatRate = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnObstacle",startDelay,repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle2()
    {
     Instantiate(obstaclePrefab,spawnPos,obstaclePrefab.transform.rotation);
    }
}
