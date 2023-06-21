using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allumage_lampadaire : MonoBehaviour
{
    public string inputFus = "j";
    //public Light lumiere_lampadaire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerStay(Collider col) {
        if (col.gameObject.name == "trigger_tableau_elec" && Input.GetKeyDown(inputFus) )
        {


            GetComponent<Light>().intensity = 3;
            Debug.Log("yes");


        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
