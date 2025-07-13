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
    public class Car
    {
        public string model; 
        public int CC;  
        public decimal price; 

        public string StartEngine()
        {
            return "引擎啟動";
        }
        public string Stop()
        {
            return "引擎停止";
        }
       // abstract public string Run();

        //abstract public string Turbo();

    }
}
