namespace Parrots
{
    public class EuropeanParrot: Parrot.Parrot
    {
        public EuropeanParrot(int numberOfCoconuts, double voltage, bool isNailed)
            : base(numberOfCoconuts, voltage, isNailed)
        {
        }

        public override double GetSpeed()
        {
            return GetBaseSpeed();
        }

        public override string GetCry()
        {
            return "Sqoork!";
        }
    }
}