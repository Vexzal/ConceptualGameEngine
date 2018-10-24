using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace BaseEngine.Components
{
    public class TransformComponent : Component
    {
        private TransformContainer transform;

        public TransformContainer Transform
        {
            get { return transform; }
        }

        public TransformComponent()            
        {
            transform = new TransformContainer();
            //position = Vector3.Zero;
            //Rotation = Quaternion.Identity; 
            //scale = Vector3.One;
        }
        public TransformComponent(GameObject _gameObject)
        {
            gameObject = _gameObject;
            transform = new TransformContainer();
        }
        public override void Initialize()
        {

        }
        public override void OnAddComponent()
        {

        }
    }
}
