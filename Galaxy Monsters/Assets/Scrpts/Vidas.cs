using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public int vidas = 3;
    public Image[] vidasUI;
    public GameObject sonido_muerte;
    public GameObject sonido_golpe;
    public GameObject GameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {

        if (collision.collider.gameObject.tag == "Enemigo1") {
            Destroy (collision.collider.gameObject);
            vidas -= 1;
            Instantiate(sonido_golpe, transform.position,Quaternion.identity);
            for (int c =0; c< vidasUI.Length; c++) {
                if (c <vidas) {
                    vidasUI[c].enabled = true;
                } else {
                    vidasUI[c].enabled = false;
                }
            }
            if (vidas <= 0) {
                Instantiate(sonido_muerte, transform.position,Quaternion.identity);
                GameOver.SetActive(true);
                Destroy (gameObject);
            }
        }

        if (collision.collider.gameObject.tag == "Enemigo2") {
            Destroy (collision.collider.gameObject);
            vidas -= 2;
            Instantiate(sonido_golpe, transform.position,Quaternion.identity);
            for (int c =0; c< vidasUI.Length; c++) {
                if (c <vidas) {
                    vidasUI[c].enabled = true;
                } else {
                    vidasUI[c].enabled = false;
                    vidasUI[c].enabled = false;
                }
            }
            if (vidas <= 0) {
                Instantiate(sonido_muerte, transform.position,Quaternion.identity);
                GameOver.SetActive(true);
                Destroy (gameObject);
                
            }
        }



    }

}
