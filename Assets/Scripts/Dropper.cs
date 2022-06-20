using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    //Declaramos la siguiente variable de tipo MeshRenderer para 
    //alamacenar en cach� los datos o informaci�n de el uso frecuente en la memoria
    //Una forma f�cil de accder a ellos cuando sea necesario
    [SerializeField] MeshRenderer render;
    //Declaramos de igual forma una variable de tipo Rigidbody
    [SerializeField] Rigidbody rigidBody;
    [SerializeField] GameObject detect_drop;

   
    // Start is called before the first frame update
    void Start()
    {
        //Declaramos nuestros GetComponent's en void Start como falsos
        //de este modo no tendremos que desactivarlos desde el Inspector
        //antes de dar Play, es mucho m�s c�modo para el desarrollador.

        //-------------------------------------------------------------
        //Mesh Renderer
        render = GetComponent<MeshRenderer>();
        render.enabled = false;

        //RigidBody
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
        //-------------------------------------------------------------

        
    }


    public void downdropper()
    {
        print("<color=yellow> �Cuidado arriba! </color>");
        //enabled = habilitar
        render.enabled = true;
        rigidBody.useGravity = true;
        Destroy(detect_drop);
    }

    







}
