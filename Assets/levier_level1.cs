using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levier_level1 : MonoBehaviour
{
    //Touche pour activer le levier
    public string inputLev = "j";

    //variable pour modifier la position du levier
    public Transform lev;
    public Transform lev2;
    public Transform lev3;
    public Transform lev4;
    public BoxCollider trigger_carte;

    // variable récupération position
    public bool A1 = false;
    public bool A2 = false;
    public bool A3 = false;
    public bool A4 = false;

    // variable pour le mecanisme
    public int B1 = 0;
    public int B2 = 0;
    public int B3 = 0;
    public int B4 = 0;
    public int i = 1;
    

    void Start()
    {

    }


    void OnTriggerStay(Collider col) // Recuperer un trigger
    {
        if (col.gameObject.name == "levier1_trigger" && Input.GetKeyDown(inputLev) && A1 == false)
        {

            A1 = true;

            lev.Rotate(0, 70.0f, 0);

            B1 = i;
            i = i+1;


        }
        else if (col.gameObject.name == "levier1_trigger" && Input.GetKeyDown(inputLev) && A1 ==true)
        {
            A1 = false;

            lev.Rotate(0, -70.0f, 0);
            B1 = 0;
        }

        if (col.gameObject.name == "levier2_trigger" && Input.GetKeyDown(inputLev) && A2 == false)
        {

            A2 = true;

            lev2.Rotate(0, 70.0f, 0);
            B2 = i;
            i = i + 1;

        }
        else if (col.gameObject.name == "levier2_trigger" && Input.GetKeyDown(inputLev) && A2 == true)
        {
            A2 = false;

            lev2.Rotate(0, -70.0f, 0);
            B2 = 0;
           
        }

        if (col.gameObject.name == "levier3_trigger" && Input.GetKeyDown(inputLev) && A3 == false)
        {

            A3 = true;

            lev3.Rotate(0, 70.0f, 0);
            B3 = i;
            i = i + 1;

        }
        else if (col.gameObject.name == "levier3_trigger" && Input.GetKeyDown(inputLev) && A3 == true)
        {
            A3 = false;

            lev3.Rotate(0, -70.0f, 0);
            B3 = 0;
        }

        if (col.gameObject.name == "levier4_trigger" && Input.GetKeyDown(inputLev) && A4 == false)
        {

            A4 = true;

            lev4.Rotate(0, 70.0f, 0);
            B4 = i;
            i = i + 1;

        }
        else if (col.gameObject.name == "levier4_trigger" && Input.GetKeyDown(inputLev) && A4 == true)
        {
            A4 = false;

            lev4.Rotate(0, -70.0f, 0);
            B4 = 0;
        }
    }

    void Update ()
    {

        if (B1 !=0 && B2 !=0 && B3 != 0 && B4 != 0)
        {
            if (B4 == 1 && B1 == 2 && B3 == 3 && B2 == 4)
            {
                trigger_carte.enabled = true;
            } else
                {
                     B1 = 0;
                     B2 = 0;
                     B3 = 0;
                     B4 = 0;
                     i = 1;
                     A4 = false;
                     lev4.Rotate(0, -70.0f, 0);
                     A3 = false;
                     lev3.Rotate(0, -70.0f, 0);
                     A2 = false;
                     lev2.Rotate(0, -70.0f, 0);
                     A1 = false;
                     lev.Rotate(0, -70.0f, 0);
                     
            }
        }

    }

}
