using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Vida_Nave : MonoBehaviour
{


    public int vida = 50;
    public TMP_Text Texto_nave;
    public GameObject sonido_muerte;
    public GameObject sonido_golpe;
    public GameObject GameOver;

    // Start is called before the first frame update
    void Start()
    {
        Texto_nave.text = "Nave: " + vida;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {

        if (collision.collider.gameObject.tag == "Enemigo1") {
            Destroy (collision.collider.gameObject);
            vida -= 1;
            Instantiate(sonido_golpe, transform.position,Quaternion.identity);
            Texto_nave.text = "Nave: " + vida;
            if (vida <= 0) {
                Instantiate(sonido_muerte, transform.position,Quaternion.identity);
                GameOver.SetActive(true);
                Destroy (gameObject);
            }
        }
        if (collision.collider.gameObject.tag == "Enemigo2") {
            Destroy (collision.collider.gameObject);
            vida -= 2;
            Instantiate(sonido_muerte, transform.position,Quaternion.identity);
            Texto_nave.text = "Nave: " + vida;
            if (vida <= 0) {
                Instantiate(sonido_muerte, transform.position,Quaternion.identity);
                GameOver.SetActive(true);
                Destroy (gameObject);
            }
        }


    }

    
}
