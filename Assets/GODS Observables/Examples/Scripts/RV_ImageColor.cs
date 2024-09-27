using UnityEngine;
using UnityEngine.UI;

namespace GODSObservables
{

    public class RV_ImageColor : MonoBehaviour
    {

        public ColorReference colorReference;

        private Image myImage;

        private void Start()
        {
            myImage = GetComponent<Image>();
            colorReference.onValueChanged.AddListener(UpdateImageColor);
            UpdateImageColor(colorReference.Value);
        }

        public void UpdateImageColor(Color c)
        {
            myImage.color = c;
        }

        public void SetVariable(ColorVariable variable)
        {
            colorReference.SetVariable(variable);
        }
    }

}