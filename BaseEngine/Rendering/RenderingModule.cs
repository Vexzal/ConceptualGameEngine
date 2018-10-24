using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseEngine;
using BaseEngine.Components;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BaseEngine.Rendering
{
    public class RenderingModule
    {
        CoreGame game;
        int cameraIndex;
        List<MeshComponent> meshEntities = new List<MeshComponent>();
        List<Model> models = new List<Model>();
        //camera list List<Camera> cameras = new List<Camera>();
        List<MeshComponent> drawEntities = new List<MeshComponent>();
        //debug values
        Matrix View;
        Matrix Projection;
        BoundingFrustum cameraFrustrum;
        public RenderingModule(CoreGame _game)
        {
            game = _game;
        }
        public void Initialize()
        {
            
            Vector3 cameraPosition =
                Vector3.Transform(
                    new Vector3(0,-30,0),
                    Matrix.CreateRotationX(MathHelper.ToRadians(-15)));

            float fov = MathHelper.ToRadians(30);
            //float aspect = game.GraphicsDevice.Adapter.CurrentDisplayMode.AspectRatio;
            float aspect = (float)game.graphics.PreferredBackBufferWidth / game.graphics.PreferredBackBufferHeight;
            View = Matrix.CreateLookAt(cameraPosition, Vector3.Zero, Vector3.UnitZ);
            Projection = Matrix.CreatePerspectiveFieldOfView(fov, aspect, 1, 100);
            cameraFrustrum = new BoundingFrustum(View * Projection);
        }
        void UpdateLists()
        {
            //models = meshEntities.Select(o => o.mesh).ToList();
        }
        public void Clean()
        {
            meshEntities = new List<MeshComponent>();
            models = new List<Model>();
        }
        public void AddMesh(MeshComponent entity)
        {
            meshEntities.Add(entity);
            
        }
        public void AddMeshGroup(List<MeshComponent> entityList)
        {
            meshEntities.AddRange(entityList);
        }

        public void Update()
        {
            //models.Clear();
            drawEntities.Clear();

            
            foreach(MeshComponent component in meshEntities)
            {
                foreach(ModelMesh mesh in component.mesh.Meshes)
                {
                    if (cameraFrustrum.Intersects(mesh.BoundingSphere))
                    {
                        //models.Add(component.mesh);
                        drawEntities.Add(component);
                        break;
                    }
                }
            }
        }

        public void Draw()
        {
            int leaveneltFortnight;
            foreach(MeshComponent model in drawEntities)
            {
                DrawModel(model.mesh, model.Transform);
            }

        }
        public void DrawModel(Model model, TransformContainer container)
        {
            foreach(ModelMesh mesh in model.Meshes)
            {
                foreach(BasicEffect effect in mesh.Effects)
                {
                    effect.DiffuseColor = Color.Red.ToVector3();
                    effect.EnableDefaultLighting();
                    effect.World = container.GetWorld();
                    effect.View = View;
                    effect.Projection = Projection;
                }
                mesh.Draw();
            }
        }
        
    }
}
