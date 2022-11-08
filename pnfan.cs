using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pnfan : MonoBehaviour
{
    public GameObject ene;

    void Start() {
        Instantiate(ene,transform.position, Quaternion.identity);
    }
}
