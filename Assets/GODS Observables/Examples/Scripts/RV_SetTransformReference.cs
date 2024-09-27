using UnityEngine;

namespace GODSObservables 
{
	
	public class RV_SetTransformReference : MonoBehaviour
	{
	
	    public TransformReference referenceToSet;
	
	    public void SetReference(Transform newValue)
	    {
	        referenceToSet.Value = newValue;
	    }
	}
	
}