using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEnter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2(Collision collision)
    {
        if(collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
        }
    }
}
