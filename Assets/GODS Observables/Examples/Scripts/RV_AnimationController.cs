using UnityEngine;

namespace GODSObservables 
{
	
	public class RV_AnimationController : MonoBehaviour
	{
	    private Animator myAnim => GetComponent<Animator>();
	
	
	    public void SetAnimation(string animationName)
	    {
	        //Debug.Log("set animation");
	        myAnim.Play(animationName, 0, 0);
	    }
	}
	
}