using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiempo_vida_sonidos : MonoBehaviour
{
    public float tiempo=2f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, tiempo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
