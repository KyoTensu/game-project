using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pousse_cube : MonoBehaviour
{
    public Rigidbody cube;
    public Rigidbody cube2;

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
            
        }

        if (col.gameObject.name == "box_low (1)" && !Input.GetKey(inputPush))
        {
            cube.isKinematic = true;// desactive le rigidbody 
        }

        if (col.gameObject.name == "CarboardBox_1 (18)" && Input.GetKey(inputPush))
        {
            cube2.isKinematic = false;// active le rigidbody 
            
        }

        if (col.gameObject.name == "CarboardBox_1 (18)" && !Input.GetKey(inputPush))
        {
            cube2.isKinematic = true;// desactive le rigidbody 
        }
    }

    void update()
    {

    }

}
