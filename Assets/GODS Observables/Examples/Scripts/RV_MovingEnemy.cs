using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GODSObservables
{
    public class RV_MovingEnemy : MonoBehaviour
    {
        public float speed = 10;

        private Vector3 initialDirection;
        public float timeUntilTurn = 10f;
        private float timeUntilTurnLeft = 10;

        void Start()
        {
            initialDirection = (Vector3.zero - transform.position).normalized;
            timeUntilTurnLeft = timeUntilTurn;
        }

        void Update()
        {
            timeUntilTurnLeft -= Time.deltaTime;
            if (timeUntilTurnLeft < 0)
            {
                initialDirection *= -1;
                timeUntilTurnLeft = timeUntilTurn;
            }

            Move();
        }

        private void Move()
        {
            transform.Translate(initialDirection * Time.deltaTime * speed);
        }
    }

}
