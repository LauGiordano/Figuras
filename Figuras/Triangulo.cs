using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Triangulo : Figura
    {
        public Triangulo(int ladoBase, int ladosAltura)
            : base(ladoBase, ladosAltura)
        {

        }
        public override int Perimetro()
        {
            return this._alto * 2 + this._base;
        }

        public override int Superficie()
        {
            return (this._alto * this._base) / 2;
        }

        public override string NombreFigura()
        {
            return "Triángulo";
        }
    }
}
