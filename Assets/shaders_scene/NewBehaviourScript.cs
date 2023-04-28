using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random=System.Random;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public float vel = 10f;

    void Update(){
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            var rot = transform.rotation;
            rot.x += Time.deltaTime * vel;
            transform.rotation = rot;
            
        }
        else if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)){
            var rot = transform.rotation;
            rot.x -= Time.deltaTime * vel;
            transform.rotation = rot;
        }
    }
}
