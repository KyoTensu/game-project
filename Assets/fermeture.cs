using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fermeture : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
