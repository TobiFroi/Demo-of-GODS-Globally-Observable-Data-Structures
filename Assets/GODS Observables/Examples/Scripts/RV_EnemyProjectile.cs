using UnityEngine;

namespace GODSObservables
{
    public class RV_EnemyProjectile : MonoBehaviour
    {

        public FloatReference damage;

        private void Start()
        {
            Destroy(this.gameObject, 2);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                other.GetComponent<RV_Player>().healthReference.Value -= damage.Value;
                Destroy(this.gameObject);
            }
        }
    }
}
