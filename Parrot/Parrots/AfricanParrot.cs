using System;

namespace Parrots
{
    public class AfricanParrot: Parrot.Parrot
    {
        private readonly int _numberOfCoconuts;

        public AfricanParrot(int numberOfCoconuts, double voltage, bool isNailed)
            : base(numberOfCoconuts, voltage, isNailed)
        {
            _numberOfCoconuts = numberOfCoconuts;
        }

        public override double GetSpeed()
        {
            return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);
        }

        public override string GetCry()
        {
            return "Sqaark!";
        }
    }
}