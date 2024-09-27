using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace GODSObservables
{
    public class RV_EnemyManager_NoReferencedVariables : MonoBehaviour
    {
        public static RV_EnemyManager_NoReferencedVariables Instance;

        public TextMeshProUGUI enemyCountText;

        private List<RV_LookAtTransform_NoReference> enemies;
        public Transform target;

        private void Awake()
        {
            enemies = new List<RV_LookAtTransform_NoReference>();
            Instance = this;
        }


        public void AddEnemyToManager(RV_LookAtTransform_NoReference enemy)
        {
            enemies.Add(enemy);
            enemy.SetTargetTransform(target);
            enemyCountText.text = "Enemy Count: " + enemies.Count.ToString();
        }

        public void RemoveEnemyFromManager(RV_LookAtTransform_NoReference enemy)
        {
            enemies.Remove(enemy);
            enemyCountText.text = "Enemy Count: " + enemies.Count.ToString();
        }

        public void SetNewTarget(Transform newTarget)
        {
            target = newTarget;
            foreach (RV_LookAtTransform_NoReference e in enemies)
            {
                e.SetTargetTransform(target);
            }
        }
    }
}
