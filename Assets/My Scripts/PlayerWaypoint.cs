using UnityEngine;

public class PlayerWaypoint : MonoBehaviour
{
    public Transform[] waypoints;
    private int currentWaypointIndex = 0;
    private bool movingForward = true;
    public float speed = 5f;

    void Update()
    {
        Transform targetWaypoint = waypoints[currentWaypointIndex];
        transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, speed * Time.deltaTime);

        // Check if the GameObject has reached the target waypoint
        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
        {
            if (movingForward)
            {
                if (currentWaypointIndex < waypoints.Length - 1)
                    currentWaypointIndex++;
                else
                {
                    movingForward = false; // Change direction
                }
            }
            else // Moving backward
            {
                if (currentWaypointIndex > 0)
                    currentWaypointIndex--;
                else
                {
                    movingForward = true; // Change direction
                }
            }
        }

        // This line was removed to prevent the GameObject from rotating towards the waypoint:
        // transform.forward = Vector3.Normalize(targetWaypoint.position - transform.position);
    }
}