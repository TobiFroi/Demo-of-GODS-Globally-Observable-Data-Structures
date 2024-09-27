using TMPro;
using UnityEngine;

namespace GODSObservables
{
    public class RV_ObservableListCounter : MonoBehaviour
    {
        public GameObjectListReference referencedList;

        private TextMeshProUGUI myText => GetComponent<TextMeshProUGUI>();

        public void UpdateText()
        {
            //React to list changes here
            myText.text = referencedList.List.Count.ToString();
        }
    }

}


