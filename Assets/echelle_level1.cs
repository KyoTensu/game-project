using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class echelle_level1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Touche pour activer le deplacement du perso
    public string inputMont = "j";


    void OnCollisionStay(Collision col) // Recuperer une collision
    {
        if (col.gameObject.name == "e" && Input.GetKey(inputMont))
        {
            transform.position = transform.position + new Vector3(0, 2, 0); // la valeur 5 (dans l'axe y donc) est la valeur de notre montée
            print("ça marche");

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
