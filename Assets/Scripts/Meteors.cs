using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteors : MonoBehaviour
{
    public GameObject[] graphics;
    int seleccionado;
    Vector2 speed;
        
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < graphics.Length; i++)
        {
            graphics[i].SetActive(false);
        }

        seleccionado = Random.Range(0, graphics.Length);
        graphics[seleccionado].SetActive(true);

        
        speed.x = Random.Range(-5,0);
        speed.y = Random.Range(-2,2);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime);
        graphics[seleccionado].transform.Rotate(0, 0, 100 * Time.deltaTime);
    }
}
