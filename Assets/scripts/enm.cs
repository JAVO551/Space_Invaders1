using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enm : MonoBehaviour
{
   public int damage = 1;//se declara una variable publica entero golpe o deterioro 
     public float speed;// se declara una variable velocidad
   

	void Update () {
        transform.Translate(Vector2.left * speed * Time.deltaTime);//declara al vector2 se mueva a la izquierda se
        //multiplica por velocidad y por deltatime velocidad valuada en el inspector
	}

    void OnTriggerEnter2D(Collider2D other)//llama a la funcon de colision
    {
        if (other.CompareTag("jjg")) {//compara con el tag
            //play takes damage
            other.GetComponent<jjg>().health-= damage;//llama al compente vida y le quita deterioro
            Debug.Log(other.GetComponent<jjg>().health);
            Destroy(gameObject);//elimina al objeto de la escena
        }   
    }
}
