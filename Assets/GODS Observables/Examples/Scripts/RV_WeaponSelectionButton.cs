using UnityEngine;
using UnityEngine.UI;

namespace GODSObservables
{
    public class RV_WeaponSelectionButton : MonoBehaviour
    {

        public RV_WeaponSOReference weaponReferenceToSet;
        public RV_WeaponSO myWeapon;
        public Image weaponImage;

        public void SetWeaponReference()
        {
            weaponReferenceToSet.Value = myWeapon;
        }

        public void SetVariable(RV_WeaponSOVariable variable)
        {
            weaponReferenceToSet.SetVariable(variable);
        }

    }
}
