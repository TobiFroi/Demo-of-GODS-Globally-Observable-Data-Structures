using UnityEngine;

namespace GODSObservables 
{

	
	public class RV_EnemySpawner : MonoBehaviour
	{
		public IntReference enemiesToSpawnCount;
	
	    public GameObject enemyPrefab;
		public GameObject enemyPrefab_noReference;
	    public Vector3 minVector;
	    public Vector3 maxVector;
	
	    public void SpawnEnemies()
	    {
	        for (int i = 0; i < enemiesToSpawnCount.Value; i++)
	        {
	            Vector3 pos = new Vector3(Random.Range(minVector.x, maxVector.x),
	                Random.Range(minVector.y, maxVector.y), Random.Range(minVector.z, maxVector.z));

	            GameObject enemy = Instantiate(enemyPrefab, pos, Quaternion.identity);
	            enemy.AddComponent<GODSInitializer>();

	            enemy.transform.parent = this.transform;
	        }
	    }

		public void SpawnEnemiesWithNoReference()
		{
            for (int i = 0; i < enemiesToSpawnCount.Value; i++)
            {
                Vector3 pos = new Vector3(Random.Range(minVector.x, maxVector.x),
                    Random.Range(minVector.y, maxVector.y), Random.Range(minVector.z, maxVector.z));
                GameObject enemy = Instantiate(enemyPrefab_noReference, pos, Quaternion.identity);
                enemy.transform.parent = this.transform;
            }
        }
	
	    public void DestroyEnemies()
	    {
	        int childCount = transform.childCount;
	
	        // Iterate through each child object and destroy it
	        for (int i = 0; i < childCount; i++)
	        {
	            // Get the child object at index 0 (because as we destroy them, the index changes)
	            Transform child = transform.GetChild(i);
	            
	            // Destroy the child game object
	            Destroy(child.gameObject);
	        }
	        
	    }
	}
	
}