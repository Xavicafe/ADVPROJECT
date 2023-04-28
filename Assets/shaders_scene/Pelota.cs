using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random=System.Random;
using TMPro;

public class Pelota : MonoBehaviour
{
    public Material mat;
    public Material mate;
    public Material mater;
    public Material materi;
    private Renderer rend;

    public GameController gm;
    public GameObject pelota;
    public GameObject sonido_mal;
    
    
    
    private Rigidbody rb;
    public Collider col;
    private string random;

    
    private GameObject[] pelotas;
    // Start is called before the first frame update
    void Start()
    {
        
        gm = GameObject.FindWithTag("GAMECONTROL").GetComponent<GameController>();
        

        rend =GetComponent<Renderer>();
        
        rb = GetComponent<Rigidbody>();

    
    }

    
    void OnTriggerStay(Collider c){
        
        if(c.tag=="RED"){
            rend.material= mat;
            col=c;
        }
        if(c.tag=="YELLOW"){
            rend.material= mate;
            col=c;
        }
        if(c.tag=="GREEN"){
            rend.material= mater;
            col=c;
        }
        if(c.tag=="BLUE"){
            rend.material= materi;
            col=c;
        }

    }

    void Update(){
        random=gm.random;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(col.tag==random){
                gm.AddScore(1);
                gm.sonido();
                
                GameObject game = Instantiate(pelota);
                game.transform.position= new Vector3(1f,5f,-3f);
                gm.ChangeTag();
                
            }
            else{
                gm.sonido();
                
            }
        }
        if(gameObject.transform.position.y<=-10){
            gm.lose();
            Destroy(gameObject);
            Instantiate(sonido_mal);

            
        }
    }
}
