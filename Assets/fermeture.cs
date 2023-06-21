using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fermeture : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.name == "Player")
        {
            Application.Quit();
            print("ça marche");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
