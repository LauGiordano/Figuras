using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Circulo : Figura
    {
        public Circulo(int radio)
            : base(radio, 0)
        {

        }
        public override int Perimetro()
        {
            return this._alto * 2 * 3; //Math.PI es double
        }

        public override int Superficie()
        {
            return this._alto * this._alto * 3;
        }

        public override string NombreFigura()
        {
            return "Círculo";
        }
    }
}
