using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using BaseEngine;

namespace ConceptualGame
{
    public class ConceptLayoutGameOne : CoreGame
    {
        //GraphicsDeviceManager graphics;
        //SpriteBatch spriteBatch;

        //the problem I'm stuck on now is that I need to access other components in an object
        //mainly transform
        //but I don't want to just shove a reference to the game object into components
        //unity has a function that gets a component like a service locator;
        //so I need to check how that, would work    

        //so have here like a scene, that we load
        //scene can be put together in the level editor
        //

        Model Cube;
        Matrix World;
        Matrix View;
        Matrix Projection;
        
        public ConceptLayoutGameOne()
        {
            //graphics = new GraphicsDeviceManager(this);
            //spriteBatch = new SpriteBatch(GraphicsDevice);
            //Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
           // spriteBatch = new SpriteBatch(GraphicsDevice);

            Cube = Content.Load<Model>("Cube");
            //position
            World = Matrix.Identity;
            //Camera
            Vector3 CameraPosition = Vector3.Transform(
                new Vector3(0, -10, 0),
                Matrix.CreateRotationX(MathHelper.ToRadians(-25)));

            View = Matrix.CreateLookAt(CameraPosition, Vector3.Zero, Vector3.UnitZ);

            //projection mapping
            float fov = MathHelper.ToRadians(30);
            float aspect = (float)graphics.PreferredBackBufferWidth / (float)graphics.PreferredBackBufferHeight;
            Projection = Matrix.CreatePerspectiveFieldOfView(fov, aspect, 1, 100);


            base.LoadContent();
        }

        protected override void UnloadContent()
        {
            base.UnloadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            //draw 3d assets
            //draw UI/2d assets 
            //draw debug content

            GraphicsDevice.Clear(new Color(1, .75f, .75f, 1));

            foreach(ModelMesh mesh in Cube.Meshes)
            {
                foreach(BasicEffect beffect in mesh.Effects)
                {
                    beffect.EnableDefaultLighting();
                    beffect.DiffuseColor = Color.White.ToVector3();
                    beffect.World = World;
                    beffect.View = View;
                    beffect.Projection = Projection;
                }
                mesh.Draw();
            }                        

            base.Draw(gameTime);
        }                
    }
}
