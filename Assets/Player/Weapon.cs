using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform shootPos;
    public GameObject bullet;
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            
            Instantiate(bullet, shootPos.transform.position, transform.rotation);
            animator.Play("shoot");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.Play("God");
        }
        
    }
}
