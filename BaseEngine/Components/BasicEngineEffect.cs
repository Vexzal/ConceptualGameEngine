using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace BaseEngine.Components
{
    public class BasicEngineEffect : Effect
    {
        public Color diffuseColor;

        public TransformComponent transform;
        public Matrix View;
        public Matrix Projection;


        BasicEngineEffect(Effect cloneSource)
            :base(cloneSource)
        {

        }

        public BasicEngineEffect(GraphicsDevice device):
            base(new BasicEffect(device))
        {

        }

        public override Effect Clone()
        {
            return new BasicEngineEffect(this);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void GraphicsDeviceResetting()
        {
            base.GraphicsDeviceResetting();
        }

        protected override void OnApply()
        {
            base.OnApply();
        }
    }
}
