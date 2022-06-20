using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon_point : MonoBehaviour
{
    //En el momento en que entra en la colisión ejecuta el siguiente código
    private void OnCollisionEnter(Collision other)
    {
        //Si colisiona con un gameobject con el tag "Player"
        //ejecuta el bloque de código
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            //Dentro de el Componente MeshRenderer
            //GetComponent<MeshRenderer>().material.color = Color.red;
            //Cuando el jugador colisione con un obstáculo
            //a ese obstáculo se le cambiará su tag actual por el tag "Hit"
            //gameObject.tag = "Hit";


        }

    }
}
