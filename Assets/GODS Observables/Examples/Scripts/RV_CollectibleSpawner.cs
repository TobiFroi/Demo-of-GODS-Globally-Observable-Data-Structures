using UnityEngine;

namespace GODSObservables
{
    public class RV_CollectibleSpawner : MonoBehaviour
    {
        public Vector3ListReference collectiblePositions;
        public GameObject collectiblePrefab;

        public Vector3 minPos;
        public Vector3 maxPos;

        public void OnSaveLoaded()
        {
            RV_Collectible[] collectibles = GameObject.FindObjectsOfType<RV_Collectible>();
            foreach (RV_Collectible collectible in collectibles)
            {
                collectible.DestroySilently();
            }

            SpawnCollectiblesAtSavedPositions();
        }

        public void SpawnCollectiblesAtSavedPositions()
        {
            for (int i = 0; i < collectiblePositions.List.Count; i++)
            {
                SpawnCollectible(collectiblePositions.List[i]);
            }
        }

        public void SpawnCollectibles(int count)
        {
            for(int i=0; i < count; i++)
            {
                Vector3 pos = new Vector3(Random.Range(minPos.x,maxPos.x), Random.Range(minPos.y,maxPos.y), Random.Range(minPos.z,maxPos.z));
                SpawnCollectible(pos);
            }
        }

        public void SpawnCollectible(Vector3 pos)
        {
            //Debug.Log("spawn object at: "+pos.ToString());
            Instantiate(collectiblePrefab, pos, Quaternion.identity);
        }
    }
}
