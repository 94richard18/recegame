using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recegame
{
    abstract class Car
    {
        public int Step { set; get; }
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
        public string WeakPoint(int backwardStep)
        {
            Step -= backwardStep;

            if (Step < 0)
            {
                Step = 0;
            }
            return $"受到攻擊！後退 {backwardStep} 步。目前位置: {Step}";
        }
    }

    class Batmobile : Car 
    {
        Random RandomStep = new Random();
        int turbo;
        public override int Run()
        {
            int RunStep = GetRandomStep(1, 10);
            Step += RunStep;
            return Step;
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
            Step += RunStep;
            return Step;
        }

        public override int Turbo()
        {
            int turbo = 5;
            return turbo;
        }
    }
}
