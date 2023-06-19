using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pousse_cube : MonoBehaviour
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
        if (col.gameObject.name == "box_low (1)" && Input.GetKey(inputPush))
        {
            cube.isKinematic = false;// active le rigidbody 
            print("ça marche");
        }

        if (col.gameObject.name == "box_low (1)" && !Input.GetKey(inputPush))
        {
            cube.isKinematic = true;// desactive le rigidbody 
        }

    }

    void update()
    {

    }

}
