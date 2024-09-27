using UnityEngine;

namespace GODSObservables 
{
	
    public class RV_Player : MonoBehaviour
    {
	
        public FloatReference healthReference;

        public ParticleSystem healParticles;
        public ParticleSystem damageParticles;

        public MeshRenderer[] renderers;
	
        public void UpdateVisuals(float playerHealth)
        {
            if (healthReference.Value <= 0)
            {
                foreach (MeshRenderer r in renderers)
                {
                    r.enabled = false;
                }
            }
            else
            {
                foreach (MeshRenderer r in renderers)
                {
                    r.enabled = true;
                }
            }
        }

        public void ActivateParticles()
        {
            if(healthReference.Value < healthReference.PreviousValue)
                damageParticles.Play();
            else
                healParticles.Play();
        }
    }
}