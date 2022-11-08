using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
   [SerializeField]private TMP_Text timerText;

    private float timeElapsed;//funcion que tipempo ha pasado
    private int minutes, seconds, cents;


    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;//se aumenta pasando cada frame
        minutes = (int)(timeElapsed / 60f);
        seconds = (int)(timeElapsed - minutes * 60f);
        cents =(int)((timeElapsed - (int)timeElapsed) * 100f);

        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, cents);
    }
}
