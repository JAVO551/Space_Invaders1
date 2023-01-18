using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D MyRb;
    public float Speed;//variable de velocidad


    // Start is called before the first frame update
    void Start()
    {
        MyRb=GetComponent<Rigidbody2D>();//autoreferencia para saber que esta en el rigidbory
    }

    // Update is called once per frame
    void Update()
    {
       MyRb.velocity = transform.right * Speed; 
       Destroy(gameObject, 5f);
    }
   
}
