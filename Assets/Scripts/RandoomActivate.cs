using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RandoomActivate : MonoBehaviour
{
    //PLAYER CACTUS
    public GameObject Player_Cactus;
    public float Timetowait;
    



    public GameObject[] flags_color;
    private int currentIndex = 0;
    public float elapsedTime = 0f;
    public float repeatTime = 0f;

    void Start()
    {
        Timetowait = 0;
        Cactusidle();
    }
    // Update is called once per frame
    void Update()
    {
        
    }


    public void Cactusidle()
    {
        Timetowait = 0;
        //Aquí pondremos el código 
        //para nuestro Cactus sin banderas

        //Básciamente es nuestro personaje en idle
        Player_Cactus.SetActive(true);
        //Necesito crear el tiempo que va a estar activo mi cactus sin banderin
        //Para posteriormente mandar llamar al método que se encargará de 
        //activar de forma aleatoria a una variante de mi personaje con banderin
        StartCoroutine("TimetoIdle");




    }

    private IEnumerator TimetoIdle()
    {
        yield return new WaitForSeconds(3f);
        Debug.Log("Preparate para el siguiente color");
        Timetowait = 3;
        if(Timetowait == 3)
        {
            CactusFlagColor();
            Player_Cactus.SetActive(false);
        }

    }

    public void CactusFlagColor()
    {
        Timetowait = 0;
        int newIndex = Random.Range(0, flags_color.Length);

        flags_color[currentIndex].SetActive(false);
        currentIndex = newIndex;
        flags_color[currentIndex].SetActive(true);

        print("<color=purple> El tentáculo ha sacado una bandera </color>");
        //Necesito crear el tiempo que va a estar activo mi cactus con bandera
        //Para posteriormente mandar activar de nuevo mi cactus sin banderin
        StartCoroutine("TimetoFlag");


    }

    private IEnumerator TimetoFlag()
    {
        //El banderín estará activo por 10 segundos
        yield return new WaitForSeconds(10f);
        Timetowait = 10;
        //Si el tiempo llega a 10 segundos entonces
        //llamamos al método de nuestro Cactus Idle
        if (Timetowait == 10)
        {
            flags_color[currentIndex].SetActive(false);
            Cactusidle();

        }

    }




}
