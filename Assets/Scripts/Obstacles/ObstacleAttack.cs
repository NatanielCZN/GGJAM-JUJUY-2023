using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAttack : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerController>().TeleportTo();
        }
    }
}
