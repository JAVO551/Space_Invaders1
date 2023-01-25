using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posicion_En1 : MonoBehaviour
{

    public GameObject enemigo1;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate (enemigo1, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
