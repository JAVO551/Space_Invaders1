using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{

    public GameObject proyectil;
    public GameObject sonido_disparo;
    public float cooldown ;
    private float tiempo_cambio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && tiempo_cambio <= 0) {
            Instantiate(proyectil, transform.position,Quaternion.identity);
            Instantiate(sonido_disparo, transform.position,Quaternion.identity);
            tiempo_cambio = cooldown;
        } else {
            tiempo_cambio -= Time.deltaTime;
        }
    }
}
