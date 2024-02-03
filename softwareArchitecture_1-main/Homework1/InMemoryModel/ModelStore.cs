using Homework1.ModelElements;
using Homework1.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.InMemoryModel
{
    public class ModelStore : IModelChanger
    {
        public List<PoligonalModel> PoligonalModels;
        public List<Flash> Flashes;
        public List<Camera> Cameras;
        public List<Scene> Scenes;
        private List<IModelChangedObserver> changeObservers;

        public ModelStore(List<IModelChangedObserver> modelChangedObserver)
        {
            changeObservers = modelChangedObserver;

            PoligonalModels = new List<PoligonalModel>();
            Flashes = new List<Flash>();
            Cameras = new List<Camera>();
            Scenes = new List<Scene>();

            PoligonalModels.Add(new PoligonalModel(null));
            Flashes.Add(new Flash());
            Cameras.Add(new Camera());
            Scenes.Add(new Scene(0, PoligonalModels, Flashes, Cameras));
        }

        public Scene GetScene(int n) {  return Scenes[n]; }

        void IModelChanger.NotifyChange(IModelChanger sender)
        {
            throw new NotImplementedException();
        }
    }
}
