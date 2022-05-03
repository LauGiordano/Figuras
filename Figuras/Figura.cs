using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Figura
    {
        protected int _alto;
        protected int _base;

        public Figura(int ladoAltura, int ladoBase)
        {
            this._alto = ladoAltura;
            this._base = ladoBase;
        }

        public virtual int Superficie()
        {
            return 0;
        }

        public virtual int Perimetro()
        {
            return 0;
        }

        public virtual string NombreFigura()
        {
            return "Nombre";
        }
    }
}

