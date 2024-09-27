using UnityEngine;

namespace GODSObservables
{
    public class RV_EnemyShoot : MonoBehaviour
    {
        public BoolReference isShooting;
        public RigidbodyReference prefabToShoot;
        public FloatReference projectileSpeed;


        public float shotCooldownMax = 1f;
        public float shotCooldownMin = 0.5f;
        private float currentCooldown = 0.5f;

        private void Update()
        {
            if(isShooting.Value)
            {
                currentCooldown -= Time.deltaTime;
                if(currentCooldown <= 0)
                {
                    Shoot();
                    currentCooldown = Random.Range(shotCooldownMin, shotCooldownMax);
                }
            }
        }

        private void Shoot()
        {
            if (prefabToShoot.Value == null)
                return;

            Rigidbody shot = Instantiate(prefabToShoot.Value, transform.position, Quaternion.identity);
            shot.AddForce(transform.forward * projectileSpeed.Value, ForceMode.Impulse);
        }
    }

}
