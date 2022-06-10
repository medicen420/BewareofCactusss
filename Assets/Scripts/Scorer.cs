using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    //Creamos una variable de tipo int que almacenará el número de colisiones
    int hits = 0;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("Has chocado: " + " " + hits + " " + "veces con esto");
        }
        else if(other.gameObject.tag == "Hit")
        {
            Debug.Log("Ya chocaste con esto");

        }
        
      
    }


}
