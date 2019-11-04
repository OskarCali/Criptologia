using System;
using System.Collections.Generic;
using System.Linq;

namespace Henon
{
    internal class Henon
    {
        public double xm = 0.39912;
        public double ym = 0.11977;

        /// <summary>
        ///     Metodo para generar numeros pseudoaleatorios usando Henon y generar llave binaria
        /// </summary>
        /// <param name="xi">Valor inicial de la semilla en x</param>
        /// <param name="yi">Valor inicial de la semilla en y</param>
        /// <param name="repeticiones">Cantidad de repeticiones para generar los numeros</param>
        /// <returns>Cadena binaria que representa a la llave</returns>
        public string henon(double xi, double yi, int repeticiones = 1)
        {
            var binarios = new List<int>();
            double x, y;

            for (var i = 0; i < repeticiones; i++)
            {
                x = yi + 1 - 1.4 * Math.Pow(xi, 2);
                y = 0.3 * xi;

                binarios.Add(x <= xm ? 0 : 1);
                binarios.Add(y <= ym ? 0 : 1);

                xi = x;
                yi = y;
            }

            return binarios.Aggregate(string.Empty, (v1, v2) => v1.ToString() + v2);
        }
    }
}