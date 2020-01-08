using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    //Propiedad
    public string debugString;

    //Campo
    public int numeroRuedas { get; set; }

    void Awake(){
        debugString = "Hola como estas";

        Debug.Log(debugString);

        numeroRuedas = 3;
        
        Debug.Log(numeroRuedas);

    }
}
