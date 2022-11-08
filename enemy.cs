using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform Astron;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    public Transform punto_instancia;
    public GameObject bala;
    private float tiempo;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Astron.position - transform.position;
        float angle = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
        //disparo
        tiempo += Time.deltaTime;
        if(tiempo>=2){
            Instantiate(bala,punto_instancia.position,Quaternion.identity);
            tiempo = 0;
        }
    }

    private void FixedUpdate() {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction){
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

}
