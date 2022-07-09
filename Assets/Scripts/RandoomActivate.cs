using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RandoomActivate : MonoBehaviour
{
    public GameObject Cactusito;
    //Creamos una variable de tipo GameObject
    //Aqu� llamaremos a nuestro jugador
    public GameObject Player_Cactus;

    

    //Creamos una variable de tipo float 
    //Aqu� almacenamos el tiempo de espera para el cambio de cada bandera
    public float Timetowait;

    //Creamos un Array
    //para almacenar las variantes de nuestro personaje
    public GameObject[] flags_color;
    //Es decir... almacenaremos los diferentes colores de bandera que tengamos en el juego

    //Creamos una variable de tipo int
    //Aqu� almacenaremos el �ndice actual de nuestro Array
    private int currentIndex = 0;


    


    void Start()
    {
        //Al principio el tiempo de espera debe ser 0
        Timetowait = 0;
        Cactusidle();
       
    }
    // Update is called once per frame
    void Update()
    {
        //flags_color = GameObject.FindGameObjectsWithTag(flag_blue);

    }


    public void Cactusidle()
    {

        //Cambiamos el valor de Timetowait a 0
        Timetowait = 0;
        //Aqu� pondremos el c�digo 
        //para nuestro Cactus sin banderas

        //Activamos nuestro Player sin bandera
        Player_Cactus.SetActive(true);
        //Necesito crear el tiempo que va a estar activo mi cactus sin banderin
        //Para posteriormente mandar llamar al m�todo que se encargar� de 
        //activar de forma aleatoria a una variante de mi personaje con banderin
        StartCoroutine("TimetoIdle");

    }


    //Creamos una corrutina 
    //para hacer que la l�gica suceda con el tiempo
    private IEnumerator TimetoIdle()
    {
        //Est� l�nea de c�digo se encarga de decirle al juego
        //que espere 3 segundos para que nuestro personaje saque una de las banderas
        yield return new WaitForSeconds(3f);
        Debug.Log("Preparate para el siguiente color");

        //Declaramos que despu�s de que hayan pasado los 3 segundos
        //esos 3 segundos los almacenaremos dentro de nuesta variable
        //Timetowait
        Timetowait = 3;
        //Abrimos un condicional if
        //para indicarle al programa:
        //Si Timetowait equivale a 3 ejecuta el c�digo dentro 
        //de los corchetes
        if (Timetowait == 3)
        {
            //Mandamos a ejecutar el m�todo dentro
            //de esta misma script
            CactusFlagColor();
            //Desactivamos a nuestro Player sin bandera
            //Ya que activaremos un Player con una bandera
            Player_Cactus.SetActive(false);
        }

    }

    //Creamos un m�todo que ser� el encargado de 
    //activar un Player con una bandera de diferente color 
    //de forma aleatoria durante el juego
    public void CactusFlagColor()
    {
        //Declaramos nuestra variable de tiempo de espera en 0 
        //para que se pueda volver a ejecutar una vez que terminemos
        Timetowait = 0;


        //Creamos una variable con el nombre "newIndex"
        //Aun que en realidad puede ser cualquier otro nombre, no importa.

        //Dentro de esta variable vamos a almacenar de forma Randoom 
        //el rango de nuestro Array
        int newIndex = Random.Range(0, flags_color.Length);

        //Recordemos que el rango es el intervalo entre el valor m�ximo y el valor m�nimo
        //Es por ello que entre par�ntesis �nicamente estoy colocando al principio el valor 0
        //y despu�s el valor del largo de nuestro Array, esto es para que el sistema 
        //sepa el valor real de el largo, y de este m�do que no tengamos que poner un n�mero exacto





        //Esta l�nea de c�digo nos permite desactivar a nuestro Player 
        //sin bandera en caso de que lo hayamos incluido en nuestro Array
        //flags_color[currentIndex].SetActive(false);

        //En este caso no le he incluido dentro del Array
        //yo lo que hice fue desactivar a nuestro Player sin bandera en la Corrutina
        //al indicar que si han pasado 3 segundos lo desactive por completo





        //Declaramos que la variable currentIndex
        //va a ser igual a el newIndex que acabamos de crear arriba
        currentIndex = newIndex;
        //Mandamos activar de forma aleatoria una variante de nuestro Player 
        //con alguno de los colores de bandera disponibles en el juego
        flags_color[currentIndex].SetActive(true);

        //Mandamos llamar a nuestro m�todo encargado de que el player 
        //�nicamente ponche los globos del color de la bandera que tiene el tent�culo
        ColorBallonPop();

        


        //Comentario en consola que nos indica que nuestro tent�culo ha sacado una bandera
        print("<color=purple> El tent�culo ha sacado una bandera </color>");

        //Necesito crear el tiempo que va a estar activo mi Player con la bandera
        //Para posteriormente mandar activar de nuevo mi Player sin bandera

        //Por lo tanto para lograr esto, debemos mandar llamar a nuestra nueva corrutina
        //que se encuentra en la parte inferior a est� c�digo 
        StartCoroutine("TimetoFlag");


    }


    //Creamos una corrutina 
    //para hacer que la l�gica suceda con el tiempo

    //Est� corrutina me va a permitir declarar el tiempo en el que se mostrar�
    //mi Player con alguna de las banderas de color que fue activada en la parte superior 
    //a este c�digo
    private IEnumerator TimetoFlag()
    {
        //Mi Player con bandera estar� visible 
        //�nicamente por 10 segundos 
        yield return new WaitForSeconds(5f);
        //Recordemos que mi variable Timetowait la volvimos a declarar en 0
        //dentro del m�todo "CactusFlagColor()"

        //Ahora que han pasado 10 segundos con la bandera expuesta
        //esos 10 segundos los almacenaremos dentro de nuesta variable
        //Timetowait
        Timetowait = 5;

        //Si mi variable Timetowait vale 10
        //ejecuta el c�digo
        if (Timetowait == 5)
        {
            //Desactivamos nuestro Player con bandera 
            //que fue activado de forma aleatoria previamente
            flags_color[currentIndex].SetActive(false);
            //Mandamos llamar a nuestro m�todo 
            Cactusidle();


            //Esta l�nea de c�digo se encarga de destruir el script de Score
            //con la posibilidad de que se vuelva agregar el script si la bandera es azul
            Destroy(Cactusito.GetComponent<Scorer>());
        }

    }

    public void ColorBallonPop()
    {
        //Esto lo podriamos mover a un m�todo diferente
        //Este condicional if 
        //nos ayudar� a saber que bandera est� activada

        //BANDERA AZUL
        if (flags_color[0].activeSelf)
        {
            //mensaje en consola
            print("<color=cyan> Bandera Azul </color>");
            Cactusito.AddComponent<Scorer>();

        }

        //BANDERA RED
        if (flags_color[1].activeSelf)
        {
            //mensaje en consola
            print("<color=red> Bandera Roja </color>");
        }
        //BANDERA VERDE
        if (flags_color[2].activeSelf)
        {
            //mensaje en consola
            print("<color=green> Bandera Verde </color>");
        }
        //********************************************************************************
    }











}
