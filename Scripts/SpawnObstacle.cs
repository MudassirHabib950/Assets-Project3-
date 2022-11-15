using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(15.2f,0f,0.46f);
    private float startDelay = 2.0f;
    private float repeatRate = 2.0f;
    private float leftBound = -15.0f;
    private PlayerControllerX playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
       playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
       InvokeRepeating("SpawnObstacle",startDelay,repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle()
    {
        if(playerControllerScript.gameOver == false)
        {
        Instantiate(obstaclePrefab,spawnPos,obstaclePrefab.transform.rotation);
        }
        if(transform.position.x<leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    
    }
}
