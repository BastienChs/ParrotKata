namespace Parrots
{
    public class NorwegianBlueParrot: Parrot.Parrot
    {
        private readonly double _voltage;
        private readonly bool _isNailed;
        public NorwegianBlueParrot(int numberOfCoconuts, double voltage, bool isNailed)
            : base(numberOfCoconuts, voltage, isNailed)
        {
            this._voltage = voltage;
            this._isNailed = isNailed;
        }

        public override double GetSpeed()
        {
            return _isNailed ? 0 : GetBaseSpeed(_voltage);
        }

        public override string GetCry()
        {
            return _voltage > 0 ? "Bzzzzzz" : "...";
        }
    }
}