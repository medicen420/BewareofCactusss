using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Flags : MonoBehaviour
{

    public Transform pos;
    public GameObject[] Flags_colector;

  

    // Start is called before the first frame update
    void Start()
    {
        InstantiateObject();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void InstantiateObject()
    {
        int n = Random.Range(0, Flags_colector.Length);
        Instantiate(Flags_colector[n], pos.position, Flags_colector[n].transform.rotation);
    }
}
