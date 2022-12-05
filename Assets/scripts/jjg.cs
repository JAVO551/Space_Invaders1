using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class jjg : MonoBehaviour
{
  

    private Vector2 targetPos;//funcion vector2 nos perimite ubicar en el plano
    public float Yincrement;//variable publica para ver cuannto avanza
    
    public float speed;//variable publica velocidad nos permite incrementar la velocidad
    public float maxHeight;//la altura maxima que puede tomar
    public float minHeight;//la altura minima que puede tomar

    public int health = 3;//la vida del jugador

    public Text healthDisplay;

    private void Update()//funcion privada se muestra en consola
    {
        healthDisplay.text = health.ToString();//convertir en cadena

        if(health <=0 ){            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
//funcion que transforma la posicion por un tiempo por frame
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight ){//condicional if seleccinasla tecla arriba
             targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            //la funcion se asigna a un nuevo vector que incrementa en el eje y positivo
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight) {//condicional if seleccinasla tecla arriba
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            //la funcion se asigna a un nuevo vector que incrementa en el eje y positivo
        }
    }
}
