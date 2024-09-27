using TMPro;
using UnityEngine;

namespace GODSObservables
{
    public class RV_EnemySpawnCountInput : MonoBehaviour
    {

        public IntReference spawnCountReference;
        private TMP_InputField inputField => GetComponent<TMP_InputField>();

        private void OnEnable()
        {
            inputField.text = spawnCountReference.Value.ToString();
        }

        public void SetSpawnCount(string inputText)
        {
            int value = int.Parse(inputText);
            if (value > 1000) value = 1000;
            if (value < 1) value = 1;
            spawnCountReference.Value = value;
        }
    }
}
