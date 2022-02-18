using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public GameObject position0;
    public GameObject position1;

    public float speed = 1.5f;
    public float minGoalDistance = 0.1f;

    void Update()
    {
        AiMoveTowards(position0.transform);
        // Vector2.MoveTowards(transform.position, position0.transform.position, 1 * Time.deltaTime);

        // < less than
        // <= less than or equals
        // > greater than
        // >= greater than or equals
        // = equals

        // transform.position = Vector2.MoveTowards(current: transform.position, target: position0.transform.position, Time.deltaTime);

    }

    private void AiMoveTowards(Transform goal)
    {
        Vector2 AiPosition = transform.position;
        
        //If we are not near the goal
        if (Vector2.Distance(a:AiPosition, b:(Vector2)goal.position) < minGoalDistance)
        {
            //direction from A to B
            //is B - A
            //method 3
            Vector2 directionToGoal = (goal.position - transform.position);
            directionToGoal.Normalize();
            transform.position += (Vector3)directionToGoal * speed * Time.deltaTime;
        }
        else
        {
            transform.position = position0.transform.position;
        }
    }
}
