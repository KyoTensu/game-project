using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class echelle : MonoBehaviour
{
    

    //Touche pour activer le deplacement du perso
    public string inputMont = "j";


    void OnCollisionStay(Collision col) // Recuperer une collision
    {
        if (col.gameObject.name == "echelle" && Input.GetKey(inputMont))
        {
            transform.position = transform.position + new Vector3(0, 5, 0); // la valeur 5 (dans l'axe y donc) est la valeur de notre montée

        }
    }

    void update()
    {

    }
}
