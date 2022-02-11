using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public GameObject position0;
    public GameObject position1;


    void Update()
    {
        Vector2 AiPosition = transform.position;

        // transform.position = Vector2.MoveTowards(current: transform.position, target: position0.transform.position, Time.deltaTime);


        //method 1
        /*
        if (transform.position.x < position0.transform.position.x) //move Right
        {
            //Move Right
            AiPosition.x += (1 * Time.deltaTime);
            transform.position = AiPosition;
        }
        else
        {
            //Move Left
            AiPosition.x -= (1 * Time.deltaTime);
            transform.position = AiPosition;
        }

        //method 2
        if (transform.position.y < position0.transform.position.y)
        {
            transform.position += (Vector3) Vector2.up * 1 * Time.deltaTime;
        }
        else
        {
            transform.position -= (Vector3) Vector2.up * 1 * Time.deltaTime;
        } */
        

        //direction from A to B
        //is B - A

        //method 3
        Vector2 directionToPos0 = (position0.transform.position - transform.position);
        directionToPos0.Normalize();
        transform.position += (Vector3) directionToPos0 * 1 * Time.deltaTime;
    }
}
