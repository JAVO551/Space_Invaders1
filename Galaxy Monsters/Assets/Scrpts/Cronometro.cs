using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Cronometro : MonoBehaviour
{
    private float tiempo=0;
    public TMP_Text Texto_tiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        Texto_tiempo.text = "Tiempo:" + string.Format("{0:0.00}",tiempo);
    }
}
