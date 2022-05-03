using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Cuadrado : Figura
    {
        public Cuadrado(int lado) : base(lado, lado)
        {

        }
        public override int Perimetro()
        {
            return this._alto * 4;
        }

        public override int Superficie()
        {
            return this._alto * this._base;
        }

        public override string NombreFigura()
        {
            return "Cuadrado";
        }
    }
}
