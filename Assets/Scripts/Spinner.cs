using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float Xvalue = 0f;
    [SerializeField] float Yvalue = 1f;
    [SerializeField] float Zvalue = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Xvalue, Yvalue, Zvalue);
    }
}
