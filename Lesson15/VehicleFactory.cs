using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{

    public interface IVehicle
    {
        void Drive();
    }
    
    public class Car : IVehicle 
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car");
        }
    }

    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a bike");
        }
    }

    public abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle();
    }

    public class CarFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        { 
            return new Car();
        }
    }

    public class BikeFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Bike();
        }
    }
}
