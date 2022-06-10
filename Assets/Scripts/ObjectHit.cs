using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    
    //En el momento en que entra en la colisión ejecuta el siguiente código
      private void OnCollisionEnter(Collision other)
      {
        //Si colisiona con un gameobject con el tag "Player"
        //ejecuta el bloque de código
        if(other.gameObject.tag == "Player")
        {
            //Dentro de el Componente MeshRenderer
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";

           
        }
       

        

      }

    

}
