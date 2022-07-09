using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    //Creamos una variable de tipo int que almacenará el número de veces que 
    //ponchamos un globo
    //jejeje ¡le puse pop por que así me imagino que suena un globo cuando truena! xD
    int pop;
    //Esta variable solamente me sirve para mostrar en el Inspector 
    //los puntos que se han ido acumulando
    [SerializeField] int points;

    RandoomActivate randoom_act;
    


    void Start()
    {
        //La variable pop al inicio del juego 
        //equivale a 0 ya que no hemos tronado ningun globo
        pop = 0;
        
    }

    void Update()
    {
        
        //Se mostrará desde el Inspector los puntos que vaya acumulando
        points = pop;
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "blue_balloon")
        {
            pop++;
            print("<color=cyan>  Has tronado" + " " + pop + " " + "globos de color azul </color>");

        }
        //*************************************************************
        if (other.gameObject.tag == "red_balloon")
        {
            Debug.Log("Este color no idiota");
        }
        //*************************************************************
        if (other.gameObject.tag == "green_balloon")
        {
            Debug.Log("Este color no idiota");
        }
        //**************************************************************

        //Más si chocaste con un gameobject con el tag "hit"
        //ejecuta el siguiente código

        //Cuando el jugador choca con un obstáculo se le cambia su tag "Obstacle"
        //por un nuevo tag de nombre "Hit", esto sucede desde mi script - c# ObjectHit
       /* else if (other.gameObject.tag == "Hit")
        {
            Debug.Log("Ya chocaste con esto");

        }*/
        

    }

 
   

   


}


