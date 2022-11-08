using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void EscenaJuego(){
        SceneManager.LoadScene("esc1");
    }

    public void CargarNivel(string nombreNivel){
        SceneManager.LoadScene("opciones");

    }

    public void Salir(){
        Application.Quit();
    }

}
