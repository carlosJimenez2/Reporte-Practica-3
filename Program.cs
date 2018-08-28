using System;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            VolumenCubo Cubo = new VolumenCubo();

            Cubo.Volumen(10);

            VolumenPrismaRectangular PrismaRectangular = new VolumenPrismaRectangular();

            PrismaRectangular.Volumen(10,3,6);


            Console.ReadKey();

        }
        
    }
}
