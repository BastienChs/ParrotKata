using System;
using System.Collections.Generic;

namespace Parrot
{
    public abstract class Parrot
    {

        protected Parrot(int numberOfCoconuts, double voltage, bool isNailed)
        {
            
        }

        public abstract double GetSpeed();
        public abstract string GetCry();

        public virtual double GetLoadFactor()
        {
            return 9.0;
        }
        public virtual double GetBaseSpeed(double voltage)
        {
            return Math.Min(24.0, voltage * GetBaseSpeed());
        }

        public virtual double GetBaseSpeed()
        {
            return 12.0;
        }
    }
}