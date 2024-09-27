using UnityEngine;

namespace GODSObservables
{
    public class RV_Goal : MonoBehaviour
    {
        public FloatGameEvent gameEvent;
        private float timer = 0;

        void Update()
        {
            timer += Time.deltaTime;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                gameEvent.Raise(timer);
            }
        }
    }
}

