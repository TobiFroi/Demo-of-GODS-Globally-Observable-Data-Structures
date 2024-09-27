using UnityEngine;

namespace GODSObservables
{
    public class RV_EnemyCounter : MonoBehaviour
    {
        public IntReference enemyCountReference;
        public GameObjectListReference enemyListReference;


        private void OnEnable()
        {
            enemyCountReference.Value += 1;
        }

        private void OnDisable()
        {
            enemyCountReference.Value -= 1;
        }

    }
}
