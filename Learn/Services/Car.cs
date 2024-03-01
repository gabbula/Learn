using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Services
{
    public abstract class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public abstract void Start();
        public abstract void Stop();

        public virtual void Drive()
        {
            Console.WriteLine("Driving...");
        }
    }
}
