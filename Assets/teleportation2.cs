using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportation2 : MonoBehaviour
{
    public Transform teleporteur;
    public GameObject player;
    public string inputLev = "j";


    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerStay(Collider col)//recuperer un triger
    {
        if (col.gameObject.name == "Player" && Input.GetKeyDown(inputLev))
        {
            player.transform.position = teleporteur.transform.position;// teleporter le personnage
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
