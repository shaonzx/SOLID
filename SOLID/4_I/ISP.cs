using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_I
{
    /**
     * A classed should not be forced to implement interfaces that it doesn't use.
     */

    public interface IVehicle
    {
        public void Drive();
        public void Fly();
    }

    // this one is good
    public class FlyingCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Drive");
        }

        public void Fly()
        {
            Console.WriteLine("Fly");
        }
    }

    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Drive");
        }

        // Cars doesn't fly....... violation of ISP
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }

    /**
     * In order of escape this violation we can segregate the interface in two interfaces
     * public interface Drivables{ public void Drive(); }
     * public interface Flyables{ public void Fly(); }
     *
     * Then Car can implement Drivables, FlyingCar can implement Flyables.
     *
     */

    internal class ISP
    {
        public void RunningTheShow()
        {

        }
    }
}
