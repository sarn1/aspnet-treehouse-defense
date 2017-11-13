namespace TreehouseDefense
{
    class SlowInvader : Invader
    {
        protected override int StepSize { get; } = 0;

        public override int Health { get; protected set; } = 2;

        public SlowInvader(Path path) : base(path)
        {

        }
    }
}
