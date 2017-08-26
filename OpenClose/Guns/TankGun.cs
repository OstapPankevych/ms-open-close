using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose.Guns
{
    public class TankGun: Gun
    {
        public override void Attack()
        {
 	        Console.WriteLine("Attack from tank's gun");
        }
    }
}
