using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_Input : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 axis;

    public Player_Behaviour player;  

    // Update is called once per frame
    void Update()
    {
        axis.x = Input.GetAxis ("Horizontal");
        axis.y = Input.GetAxis ("Vertical");

        //Debug.Log("x:"+axis.x+" y:"+axis.y);
        player.SetAxis(axis);

        if (Input.GetButton("Fire1"))
        {
            Debug.Log("Fire Nave");
            //player.shoot();
        }
    }
}
