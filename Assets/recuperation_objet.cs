using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recuperation_objet : MonoBehaviour
{
    public string inputLev = "j";
    public GameObject fusible;
    public GameObject carte;
    public GameObject cle;
    public Transform trigger;
    public Transform balise;

    public int open;
    public int open1;
    public int open2;

    void Start()
    {

    }

    //public raycastHit hit;

    void OnTriggerStay(Collider col) // Recuperer un trigger
    {
        

        if (col.gameObject.name == "trigger_fusible" && Input.GetKeyDown(inputLev))
        {
            Destroy(fusible);
            open = 100;
        }
        if (col.gameObject.name == "trigger_carte" && Input.GetKey(inputLev) )
        {
            Destroy(carte);
            open1 = 101;
        }
        if (col.gameObject.name == "trigger_cle" && Input.GetKey(inputLev))
        {
            Destroy(cle);
            open2 = 102; 
        }
    }

    void Update()
    {
        if (open1==101)
        {
            if (open2==102)
            {
                trigger.transform.position = balise.transform.position;
            }
        }
    }
    
}
