using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon_point : MonoBehaviour
{
    //En el momento en que entra en la colisi�n ejecuta el siguiente c�digo
    private void OnCollisionEnter(Collision other)
    {
        //Si colisiona con un gameobject con el tag "Player"
        //ejecuta el bloque de c�digo
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            //Dentro de el Componente MeshRenderer
            //GetComponent<MeshRenderer>().material.color = Color.red;
            //Cuando el jugador colisione con un obst�culo
            //a ese obst�culo se le cambiar� su tag actual por el tag "Hit"
            //gameObject.tag = "Hit";


        }

    }
}
