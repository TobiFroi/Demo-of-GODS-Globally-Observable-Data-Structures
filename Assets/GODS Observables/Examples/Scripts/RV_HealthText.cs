using UnityEngine;

namespace GODSObservables 
{
	
	public class RV_HealthText : MonoBehaviour
	{
	    public FloatReference playerHealthRef;

	    private TextMesh text;
	  
	    private void Awake()
	    {
		    text = GetComponentInChildren<TextMesh>();
	        UpdateText();
	    }
	
	    public void UpdateText()
	    {
	        text.text = playerHealthRef.Value.ToString();
	    }
	}
}

