using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentMunition : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 5f;

    private void Update()
    {
        transform.Translate(transform.forward * bulletSpeed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerController>().TeleportTo();

            Destroy(this.gameObject);
        }

        if(other.gameObject.CompareTag("World"))
        {
            Destroy(this.gameObject);
        }
    }
}
