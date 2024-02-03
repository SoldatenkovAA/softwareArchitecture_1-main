using Homework1.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.ModelElements
{
    public class Poligon
    {
        public Point3D Points;

        public Poligon() { 
            Points = new Point3D();
        }
        public Poligon(Point3D point) {
            Points = point;
        }
    }
}
