using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    // Start is called before the first frame update
    public void Jugar () {
        SceneManager.LoadScene ("Juego");
    }

    public void Salir () {
    Debug.Log("Salir...");
    Application.Quit();
    }
}
