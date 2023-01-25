using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_mov : MonoBehaviour
{
    public float speed;
    private Manejador_puntos puntuador;
    public GameObject sonido_en2;
    public GameObject sonido_en1;
    
    // Start is called before the first frame update
    void Start()
    {
        puntuador = GameObject.Find("Manejador_Puntos").GetComponent<Manejador_puntos>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed *Time.deltaTime);
    }
    private void OnTriggerEnter2D (Collider2D collision) {
        if (collision.gameObject.tag == "Enemigo1"){
            Destroy(collision.gameObject);
            Instantiate(sonido_en1, transform.position,Quaternion.identity);
            puntuador.CambioPuntos(1);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Enemigo2"){
            Destroy(collision.gameObject);
            Instantiate(sonido_en2, transform.position,Quaternion.identity);
            puntuador.CambioPuntos(2);
            Destroy(gameObject);
        }


    }
}
