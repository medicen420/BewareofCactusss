using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    //Variable que almacenará los puntos de vida de mi jugador
    public int lifepoints;
    // Start is called before the first frame update
    void Start()
    {
        //Al iniciar el juego tendremos únicamente 3 vidas
        lifepoints = 3;
    }

    //Método que al ser ejecutado desde el script = c# ObjectHit
    //resta -1 punto de vida a mi jugador
    public void DownLife()
    {
        lifepoints--;
        Debug.Log("Ahora tienes" + " " + lifepoints + " "  + "puntos de vida");
        //Si perdemos las 3 vidas entonces
        //GAME OVER
        if (lifepoints == 0)
        {
            
            print("<color=red> GAME OVER </color>");
            
        }
    }
}
