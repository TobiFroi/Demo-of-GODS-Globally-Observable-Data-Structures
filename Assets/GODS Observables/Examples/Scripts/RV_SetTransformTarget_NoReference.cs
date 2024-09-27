using UnityEngine;

namespace GODSObservables
{
    public class RV_SetTransformTarget_NoReference : MonoBehaviour
    {
        public Transform targetToSet;


        //invoked by UI button
        public void SetTargetForEnemies()
        {
            RV_EnemyManager_NoReferencedVariables.Instance?.SetNewTarget(targetToSet);
        }
    }
}
