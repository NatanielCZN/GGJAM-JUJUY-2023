using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneControllerGame: MonoBehaviour
{
    public string escenaAtras;

    // Método que se llama cuando se presiona el boton en el Canvas
    public void OnBotonPressMenu()
    {
        // Cargar la nueva escena
        SceneManager.LoadScene(escenaAtras);
    }

}