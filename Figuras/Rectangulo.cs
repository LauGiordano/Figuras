using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Rectangulo : Figura
    {
        public Rectangulo(int ladoBase, int ladoAltura)
            : base(ladoBase, ladoAltura)
        {

        }
        public override int Perimetro()
        {
            return this._alto * 2 + this._base * 2;
        }

        public override int Superficie()
        {
            return this._alto * this._base;
        }

        public override string NombreFigura()
        {
            return "Rectángulo";
        }
    }
}
