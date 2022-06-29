using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandoomFlag : MonoBehaviour
{
    //Posición donde irá mi bandera cuando aparezca
    public Transform pos;
    //Array donde guardaremos las banderas de diferente color
    public GameObject[] flags;
    //Esta será mi bandera cuando aparezca
    public GameObject Flag_randoom;


    //Este GameObject es básicamente el padre donde introduciremos al hijo (la bandera)
    //para que se mueva con el Player al momento de aparecer
    public GameObject flag_pos;
    //**********************************************************************
    //GameObject que nos ayudará a encontrar un objeto en el juego
    //con el nombre del color de las banderas
    public GameObject detect_flag;


    public GameObject blue_flag;
    public GameObject red_flag;
    public GameObject green_flag;


    public GameObject[] flagscene;


    [SerializeField] float Timewait;
    string FlagColor = "Flag";
    


    // Start is called before the first frame update
    void Start()
    {
        Timewait = 0f;    
        InstantiateObject();

        detect_flag = GameObject.FindGameObjectWithTag(FlagColor);
        if (detect_flag == true)
        {
            Debug.Log("Hay una bandera en escena");
        }

        



    }

    // Update is called once per frame
    void Update()
    {
        


    }

    private void ColorFlag()
    {
      
        blue_flag = GameObject.Find("Flag_blue(Clone)");

        if (blue_flag == true)
        {
            
            print("<color=cyan> La bandera es azul </color>");
            blue_flag.transform.SetParent(flag_pos.transform);
            StartCoroutine("TimetoNewFlag");

        }

        red_flag = GameObject.Find("Flag_red(Clone)");

        if (red_flag == true)
        {
            print("<color=red> La bandera es roja </color>");
            red_flag.transform.SetParent(flag_pos.transform);
            StartCoroutine("TimetoNewFlag");
        }

        green_flag = GameObject.Find("Flag_green(Clone)");

        if (green_flag == true)
        {
            print("<color=green> La bandera es verde </color>");
            green_flag.transform.SetParent(flag_pos.transform);
            StartCoroutine("TimetoNewFlag");
        }

    }



    private void InstantiateObject()
    {
        
        //Vamos a generar un número aleatorio entre 0 y 2
        //int n = Random.Range(0, 3);
        //Está es una forma sencilla pero no tan recomendable de hacerlo ya que si
        //quiero agregar más objetos al array, tengo que regresar a cambiar todo desde el código
        //flags = GameObject.FindGameObjectsWithTag(tagflag);

        //Mejor vamos a ponerlo de la siguiente forma para que sea más específico
        int n = Random.Range(0, flags.Length);
        Instantiate(flags[n], pos.position, flags[n].transform.rotation);
        //Esto solamente es para mostrarnos en el Inspector el color de la bandera que salió
        Flag_randoom = flags[n];
        flags[n].tag = FlagColor;

        ColorFlag();
       

    }

    private IEnumerator TimetoNewFlag()
    {
        

        yield return new WaitForSeconds(5f);
        if (blue_flag == true)
        {
            yield return new WaitForSeconds(5f);
            Debug.Log("Ya pasaron 5 segundos en azul");
            Timewait = 5f;
            blue_flag.SetActive(false);
            InstantiateObject();
            
        }
        if (red_flag == true)
        {
            yield return new WaitForSeconds(5f);
            Debug.Log("Ya pasaron 5 segundos en rojo");
            Timewait = 5f;
            
            InstantiateObject();
        }
        if(green_flag == true)
        {

            yield return new WaitForSeconds(5f);
            Debug.Log("Ya pasaron 5 segundos en verde");
            Timewait = 5f;
            InstantiateObject();
        }

        

        
    }




}
