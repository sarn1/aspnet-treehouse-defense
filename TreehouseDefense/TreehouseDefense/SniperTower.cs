namespace TreehouseDefense
{
    class SniperTower : Tower
    {
        protected override int Range { get; } = 2;
        protected double Accuracy { get; } = 1.0;

    }
}
