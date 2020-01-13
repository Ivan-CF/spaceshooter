using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Behaviour : MonoBehaviour
{
    public float speed;
    private Vector2 axis;
    public Vector2 limits;

    void Update () {
        transform.Translate (axis * speed * Time.deltaTime);
 
        if (transform.position.x > limits.x) {
            transform.position = new Vector3 (limits.x, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -limits.x) {
            transform.position = new Vector3 (-limits.x, transform.position.y, transform.position.z);
        }
 
        if (transform.position.y > limits.y) {
            transform.position = new Vector3 (transform.position.x, limits.y, transform.position.z);
        }
        else if (transform.position.y < -limits.y) {
            transform.position = new Vector3 (transform.position.x, -limits.y, transform.position.z);
        }
    }
    public void SetAxis (Vector2 currentAxis){
        axis = currentAxis;
    }
    public void SetAxis(float x, float y){
        axis= new Vector2(x,y);
	}

    
}
