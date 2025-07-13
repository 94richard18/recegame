using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recegame
{
    internal class ClassVehicle
    {

    }
    abstract class Car
    {
        public int Place;
        private static Random _sharedRandom = new Random();

        public string StartEngine()
        {
            return "引擎啟動";
        }
        public string Stop()
        {
            return "引擎停止";
        }
        protected int GetRandomStep(int min, int max)
        {
            return _sharedRandom.Next(min, max);
        }
        abstract public int Run();

        abstract public int Turbo();

    }

    class Batmobile : Car 
    {
        Random RandomStep = new Random();
        int turbo;
        public override int Run()
        {
            int RunStep = GetRandomStep(1, 10);
            return RunStep;
        }

        public override int Turbo() 
        {
            int turbo = 10;
            return turbo;
        }
    }

    class Beetle : Car
    {
        Random RandomStep = new Random();
        int turbo;
        public override int Run()
        {
            int RunStep = GetRandomStep(1, 10);
            return RunStep;
        }

        public override int Turbo()
        {
            int turbo = 5;
            return turbo;
        }
    }
}
