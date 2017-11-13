namespace TreehouseDefense
{
    class SlowInvader : Invader
    {
        protected override int StepSize { get; } = 0;

        public SlowInvader(Path path) : base(path)
        {

        }
    }
}
