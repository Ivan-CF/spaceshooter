using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteors : MonoBehaviour
{
    public GameObject[] graphics;
    int seleccionado;
    Vector2 speed;
    public AudioSource audioSource;
    public ParticleSystem ps;
        
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

        
        public void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Finish")
            {
                Destroy(this.gameObject);
            }
            else if (other.tag == "Bullet")
            {
                StartCoroutine(DestroyMeteors());
            }
        }

        IEnumerator DestroyMeteors()
        {
            //Desactivo el grafico
            graphics[seleccionado].SetActive(false);

            //Elimino el BoxCollider2D
            Destroy(GetComponent<BoxCollider2D>());


            ps.Play();

            //Lanzo sonido de explosion
            audioSource.Play();

            //Me espero 1 segundo
            yield return new WaitForSeconds(1.0f);

            //Me destruyo a mi mismo
            Destroy(this.gameObject);
        }

    
}
