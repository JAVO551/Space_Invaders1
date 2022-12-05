using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astron : MonoBehaviour
{
    public Transform FirePoint; //manipular el array dentor del vector
    public GameObject Bullet;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){        //si aprietas la tecla space
           Instantiate(Bullet, FirePoint.position, FirePoint.rotation); //instancia bullet la direccion y rotacion
        }    
    }
}
