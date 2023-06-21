using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fin_jeu : MonoBehaviour
{
    //Touche pour interragir
    public string inputLev = "j";

    //variable pour modifier la position du levier
    public Transform ported;
    public Transform porteg;


    void Start()
    {

    }


    void OnTriggerStay(Collider col) // Recuperer un trigger
    {
        if (col.gameObject.name == "trigger_fin" && Input.GetKeyDown(inputLev) )
        {


            ported.Translate(0, 0, 1000);
            porteg.Translate(0, 0,-1000);


        }
        
    }
}
