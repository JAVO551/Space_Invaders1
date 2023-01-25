using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Enemigo1 : MonoBehaviour
{
    public float speed; //Velocidad del enemigo
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left*speed*Time.deltaTime); //Direccion movimiento
    }
}
