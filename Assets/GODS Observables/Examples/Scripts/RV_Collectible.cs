using UnityEngine;

namespace GODSObservables
{
    public class RV_Collectible : MonoBehaviour
    {
        public Vector3ListReference collectibleList;
        public IntReference scoreReference;

        private bool disableSilently = false;

        private void OnEnable()
        {
            collectibleList.AddItemUnique(this.transform.position);
        }

        private void OnDisable()
        {
            //Debug.Log("remove collectible");
            if (!disableSilently)
                collectibleList.RemoveItem(this.transform.position);
        }

        public void DestroySilently()
        {
            disableSilently = true;
            Destroy(this.gameObject);
        }

        private void OnTriggerEnter(Collider other)
        {
            //Debug.Log("trigger: " + other.gameObject.name);
            if (other.CompareTag("Player"))
            {
                scoreReference.Value += 1;
                Destroy(this.gameObject);
            }
        }

    }

}
