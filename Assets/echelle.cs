using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class echelle : MonoBehaviour
{
    

    //Touche pour activer le deplacement du cube
    public string inputmont = "k";

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionStay(Collision col) // Recuperer une collision
    {
        if (col.gameObject.name == "echelle" && Input.GetKey(inputmont))
        {
            transform.position = transform.position + new Vector3(0, 5, 0);

        }
    }

    void update()
    {

    }
}
