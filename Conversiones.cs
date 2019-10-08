using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor
{
    class Conversiones //en esta clase se realizan las operaciones correspondientes
    {
        Unidad u = new Unidad();
        public double CentrimetrosMetros(Unidad u)
        {
            Console.WriteLine();
            Console.WriteLine("Capture los centimetros que desea convertir");
            u.X = Convert.ToDouble(Console.ReadLine());
            var res = u.X / 100;
            return res;

        }
        public double MetrosPulgadas(Unidad u)
        {
            Console.WriteLine();
            Console.WriteLine("Capture los metros que desea convertir");
            u.X = Convert.ToDouble(Console.ReadLine());
            var res = u.X * 39;
            return res;
        }
        public double MililitrosLitros(Unidad u)
        {
            Console.WriteLine();
            Console.WriteLine("Capture los mililitros que desea convertir");
            u.X = Convert.ToDouble(Console.ReadLine());
            var res = u.X / 1000;
            return res;
        }
    }
}
