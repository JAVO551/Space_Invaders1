using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manejador_puntos : MonoBehaviour
{
    public int puntaje;
    public TMP_Text Texto_puntos;
    // Start is called before the first frame update
    void Start()
    {
    Texto_puntos.text = "Puntaje: " + puntaje;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CambioPuntos (int puntos) {
        puntaje += puntos;
        Texto_puntos.text = "Puntaje: " + puntaje;
    }
}
