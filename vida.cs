using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida: MonoBehaviour
{
public float PuntosVida;//coneto de vida
public float VidaMaxima = 5;//Vida maxima


    // Start is called before the first frame update
    void Start()
    {
        PuntosVida = VidaMaxima;
    }

    // se crea una nueva funcion toma golpe
    public void TakeHit(float golpe){
        PuntosVida -= golpe;
        if(PuntosVida <= 0){
            Destroy(gameObject);
        }
    }
}
