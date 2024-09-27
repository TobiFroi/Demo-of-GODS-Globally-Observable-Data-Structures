using UnityEngine;

namespace GODSObservables
{
    public class RV_AbilityEffect : MonoBehaviour
    {
        public int abilityID;
        public IntHashSetReference unlockedAbiliyReference;

        public GameObject effectObject;

        private void Start()
        {
            UpdateVisuals();
        }

        public void UpdateVisuals()
        {
            if(unlockedAbiliyReference.HashSet.Contains(abilityID))
            {
                effectObject.SetActive(true);
            }
            else
            {
                effectObject.SetActive(false);
            }
        }
    }
}


