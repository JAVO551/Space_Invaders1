using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public GameObject[] enemigos1;
    private float tiempo_entre_generacion;
    public float tiempo_inicio;
    public float decremento;
    public float tiempo_minimo = 1;

    // Update is called once per frame
    void Update()
    {

        if (tiempo_entre_generacion <= 0) {
            int rand = Random.Range(0, enemigos1.Length);
            Instantiate (enemigos1[rand],transform.position,Quaternion.identity);
                if (tiempo_inicio > tiempo_minimo) {
                    tiempo_inicio -= decremento;
                }
                tiempo_entre_generacion = tiempo_inicio;
            
        } else {
            tiempo_entre_generacion -= Time.deltaTime;
        }

    }



}
