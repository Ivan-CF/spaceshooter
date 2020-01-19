using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot2 : MonoBehaviour
{
    public float speed;
    public Vector2 direction;
    private float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        timer += Time.deltaTime;
        if (timer > 0.0f)
        {
            direction.x = 1f;
            direction.y = 0f;
        }
        if (timer > 0.5f)
        {
            direction.x = 0f;
            direction.y = 1f;
        }
        if (timer > 1f)
        {
            direction.x = 1f;
            direction.y = 0f;
        }
        if (timer > 1.5f)
        {
            direction.x = 0f;
            direction.y = -1f;
        }
        if (timer > 2f)
        {
            timer = 0f;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
            Destroy(this);

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Finish")
        {
            Destroy(gameObject);
        }
    }
}
