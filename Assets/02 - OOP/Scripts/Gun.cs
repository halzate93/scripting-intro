using UnityEngine;

namespace OOP
{
    public class Gun : MonoBehaviour, IWeapon
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

        public void Shoot()
        {
            if (ammo > 0)
                SpawnBullet();
            Ammo--;
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