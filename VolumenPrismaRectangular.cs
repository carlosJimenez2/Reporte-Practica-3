using System;
using System.Collections.Generic;
using System.Text;

namespace Figuras
{
    class VolumenPrismaRectangular : VolumenCubo
    {
        public void Volumen(int LongitudLado, int Ancho, int Altura)
        {
            Console.WriteLine("El volumen del prima rectangular es: " + (LongitudLado * Ancho)* Altura);

        }
    }
}
