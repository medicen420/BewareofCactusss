using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    

    //En el momento en que entra en la colisión ejecuta el siguiente código
      private void OnCollisionEnter(Collision other)
      {

        //Dentro de el Componente MeshRenderer
        GetComponent<MeshRenderer>().material.color = Color.red;

      }

    

}
