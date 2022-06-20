using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect_Dropper : MonoBehaviour
{
    public Dropper drop;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Si el jugador pasa por el trigger
            //se manda a ejecutar método de el script - c# Dropper
            //este método se encargará de activar el dropper que caerá del cielo
            //para lastimar a nuestro jugador
            drop.downdropper();
        }
    }
}
