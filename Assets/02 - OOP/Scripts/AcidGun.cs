using UnityEngine;
using System.Collections;

namespace OOP
{
    public class AcidGun : BaseGun
    {
        [SerializeField]
        private int comboCount;

        private int shotsMade;

        public override bool Shoot()
        {
            bool shot = base.Shoot();
            if (shot)
                CheckCombo();
            return shot;
        }

        private void CheckCombo()
        {
            shotsMade++;
            if (shotsMade >= comboCount)
            {
                ThrowAcid();
                shotsMade = 0;
            }
        }

        private void ThrowAcid()
        { //TODO: }
            Debug.Log ("Throw acid");
        }
    }
}