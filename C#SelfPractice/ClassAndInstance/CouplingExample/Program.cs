using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouplingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            Car car = new Car(engine);
            car.Run(3);
            Console.WriteLine(car.Speed);
        }
    }

    class Engine
    { 
        //property
        public int RPM { get; private set; }

        //method
        public void Work(int gas)
        {
            this.RPM = 1000 * gas;
        }
    }

    class Car
    {
        //在Car 类的field里 有一个 Engine类的字段;
        //
        private Engine _engine;

        public Car(Engine engine)
        {
            _engine = engine;
        }

        public int Speed { get; private set; }

        public void Run(int gas)
        {
            _engine.Work(gas);
            this.Speed = _engine.RPM / 100;
        }
    }
}
