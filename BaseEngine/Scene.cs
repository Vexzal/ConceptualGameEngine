using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEngine
{
    public class Scene
    {
        public string name;
        public List<GameObject> gameObjects = new List<GameObject>();

        //event system.

        public Scene()
        {

        }
        public void AddGameObject(GameObject gameObj)
        {
            gameObjects.Add(gameObj);
        }
        public void RemoveGameObject(GameObject gameObj)
        {
            gameObjects.Remove(gameObj);
        }

        
    }
}
