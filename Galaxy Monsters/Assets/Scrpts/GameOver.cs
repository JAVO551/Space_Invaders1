using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void Reiniciar () {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
    }
    public void MenuInicial () {
        SceneManager.LoadScene("MainMenu");
    }
    public void Salir () {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

}
