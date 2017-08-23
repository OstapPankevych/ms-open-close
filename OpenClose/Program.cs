using System;
using System.Collections.Generic;
using OpenClose.Guns;
using OpenClose.Mechanisms;

namespace OpenClose
{
    class Program
    {
        public static MilitaryCar CreateOplot()
        {
            var gun = new TankGun();
            return new MilitaryCar(gun);
        }

        public static MilitaryCar CreateMilitaryB2M4Car()
        {
            var gun = new CannonGun();
            return new MilitaryCar(gun);
        }

        public static MilitaryCar CreateMilitaryHeliGunCar()
        {
            var gun = new HelicopterGun();
            return new MilitaryCar(gun);
        }

        static void Main(string[] args)
        {
            var militaryCars = new List<MilitaryCar>();
            militaryCars.Add(CreateOplot());
            militaryCars.Add(CreateMilitaryB2M4Car());
            militaryCars.Add(CreateMilitaryHeliGunCar());

            foreach (var militaryCar in militaryCars)
            {
                militaryCar.Attack();
            }

            Console.ReadLine();
        }
    }
}
