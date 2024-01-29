using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitScript : MonoBehaviour
{
    public Transform jugador;
    public float distanciaDesaparicion = 5f;

    private bool desaparecido = false;

    void Update()
    {
        if (!desaparecido)
        {
            float distanciaAlJugador = Vector3.Distance(jugador.position, transform.position);

            // Si el jugador esta cerca, desactiva el conejo y desaparece
            if (distanciaAlJugador < distanciaDesaparicion)
            {
                gameObject.SetActive(false);
                desaparecido = true;
            }
        }
    }
}