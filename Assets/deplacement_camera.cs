using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacement_camera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = GameObject.Find("Player").transform.position + Vector3.up *14 + Vector3.right * 29 + Vector3.back *16;
    }
}
