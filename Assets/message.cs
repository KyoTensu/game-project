using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class message : MonoBehaviour
{
    
    public MeshRenderer image;

    void OnTriggerEnter(Collider col) // Recuperer un trigger
    {
        if (col.gameObject.name == "Player" )
        {
            image.enabled = true;

        }
        
    }

    void OnTriggerExit(Collider col) // Recuperer un trigger
    {
        if (col.gameObject.name == "Player")
        {
            image.enabled = false;

        }

    }

    
}
