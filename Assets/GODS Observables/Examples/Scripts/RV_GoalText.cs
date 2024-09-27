using TMPro;
using UnityEngine;

namespace GODSObservables
{
    public class RV_GoalText : MonoBehaviour
    {
        public TextMeshProUGUI goalTextMesh;

        //called through FloatGameEventListener
        public void UpdateText(float timer)
        {
            goalTextMesh.text = "Goal reached in: " + timer + " seconds";
        }
    }
}