using UnityEngine;

namespace GODSObservables
{
    public class RV_MaterialButton : MonoBehaviour
    {

        public MaterialReference materialReference;

        public void SetMaterial(Material material)
        {
            materialReference.Value = material;
        }
    }
}
