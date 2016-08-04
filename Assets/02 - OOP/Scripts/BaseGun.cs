using UnityEngine;

namespace OOP
{
    public class BaseGun : MonoBehaviour
    {
        [SerializeField]
        private int ammo = 10;

        public int Ammo
        {
            get { return ammo; }
            private set
            {
                ammo = value;
                if (ammo <= 0)
                    PlayEmptySound();
            }
        }

        public virtual bool Shoot()
        {
            if (ammo > 0)
            {
                SpawnBullet();
                Ammo--;
                return true;
            }
            else
                return false;
        }

        private GameObject SpawnBullet()
        {
            return null;
            //TODO: Shoot bullet
        }

        private void PlayEmptySound()
        {
            //TODO: Play sound
        }
    }

}