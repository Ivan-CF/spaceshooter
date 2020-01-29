using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private Vector2 speed = new Vector2(0, 0);
    public GameObject Bullet;

    private void Start()
    {
        StartCoroutine(EnemyBehaviour());
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime);
    }

    IEnumerator EnemyBehaviour()
    {
        while (true)
        {
            //Avanza horizontalmente
            
            speed.x = -1f;
            speed.y = 1f;
            yield return new WaitForSeconds(1.0f);

            //Se para
            speed.x = 0f;
            speed.y = 0f;
            yield return new WaitForSeconds(1.0f);

            speed.x =-1f;
            speed.y = -1f;
            yield return new WaitForSeconds(1.0f);

            speed.x = 0f;
            speed.y = 0f;
            yield return new WaitForSeconds(1.0f);

            //Dispara
            GameObject bala = Instantiate(Bullet, transform.position, Quaternion.identity, null);
            bala.transform.Rotate(0, 0, -180);
        }
    }
}
