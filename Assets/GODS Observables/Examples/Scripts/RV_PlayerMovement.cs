using UnityEngine;

namespace GODSObservables
{
    public class RV_PlayerMovement : MonoBehaviour
    {

        public float speed = 5;
        public Vector3Reference positionReference;

        private Rigidbody rb => GetComponent<Rigidbody>();

        void Start()
        {

        }

        void Update()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            // Create a Vector3 based on the input
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical) * speed  * Time.deltaTime;

            transform.Translate(movement);

            //store position
            if(positionReference.Variable() != null)
                positionReference.Value = transform.position;
        }

        public void OnSaveLoaded()
        {
            if (positionReference.Variable() != null)
                transform.position = positionReference.Value;
        }
    }
}
