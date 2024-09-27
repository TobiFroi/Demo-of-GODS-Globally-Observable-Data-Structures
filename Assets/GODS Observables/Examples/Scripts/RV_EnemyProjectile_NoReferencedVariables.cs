using UnityEngine;

namespace GODSObservables
{
    public class RV_EnemyProjectile_NoReferencedVariables : MonoBehaviour
    {

        public float damage = 1;
        private void Start()
        {
            Destroy(this.gameObject, 2);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                other.GetComponent<RV_Player>().healthReference.Value -= damage;
                Destroy(this.gameObject);
            }
        }
    }

}
