using Homework1.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.ModelElements
{
    public class Scene
    {
        public int Id;
        public List<PoligonalModel> Models;
        public List<Flash> Flashes;
        public List<Camera> Cameras;

        public Scene(int id ,List<PoligonalModel> poligonalModels, List<Flash> flashes, List<Camera> cameras) {
            if (poligonalModels.Count == 0 || cameras.Count == 0)
            {
                throw new ArgumentException("У данных коллекций должен быть хотя бы один аргумент!");
            }
            Models = poligonalModels;
            Cameras = cameras;
            Flashes = flashes;
            Id = id;
        }

        public List<Camera> GetCamerasWithAngle(Angle3D Angle)
        {
            List<Camera> answer = new List<Camera>();
            for (int i = 0; i < Cameras.Count; i++)
            {
                if (Cameras[i].Angle.angle == Angle.angle)
                {
                    answer.Add(Cameras[i]);
                }
            }
            return answer;
        } 
        
        public List<Flash> GetFlashesWithPoints(double x, double y)
        {
            List<Flash> answer = new List<Flash>();
            for (int i = 0; i < Flashes.Count; i++)
            {
                if (Flashes[i].Location.x == x && Flashes[i].Location.y == y)
                {
                    answer.Add(Flashes[i]);
                }
            }
            return answer;
        }
    }
}
