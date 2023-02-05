namespace Exercise1.Exceptions
{
    public class WeaponNotFoundException : Exception
    {
        public WeaponNotFoundException(string weaponType) : base($"Weapon {weaponType} not found!")
        {
            this.WeaponType = weaponType;
        }

        public string WeaponType { get; set; }
    }
}
