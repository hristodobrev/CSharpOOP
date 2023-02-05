namespace Exercise1.Shields
{
    public abstract class Shield
    {
        private int blockRate;

        public virtual int BlockRate
        {
            get
            {
                Random random = new Random();
                double percentage = random.Next(9, 11) / 10.0;

                return (int)(percentage * blockRate);
            }
            protected set
            {
                this.blockRate = value;
            }
        }
    }
}
