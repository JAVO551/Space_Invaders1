using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Enemigo2 : MonoBehaviour
{
    public float speed;
    public float speed2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        transform.Translate(Vector2.left * speed2 * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.gameObject.tag == "Borde") {
            speed *= -1;
        }
    }
}
