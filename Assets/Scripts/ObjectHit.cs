using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    //En el momento en que entra en la colisi�n ejecuta el siguiente c�digo
      private void OnCollisionEnter(Collision other)
      {
          print("<color=green> Bumped in to the wall </color>");
      }

    

}
