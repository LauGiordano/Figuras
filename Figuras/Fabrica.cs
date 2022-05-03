using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Fabrica
    {
        private List<Figura> lista;

        public Fabrica()
        {
            this.lista = new List<Figura>();
            agregarFiguras();
        }

        private void agregarFiguras()
        {

            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                int tipoFigura = rnd.Next(1, 5);
                int baseFigura = rnd.Next(1, 100);
                int altoFigura = rnd.Next(1, 100);

                switch (tipoFigura)
                {
                    case 1:
                        this.lista.Add(new Circulo(baseFigura));
                        break;
                    case 2:
                        this.lista.Add(new Triangulo(baseFigura, altoFigura));
                        break;
                    case 3:
                        this.lista.Add(new Rectangulo(baseFigura, altoFigura));
                        break;
                    case 4:
                        this.lista.Add(new Cuadrado(baseFigura));
                        break;
                    default:
                        break;
                }
            }
        }

        public void mostrarLista()
        {
            foreach (Figura figura in this.lista)
            {
                Console.WriteLine("El perimetro del " + figura.NombreFigura() + " es " + figura.Perimetro());
                Console.WriteLine("La superficie del " + figura.NombreFigura() + " es " + figura.Superficie());
            }
        }
    }
}
