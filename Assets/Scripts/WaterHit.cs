using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Comentario en consola que nos indica que hemos ca�do al agua
            Debug.Log("Est�s en el agua");
            //Se mostrar� en consola un "Game Over" en color rojo
            print("<color=red> GAME OVER </color>");
            //Cuando el jugador caiga al agua
            //se le cambiar� el tag al agua por "OntheWater"
            //esto debido a que detecta 2 veces la colisi�n cuando 
            //caemos al agua 

        }
    }
}
