using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider c){

        if(c.tag=="PLAYER"){

            bool state= animator.GetBool("open");
            animator.SetBool("open",!true);
        }

    }
}
