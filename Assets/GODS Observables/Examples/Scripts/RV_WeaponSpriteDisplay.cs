using UnityEngine;

namespace GODSObservables
{
    public class RV_WeaponSpriteDisplay : MonoBehaviour
    {
        public RV_WeaponSOReference weaponReference;

        public SpriteRenderer sprite => GetComponentInChildren<SpriteRenderer>();

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

            sprite.sprite = weaponReference.Value.weaponSprite;
        }

        public void SetVariable(RV_WeaponSOVariable variable)
        {
            weaponReference.SetVariable(variable);
        }
    }

}
