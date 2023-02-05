namespace Exercise1.Exceptions
{
    public class ShieldNotFoundException : Exception
    {
        public ShieldNotFoundException(string shieldType) : base($"Shield {shieldType} not found!")
        {
            this.ShieldType = shieldType;
        }

        public string ShieldType { get; set; }
    }
}
