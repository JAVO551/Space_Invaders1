using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruir3 : MonoBehaviour
{
        private void OnTriggerEnter2D(Collider2D other) {//cuando toca un rigidy body se destruye
            Destroy(gameObject);
        }
}
