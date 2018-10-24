using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace ConceptualGame
{
    class Assets
    {
        public Model Cube;
        public Model Plane;
        public Model Torus;
        
        public Assets()
        {

        }
        public void Load(ContentManager Content)
        {
            Cube  = Content.Load<Model>("Cube");
            Plane = Content.Load<Model>("Plane");
            Torus = Content.Load<Model>("Torus");
        }
    }
}
