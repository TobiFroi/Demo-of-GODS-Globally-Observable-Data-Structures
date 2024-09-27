using UnityEngine;
using UnityEngine.SceneManagement;

namespace GODSObservables 
{
	
	public class RV_LoadScene : MonoBehaviour
	{
	
	   public void LoadScene(string sceneName)
	   {
	      SceneManager.LoadScene(sceneName);
	   }
	
	   public void ReloadScene()
	   {
	      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	   }
	}
	
}