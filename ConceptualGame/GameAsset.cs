using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseEngine;
using BaseEngine.Components;

namespace ConceptualGame
{
    class GameAsset
    {
        Scene GameScene;
        public GameAsset()
        {
            GameScene = new Scene();
        }
        public void load()
        {
            GameObject Cube = new GameObject();
            Cube.name = "Cube";
            //need a mesh component
            //need a physics component
            
        }
    }
}
