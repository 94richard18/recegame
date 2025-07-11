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
        public string model; 
        public int CC;  
        public decimal price; 

        public string Start()
        {
            return $"引擎啟動";
        }

        abstract public string run();

    }
}
