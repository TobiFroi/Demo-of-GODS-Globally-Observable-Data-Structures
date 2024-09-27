using UnityEngine;

namespace GODSObservables
{
    public class RV_TextureButton : MonoBehaviour
    {

        public TextureReference textureReference;

        public void SetTexture(Texture texture)
        {
            textureReference.Value = texture;
        }
    }
}
