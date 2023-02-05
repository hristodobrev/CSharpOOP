namespace Exercise1.Exceptions
{
    public class HeroNotFoundException : Exception
    {
        public HeroNotFoundException(string heroType) : base($"Hero {heroType} not found!")
        {
            this.HeroType = heroType;
        }

        public string HeroType { get; set; }
    }
}
