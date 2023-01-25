using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    private bool pausado;
    public GameObject panelpausa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetButtonDown("Cancel")) {
        if (pausado) {
            ResumeGame();
        } else {
            PauseGame();
        }
     }   
    }
    public void PauseGame () {
        Time.timeScale = 0;
        pausado = true;
        panelpausa.SetActive(true);
    }
    public void ResumeGame () {
        Time.timeScale = 1;
        pausado = false;
        panelpausa.SetActive(false);
    }
}
