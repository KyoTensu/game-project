using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levier : MonoBehaviour
{  


    //Touche pour activer le levier
    public string inputLev = "j";

    //variable pour modifier la position du levier
    public Transform lev;

    // variable récupération position
    public int A1;

        void Start ()
    {

        A1 = 1;
  
    }


     void OnTriggerStay(Collider col) // Recuperer un trigger
      {
        if (col.gameObject.name == "trigger_levier" && Input.GetKeyDown(inputLev) && A1%2 !=0 )
         {
          
            A1 = A1 + 1;
            
            lev.Rotate(-70.0f, 0, 0);

           
        } 
        else if (col.gameObject.name == "trigger_levier" && Input.GetKeyDown(inputLev) && A1%2 == 0) 
        {
            A1 = A1 + 1;
            
            lev.Rotate(70.0f, 0, 0);
        }
      }
      
}
