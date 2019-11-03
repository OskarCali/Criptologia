using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henon
{
    class Henon
    {
        public double xm = 0.39912;
        public double ym = 0.11977;

        public string henon(double xi, double yi, int repeticiones = 1)
        {
            List<int> binarios = new List<int>();
            double x;
            double y;

            for (int i = 0; i < repeticiones; i++)
            {
                x = yi + 1 - (1.4 * Math.Pow(xi, 2));
                y = 0.3 * xi;

                binarios.Add(x <= xm ? 0 : 1);
                binarios.Add(y <= ym ? 0 : 1);

                xi = x;
                yi = y;
            }

            string s = binarios.Aggregate<int, string>(String.Empty, (v1, v2) => v1.ToString() + v2.ToString());

            return s;
        }

        public string igualar(string cad1, string cad2)
        {
            while (cad2.Length < cad1.Length)
            {
                cad2 += cad2;
            }

            cad2 = cad2.Substring(0, cad1.Length);

            return cad2;
        }
    }
}
