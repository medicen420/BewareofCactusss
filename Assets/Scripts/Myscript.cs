using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myscript : MonoBehaviour
{

    public GameObject cube;
    public GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        Execute();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Execute()
    {
        //Bandera                //Player
        cube.transform.SetParent(sphere.transform);
    }


}
