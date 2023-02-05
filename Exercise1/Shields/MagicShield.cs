namespace Exercise1.Shields
{
    internal class MagicShield : Shield
    {
        public MagicShield()
        {
            this.BlockRate = 2;
        }

        public override int BlockRate
        {
            get
            {
                Random random = new Random();
                int rand = random.Next(1, 6);
                if (rand == 1)
                    return base.BlockRate * 2;

                return base.BlockRate;
            }
            protected set
            {
                base.BlockRate = value;
            }
        }
    }
}
