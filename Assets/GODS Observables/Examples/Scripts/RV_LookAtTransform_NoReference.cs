using UnityEngine;

namespace GODSObservables
{

    public class RV_LookAtTransform_NoReference : MonoBehaviour
    {

        public Transform targetTransform;

        public float rotationSpeed = 150;

        private RV_AnimationController animController => GetComponent<RV_AnimationController>();


        private void Start()
        {
            RV_EnemyManager_NoReferencedVariables.Instance?.AddEnemyToManager(this);
        }

        private void OnDestroy()
        {
            RV_EnemyManager_NoReferencedVariables.Instance?.RemoveEnemyFromManager(this);
        }


        void Update()
        {
            if (targetTransform == null)
                return;


            Vector3 relativePos = targetTransform.position - transform.position;

            Quaternion targetRot = Quaternion.LookRotation(relativePos, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRot, rotationSpeed * Time.deltaTime);
        }

        public void SetTargetTransform(Transform targetTransform)
        {
            this.targetTransform = targetTransform;
            animController.SetAnimation("Retarget");
        }
    }

}