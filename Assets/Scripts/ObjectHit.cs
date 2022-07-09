using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    Life lifes;
    
    //En el momento en que entra en la colisi�n ejecuta el siguiente c�digo
      private void OnCollisionEnter(Collision other)
      {
        //Si colisiona con un gameobject con el tag "Player"
        //ejecuta el bloque de c�digo
        if(other.gameObject.tag == "Player")
        {

            print("<color=magenta> �Te has golpeado! </color>");
            lifes.DownLife();
            

        }
       
      }

}
