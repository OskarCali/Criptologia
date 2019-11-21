using System.Collections.Generic;

namespace Tent_Map.Function
{
    public class TentMap
    {
        public List<double> CoordsX { get; set; }
        public List<double> CoordsY { get; set; }
        public List<int> Binarios { get; set; }
        public double xm = 0.39912;


        public void tentMap(double p, double x, int iteracion)
        {
            CoordsX = new List<double>();
            CoordsY = new List<double>();
            Binarios = new List<int>();

            CoordsX.Add(0);
            CoordsY.Add(x);

            for (var i = 0; i < iteracion; i++)
            {
                if (x >= 0 && x <= xm)
                {
                    x = x / p;
                    Binarios.Add(0);
                }
                else if (x > xm && x <= 1)
                {
                    x = (1 - x) / (1 - p);
                    Binarios.Add(1);
                }

                CoordsX.Add((i + 1.0) / iteracion);
                CoordsY.Add(x);
            }
        }
    }
}