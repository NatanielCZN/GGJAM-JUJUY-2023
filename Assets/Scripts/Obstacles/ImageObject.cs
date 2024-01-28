using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageObject : MonoBehaviour
{
    [SerializeField] private float speedRotate = 10f;
    [SerializeField] private GameObject imageUI;

    private void Update()
    {
        transform.Rotate(new Vector3(0f, speedRotate * Time.deltaTime, 0f));        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            imageUI.SetActive(true);

            Destroy(gameObject);
        }
    }
}
