using UnityEngine;
using UnityEngine.UI;

namespace GODSObservables 
	{

	
	public class RV_HealthUISlider : MonoBehaviour
	{
	    public FloatReference healthReference;
	    public Slider mySlider;

		void Start()
		{
			if(mySlider == null)
				mySlider = GetComponent<Slider>();

			mySlider.maxValue = healthReference.Value;
			UpdateSliderValue();
		}

	    public void UpdateSliderValue()
	    {
	        mySlider.value = healthReference.Value; 
	    }
	}
}