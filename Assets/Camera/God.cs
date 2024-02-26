using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class God : MonoBehaviour
{
    // Start is called before the first frame update
    private void Update()
    {
       // if (Collisi)
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
             if (Input.GetKeyDown(KeyCode.S))
                    {
                        Destroy(gameObject);
                    }
        }
        
    }
   
}
