using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Behaviour : MonoBehaviour
{
    public float speed;
    private Vector2 axis;

    void Update () {
        transform.Translate(axis * speed * Time.deltaTime);
    }
    public void SetAxis (Vector2 currentaxis){
        axis = currentaxis;
    }
    
}
