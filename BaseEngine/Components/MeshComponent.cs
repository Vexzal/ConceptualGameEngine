using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BaseEngine.Components
{
    public class MeshComponent : Component
    {
        public Model mesh;
        CoreEffect effect;
        TransformContainer transform;

        public TransformContainer Transform
        {
            get { return transform; }
        }

        public MeshComponent()
        {
                
        }
        
        //public void Instantiate()
        //{
        //    transform = gameObject.GetComponent<TransformComponent>().Transform;
        //}
        public override void Initialize()
        {
            transform = gameObject.GetComponent<TransformComponent>().Transform;
        }
        //rethink this maybe?
        //a lot of components might not need to be added to a service
        //transform doesn't
        //render and physics do but they only need to be added to a specific service
        //
        public override void OnAddComponent()
        {
           //need to pass something here that 
        }
    }
}
