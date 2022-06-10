using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    //En el momento en que entra en la colisión ejecuta el siguiente código
      private void OnCollisionEnter(Collision other)
      {
        print("<color=blue> Bumped in to the wall </color>");
        //Dentro de el Componente 
        GetComponent<MeshRenderer>().material.color = Color.red;

      }

    

}
