using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject10 : MonoBehaviour
{
        [SerializeField] float moveSpeed; //Changed this so you can insert a moveSpeed value.
        [SerializeField] Vector3 moveDirection;

        float totalMoveDistance; //Initialized as float
        Vector3 startingLocation;

        // Start is called before the first frame update
        void Start()
        {
        totalMoveDistance = 10f;
        startingLocation = gameObject.transform.position;
        }

        // Update is called once per frame
        void Update()
        {
          float distanceTraveled = GetDistanceTraveled();

          if (distanceTraveled > totalMoveDistance)
           {
            FlipMoveDirection();
            this.enabled = false; //added line
           }

           gameObject.transform.Translate(moveDirection * moveSpeed);
        }

        void FlipMoveDirection()
        {
           moveDirection = -moveDirection;
           startingLocation = gameObject.transform.position; //added this line
        }

    float GetDistanceTraveled()
    {
      return Vector3.Distance(gameObject.transform.position, startingLocation);
      }
}
