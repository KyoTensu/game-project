using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_move_debug : MonoBehaviour
{
    public Rigidbody cube;

    //Touche pour activer le deplacement du cube
    public string inputPush = "j";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionStay(Collision col) // Recuperer une collision
    {
        if (col.gameObject.name == "Bloc_movable" && Input.GetKey(inputPush))
        {
            cube.isKinematic = false;// active le rigidbody 
        }

         if (col.gameObject.name == "Bloc_movable" && !Input.GetKey(inputPush))
        {
            cube.isKinematic = true;// desactive le rigidbody 
        }

    }

    void update ()
    {
   
    }
    
}
