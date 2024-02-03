using Homework1.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.ModelElements
{
    public class PoligonalModel
    {
        public List<Poligon> Poligons;
        public List<Texture> Textures;

        public PoligonalModel(List<Texture> textures)
        {
            Textures = textures;
            Poligons = new List<Poligon>();
            Poligon poligon = new Poligon();
            Poligons.Add(poligon);
        }

        public PoligonalModel(List<Texture> textures, Point3D point)
        {
            this.Textures = textures;
            Poligons = [new Poligon(point)];
        }
    }
}
