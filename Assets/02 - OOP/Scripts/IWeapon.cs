namespace OOP
{
    public interface IWeapon
    {
        int Ammo { get; } //Properties can be defined as well.
        void Shoot(); //All methods on a interface are public.
    }
}