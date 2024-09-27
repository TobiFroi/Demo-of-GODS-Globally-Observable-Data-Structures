using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GODSObservables
{
    public class RV_ObservableHashSetDetonator : MonoBehaviour
    {
        public GameObjectHashSetReference referencedHashSet;

        public GameObject enemyPrefab;
        public Vector3 minSpawnPos;
        public Vector3 maxSpawnPos;


        private void OnTriggerEnter(Collider other)
        {
            if (other is CapsuleCollider)
            {
                referencedHashSet.AddItem(other.gameObject);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other is CapsuleCollider)
            {
                //Debug.Log("trigger exit");
                referencedHashSet.RemoveItem(other.gameObject);
            }
        }

        public void KillEnemiesInsideSphere()
        {
            foreach (GameObject go in referencedHashSet.HashSet)
            {
                Destroy(go);
            }

            referencedHashSet.Clear();
        }

        public void Spawn10Enemies()
        {
            for (int i = 0; i < 10; i++)
            {
                SpawnEnemy();
            }
        }

        public void SpawnEnemy()
        {
            Vector3 pos = new Vector3(Random.Range(minSpawnPos.x, maxSpawnPos.x),Random.Range(minSpawnPos.y, maxSpawnPos.y),Random.Range(minSpawnPos.z, maxSpawnPos.z));
            Instantiate(enemyPrefab, pos, Quaternion.identity);
        }
    }

}

