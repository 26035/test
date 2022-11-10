using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5
{
    abstract class Motorcycle
    {
        
        public void StartEngine() { }
        protected void AddGas(int gallons) { }
        double miles = 10;
        double speed = 100;
        public virtual int Drive(int miles, int speed) { return (int)Math.Round(((double)miles)/speed,0); }
        public virtual int Drive(TimeSpan time, int speed) { return 0; }
        public abstract double GetTopSpeed();
    }
    class SportsMotorcycle : Motorcycle
    {
        
        public override double GetTopSpeed()
        {
            return 70.05;
        }
        double _weighRatio = 1.2;
        public override int Drive(int miles, int speed)
        {
            return (int)Math.Round((double)miles / speed, 0) * (int)_weighRatio;
        }
    }
    class SportsMotorCylcleWithSideCar : Motorcycle
    {
        float _weightRatio = 0.8f;
        public override double GetTopSpeed()
        {
            return 70.05;
        }
        public override int Drive(int miles, int speed) { return base.Drive(miles, speed) * (int)_weightRatio; }
    }
}
