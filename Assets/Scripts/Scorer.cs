using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    //Creamos una variable de tipo int que almacenar� el n�mero de veces que 
    //ponchamos un globo
    //jejeje �le puse pop por que as� me imagino que suena un globo cuando truena! xD
    int pop;
    //Esta variable solamente me sirve para mostrar en el Inspector 
    //los puntos que se han ido acumulando
    [SerializeField] int points;


    void Start()
    {
        //La variable pop al inicio del juego 
        //equivale a 0 ya que no hemos tronado ningun globo
        pop = 0;
    }

    void Update()
    {
        
        //Se mostrar� desde el Inspector los puntos que vaya acumulando
        points = pop;
    }

    private void OnCollisionEnter(Collision other)
    {
        //Si chocaste con un objeto con el tag "obstacle"
        //ejecuta el siguiente c�digo
        if (other.gameObject.tag == "Balloon")
        {
            pop++;
            print("<color=green>  Has tronado" + " " + pop + " " + "globos </color>");
            if(pop == 3)
            {
                print("<color=cyan> �YOU WIN! </color>");
            }
            //Debug.Log("Has tronado: " + " " + pop + " " + "globos");
        }
        //M�s si chocaste con un gameobject con el tag "hit"
        //ejecuta el siguiente c�digo

        //Cuando el jugador choca con un obst�culo se le cambia su tag "Obstacle"
        //por un nuevo tag de nombre "Hit", esto sucede desde mi script - c# ObjectHit
       /* else if (other.gameObject.tag == "Hit")
        {
            Debug.Log("Ya chocaste con esto");

        }*/
        

    }

}
