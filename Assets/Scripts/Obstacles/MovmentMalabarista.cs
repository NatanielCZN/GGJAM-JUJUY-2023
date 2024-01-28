using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentMalabarista : MonoBehaviour
{
    [SerializeField] private Transform[] waypoints;
    [SerializeField] private float speed = 5f;

    private int currentWaypointIndex = 0;

    void Update()
    {
        if (waypoints.Length == 0) return;

        Vector3 direction = waypoints[currentWaypointIndex].position - transform.position;

        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        transform.LookAt(waypoints[currentWaypointIndex]);

        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position) < 0.1f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
    }
}
