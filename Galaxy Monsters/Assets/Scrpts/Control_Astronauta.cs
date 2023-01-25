using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_Astronauta : MonoBehaviour
{

    public float speed = 5; //Velocidad de movimiento del astronauta
    public float vInput; //Para guardar el balor correspondiente de teclado (-1,0,1)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vInput = Input.GetAxisRaw("Vertical"); //Lee el teclado arriba y abajo

        transform.Translate(Vector2.up * speed * vInput * Time.deltaTime); //Cambio de posicion
        
    }
}
