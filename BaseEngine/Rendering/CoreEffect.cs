using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace BaseEngine.Components
{
    public class CoreEffect : Effect
    {
        public TransformContainer transform;

        public CoreEffect(Effect cloneSource)
            :base(cloneSource)
        {

        }
        public CoreEffect(GraphicsDevice device, byte[] effectCode)
            : base(device, effectCode)
        {

        }
        public CoreEffect(GraphicsDevice device, byte[] effectCode, int index, int count)
            :base(device,effectCode,index,count)
        {

        }

        public override Effect Clone()
        {
            return base.Clone();
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
