using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GODSObservables
{
    public class RV_WeaponUIDisplay : MonoBehaviour
    {

        public RV_WeaponSOReference weaponReference;

        public Image image => GetComponentInChildren<Image>();
        public TextMeshProUGUI textMesh => GetComponentInChildren<TextMeshProUGUI>();

        private void Start()
        {
            UpdateWeaponDisplay();
        }

        public void UpdateWeaponDisplay()
        {
            if (weaponReference == null)
                return;

            if (weaponReference.Value == null)
                return;

            image.sprite = weaponReference.Value.weaponSprite;
            textMesh.text = weaponReference.Value.weaponName;
        }

        public void SetVariable(RV_WeaponSOVariable variable)
        {
            weaponReference.SetVariable(variable);
        }
    }
}
