using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace GODSObservables
{
    public class RV_ObservableHashSetCounter : MonoBehaviour
    {
        public GameObjectHashSetReference referencedHashSet;
        private TextMeshProUGUI myText => GetComponent<TextMeshProUGUI>();

        public void UpdateText()
        {
            //React to list changes here
            myText.text = referencedHashSet.HashSet.Count.ToString();
        }
    }
}

