using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canyon : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    [SerializeField] private float initialTime = 0f;

    [SerializeField] private float delay = 1f;

    private void Start()
    {
        InvokeRepeating("InvokeMunition", initialTime, delay);
    }

    private void InvokeMunition()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
