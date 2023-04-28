using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=System.Random;
using TMPro;

public class GameController : MonoBehaviour
{
    public TMP_Text Score_label;
    public TMP_Text Info_label;
    public TMP_Text Lose_label;
    public int score=0;

    
    public GameObject sonido_mal;
    public GameObject sonido_bien;
    public GameObject sonido_lose;

    

    private List<string> colores= new List<string>(){"RED","YELLOW","GREEN","BLUE"};
    public string random;
    private GameObject[] pelotas;
    // Start is called before the first frame update
    void Start()
    {
        Random rnd = new Random();
        int randIndex = rnd.Next(colores.Count);
        random = colores[randIndex];
        Info_label.text="Press SPACEBAR to stop the ball in "+random+" block";
        if(random=="RED"){
            Info_label.color=Color.red;
        }
        if(random=="YELLOW"){
            Info_label.color=Color.yellow;
        }
        if(random=="GREEN"){
            Info_label.color=Color.green;
        }
        if(random=="BLUE"){
            Info_label.color=Color.blue;
        }
        
    }

    void Update(){
        pelotas= GameObject.FindGameObjectsWithTag("PELOTAS");
    }

    public void sonido(){
        

        bool bien_mal=false;
        for(int i=0; i<pelotas.Length;i++){
            Debug.Log("COL.TAG:"+pelotas[i].GetComponent<Pelota>().col.tag);
            Debug.Log("Random:"+random);
            if(pelotas[i].GetComponent<Pelota>().col.tag==random){
                bien_mal=true;
            }
        }
        if(bien_mal==true){
            Instantiate(sonido_bien);
        }else{
            Instantiate(sonido_mal);
            AddScore(-1);
        }
        bien_mal=false;
    }
    public void AddScore(int num){
        score +=num;
        if(score<=0){
            score=0;            
        }
        Score_label.text="Score: "+score;
    }

    public void ChangeTag(){
        Random rnd = new Random();
            int randIndex = rnd.Next(colores.Count);
            random = colores[randIndex];
            Info_label.text="Press SPACEBAR to stop the balls in "+random+" block";
            if(random=="RED"){
            Info_label.color=Color.red;
        }
        if(random=="YELLOW"){
            Info_label.color=Color.yellow;
        }
        if(random=="GREEN"){
            Info_label.color=Color.green;
        }
        if(random=="BLUE"){
            Info_label.color=Color.blue;
        }
    }

    public void lose(){
        Debug.Log(pelotas.Length);
        if(pelotas.Length==1){
                
                Instantiate(sonido_lose);
                Lose_label.text="YOU LOSE";
        }
        
    }

    
}
