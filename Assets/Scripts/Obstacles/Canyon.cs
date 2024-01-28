using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canyon : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    [SerializeField] private float initialTime = 0f;

    [SerializeField] private float delay = 1f;

    FMODUnity.StudioEventEmitter disparo;

    private void Start()
    {
        InvokeRepeating("InvokeMunition", initialTime, delay);
        disparo = GameObject.Find("s_disparo").GetComponent<FMODUnity.StudioEventEmitter>();
    }

    private void InvokeMunition()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
