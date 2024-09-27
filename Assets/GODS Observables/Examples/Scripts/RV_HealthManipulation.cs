using UnityEngine;

namespace GODSObservables
{


    public class RV_HealthManipulation : MonoBehaviour
    {
        public FloatReference healthReference;
        public FloatReference maxHealthReference;

        public void AddValue(float amount)
        {
            if (healthReference.Value >= maxHealthReference.Value)
                return;

            if (healthReference.Value + amount > maxHealthReference.Value)
                healthReference.Value = maxHealthReference.Value;
            else
                healthReference.Value += amount;
        }

        public void ReduceValue(float amount)
        {
            if (healthReference.Value <= 0)
                return;

            if (healthReference.Value - amount < 0)
                healthReference.Value = 0;
            else
                healthReference.Value -= amount;
        }
    }

}