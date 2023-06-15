using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interrupteur : MonoBehaviour
{
    
    //variable pour modifier la position du levier
    public Transform interrup;

    public int inter1;

    void Start()
    {

      

    }


    void OnTriggerEnter(Collider col) // detecter la reaction du trigger
    {
        if (col.gameObject.name == "trigger_interrupteur" )
        {

            interrup.position = interrup.position + new Vector3(0, -8, 0); // déplacer l'interrupteur
            inter1 = 1;

        }
        
    }

    void OnTriggerExit(Collider col) // Recuperer un trigger en sortie de la zone de contact
    {
        if (col.gameObject.name == "trigger_interrupteur")
        {

            interrup.position = interrup.position + new Vector3(0, 8, 0); // remettre en place l'interrupteur
            inter1 = 2;

        }

    }

}
