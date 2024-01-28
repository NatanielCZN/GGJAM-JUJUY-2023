using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneController : MonoBehaviour
{
    public string escenaJuego;
    public string escenaCreditos;
    FMODUnity.StudioEventEmitter boton;
    
    // Método que se llama cuando se presiona el boton en el Canvas
    public void OnBotonPressPlay()
    {
        // Cargar la nueva escena
        SceneManager.LoadScene(escenaJuego);
    }
    public void OnBotonPressCredits()
    {
        // Cargar la nueva escena
        SceneManager.LoadScene(escenaCreditos);
    }
    public void OnBotonPressExit()
    {
        // Salir
        Application.Quit();
    } 
}