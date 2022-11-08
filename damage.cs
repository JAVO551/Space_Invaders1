using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
   public float Speed = 3.0f; //variable de la velocidad

    void Update() {
        //transform.position += -transform.right * Time.deltaTime * Speed;/*tranforma la posicion, 
        //se mueve al lado izquierdo y multiplica al tiempo y la velocidad*/

    } 
    private void OnCollisionEnter2D(Collision2D collision) {
        
        var enemigo = collision.collider.GetComponent<vida>();
        if(enemigo){
            enemigo.TakeHit(1); //hacer un punto de damage
        }
        Destroy(gameObject);

    }
}
