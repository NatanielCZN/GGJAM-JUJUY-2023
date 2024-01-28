using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementLanzallamas : MonoBehaviour
{
    [SerializeField] private GameObject objectToToggle;
    [SerializeField] private float toggleInterval = 2f;
    [SerializeField] private float rotationSpeed = 45f;

    private float timer;
    private bool isActive = true;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= toggleInterval)
        {
            isActive = !isActive;

            objectToToggle.SetActive(isActive);

            timer = 0f;
        }

        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
