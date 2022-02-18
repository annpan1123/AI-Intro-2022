using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public Transform player;
    public float chaseDistance = 3;

    public Transform[] waypoints;
    public int waypointIndex = 0;

    public float speed = 1.5f;
    public float minGoalDistance = 0.1f;

    void Update()
    {

        if (Vector2.Distance(transform.position, player.position) < chaseDistance)
        {
            //Move towards the player
            AiMoveTowards(player);
        }
        else
        {
            WaypointUpdate();
            //Move towards our waypoint
            AiMoveTowards(waypoints[waypointIndex]);
            
        }
        // Vector2.MoveTowards(transform.position, position0.transform.position, 1 * Time.deltaTime);

        // < less than
        // <= less than or equals
        // > greater than
        // >= greater than or equals
        // = equals

        // transform.position = Vector2.MoveTowards(current: transform.position, target: position0.transform.position, Time.deltaTime);
    }

    private void WaypointUpdate()
    {
        Vector2 AiPosition = transform.position;

        if (Vector2.Distance(AiPosition, waypoints[waypointIndex].position) < minGoalDistance)
        {
            waypointIndex++;
            
            if(waypointIndex >= waypoints.Length)
            {
                waypointIndex = 0;
            }
        }
    }

    private void AiMoveTowards(Transform goal)
    {
        Vector2 AiPosition = transform.position;
        
        //If we are not near the goal
        if (Vector2.Distance(AiPosition, goal.position) > minGoalDistance)
        {
            //direction from A to B
            //is B - A
            //method 3
            Vector2 directionToGoal = (goal.position - transform.position);
            directionToGoal.Normalize();
            transform.position += (Vector3)directionToGoal * speed * Time.deltaTime;
        }
    }
}
