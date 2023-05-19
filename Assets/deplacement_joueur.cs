using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacement_joueur : MonoBehaviour
{
    // Vitesse des actions 
    public float walkSpeed;
    public float turnSpeed;

    //Touche pour se déplacer
    public string inputFront = "z";
    public string inputBack = "s";
    public string inputLeft = "q";
    public string inputRight = "d";
    public string inputRun = "a";
    public string inputLow = "e";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // permet de réinitialiser la hitbox du joueur après s'être acrroupi
        gameObject.GetComponent<CapsuleCollider>().height = 2.0f;

        // avancer
        if ( Input.GetKey(inputFront) && !Input.GetKey(inputRun) && !Input.GetKey(inputLow))
        {
            transform.Translate(0, 0, walkSpeed * Time.deltaTime);
        }

        // Courir
        if (Input.GetKey(inputFront) && Input.GetKey(inputRun) && !Input.GetKey(inputLow))
        {
            transform.Translate(0, 0, 2 * walkSpeed * Time.deltaTime);
        }

        // s'accroupir et aller tout droit
        if (Input.GetKey(inputFront) && Input.GetKey(inputLow) && !Input.GetKey(inputRun))
        {
            gameObject.GetComponent<CapsuleCollider>().height = 1.0f;
            transform.Translate(0, 0,  (walkSpeed / 2) * Time.deltaTime);
        }

        // reculer
        if (Input.GetKey(inputBack) && !Input.GetKey(inputLow))
        {
            transform.Translate(0, 0, -(walkSpeed / 2) * Time.deltaTime);
        }

        // s'accroupir et reculer
        if (Input.GetKey(inputBack) && Input.GetKey(inputLow) )
        {
            gameObject.GetComponent<CapsuleCollider>().height = 1.0f;
            transform.Translate(0, 0, -(walkSpeed/2) * Time.deltaTime);
        }

        // tourner à gauche
        if (Input.GetKey(inputLeft))
        {
            transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
        }

        // tourner à droite
        if (Input.GetKey(inputRight))
        {
            transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
        }
    }
}
