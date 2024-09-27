using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GODSObservables
{
    public class RV_AbilityButton : MonoBehaviour
    {
        private Image myImage => GetComponent<Image>();
        private TextMeshProUGUI myText => GetComponentInChildren<TextMeshProUGUI>();

        public int myID = 1;
        public IntHashSetReference unlockedAbilitiesReference;
       

        public Color lockedColor;
        public Color unlockedColor;

        private void Start()
        {
            UpdateVisuals();
        }

        public void ToggleUnlocked()
        {
            if(unlockedAbilitiesReference.HashSet.Contains(myID))
            {
                unlockedAbilitiesReference.RemoveItem(myID);
            }
            else
            {
                unlockedAbilitiesReference.AddItem(myID);
            }

            UpdateVisuals();
        }

        public void UpdateVisuals()
        {
            myText.text = "Skill\n" + myID;
            if (unlockedAbilitiesReference.HashSet.Contains(myID))
            {
                myImage.color = unlockedColor;
            }
            else
            {
                myImage.color = lockedColor;
            }
        }
    }

}
