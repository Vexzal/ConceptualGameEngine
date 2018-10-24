using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using BaseEngine.Components;

namespace BaseEngine.Services
{
    [Obsolete]
    public class BasicRenderingService : Service
    {
        List<Model> modelMeshes;

        public override void AddComponent(Component component)
        {
            
            modelMeshes.Add(((MeshComponent)component).mesh);
        }

        //draw code don't know if this is actually needed.

    }
}
