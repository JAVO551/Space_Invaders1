using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posicion_En2 : MonoBehaviour
{
    public GameObject enemigo2;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate (enemigo2, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
