using UnityEngine;

namespace GODSObservables
{
    public class RV_EnemyShoot_NoReferencedVariables : MonoBehaviour
    {
        public bool isShooting;
        public Rigidbody prefabToShoot;
        public float projectileSpeed;


        public float shotCooldownMax = 1f;
        public float shotCooldownMin = 0.5f;
        private float currentCooldown = 0.5f;

        private void Update()
        {
            if (isShooting)
            {
                currentCooldown -= Time.deltaTime;
                if (currentCooldown <= 0)
                {
                    Shoot();
                    currentCooldown = Random.Range(shotCooldownMin, shotCooldownMax);
                }
            }
        }

        private void Shoot()
        {
            Rigidbody shot = Instantiate(prefabToShoot, transform.position, Quaternion.identity);
            shot.AddForce(transform.forward * projectileSpeed, ForceMode.Impulse);
        }
    }

}
