using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    //Creamos una variable de tipo int que almacenar� el n�mero de colisiones
    int hits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        hits++;
        Debug.Log("You've bumped into a thing this many times: " + " " + hits);
       
    }


}
