using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class vida: MonoBehaviour
{
public float PuntosVida;//coneto de vida
public float VidaMaxima = 5;//Vida maxima
public event EventHandler MuerteJugador;//parametro para enviar

    // Start is called before the first frame update
    void Start()
    {
        PuntosVida = VidaMaxima;
    }

    // se crea una nueva funcion toma golpe
    public void TakeHit(float golpe){
        PuntosVida -= golpe;
        if(PuntosVida <= 0){
            MuerteJugador?.Invoke(this, EventArgs.Empty);//llamar al evento 
            Destroy(gameObject);
        }
    }
}
