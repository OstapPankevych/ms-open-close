using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClose.Guns;

namespace OpenClose.Mechanisms
{
    class MilitaryCar
    {
        private Gun _gun;

        public MilitaryCar(Gun gun)
        {
            _gun = gun;
        }

        public void Attack()
        {
            _gun.Attack();
        }
    }
}
