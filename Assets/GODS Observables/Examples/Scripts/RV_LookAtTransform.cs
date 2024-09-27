using UnityEngine;

namespace GODSObservables 
	{

	
	public class RV_LookAtTransform : MonoBehaviour
	{
	    public TransformReference target;
	
	    public float rotationSpeed = 150;
	
	    void Update()
	    {
	        if (target.Value == null)
	            return;
	
			//consider storing the target transform in a separate variable and updating it through the referenced variable event
	        Vector3 relativePos = target.Value.position - transform.position;

	        Quaternion targetRot = Quaternion.LookRotation(relativePos, Vector3.up);
	        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRot, rotationSpeed * Time.deltaTime);
	    }
	}
}