using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using BaseEngine;
using BaseEngine.Rendering;
using BaseEngine.Components;
namespace ConceptualGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : CoreGame
    {
        #region notes
        //I'd have here a big list of assets
        //models
        //shaders
        //textures
        //audio
        //animations

        //logical components
        //objects for specific things
        //other stuff
        //physics setup

        //physics world

        //rendering
        /** so the idea is you add every model 
         *  and it's effect and relevant effect properties
         *  to a list that the renderer steps through and renders.
         *  
         **/
        //physics
        /**
         *  like rendering but not like rendering.
         *  uhhhh
         *  yeah?
         *  alright so we have a collection of physics items that are added to the world
         *  that at least is straight forward enough
         **/
        //

        #endregion

        Scene gameScene;
        Assets _assets;
        RenderingModule renderer;
        public Game1() :
            base()
        {
            
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            gameScene = new Scene();
            renderer = new RenderingModule(this);
            renderer.Initialize();
            _assets = new Assets();
            base.Initialize();
        }

        Model Cube;
        Matrix World;
        Matrix View;
        Matrix Projection;

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            //need to load first before scene
            _assets.Load(Content);

            LoadScene();

            foreach(GameObject go in gameScene.gameObjects)
            {
                foreach(MeshComponent mesh in go.components.OfType<MeshComponent>())
                {
                    renderer.AddMesh(mesh);
                }
            }

            Cube = Content.Load<Model>("Cube");
            World = Matrix.CreateTranslation(Vector3.UnitZ * 2);

            float fov = MathHelper.ToRadians(30);
            float aspect = (float)graphics.PreferredBackBufferWidth / graphics.PreferredBackBufferHeight;
            Vector3 CameraPosition = Vector3.Transform(
                new Vector3(0, -10, 0),
                Matrix.CreateRotationX(MathHelper.ToRadians(35)));
            View = Matrix.CreateLookAt(CameraPosition, Vector3.Zero, Vector3.UnitZ);
            Projection = Matrix.CreatePerspectiveFieldOfView(fov, aspect, 1, 100);



            // TODO: use this.Content to load your game content here

            //load assets
            //initialize logical components
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            renderer.Update();

            // TODO: Add your update logic here
            //update logical components and render info
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CadetBlue);
            renderer.Draw();
            // TODO: Add your drawing code here
            //foreach(ModelMesh mesh in Cube.Meshes)
            //{
            //    foreach(BasicEffect beffect in mesh.Effects)
            //    {
            //        //beffect.DiffuseColor = Color.White.ToVector3();
            //        beffect.World = World;
            //        beffect.View = View;
            //        beffect.Projection = Projection;
            //    }
            //    mesh.Draw();
            //}
            //do all drawing

            base.Draw(gameTime);
        }

        

        void LoadScene()
        {
            gameScene = new Scene();
            GameObject CubeObject = new GameObject();
            CubeObject.name = "Cube";
            
            MeshComponent CubeMesh = new MeshComponent();
            CubeMesh.mesh = _assets.Cube;

            CubeObject.GetComponent<TransformComponent>().Transform.SetPosition(0, 0, 2);
            CubeObject.AddComponent(CubeMesh);

            GameObject PlaneObject = new GameObject();
            PlaneObject.name = "Plane";

            MeshComponent PlaneMesh = new MeshComponent();
            PlaneMesh.mesh = _assets.Plane;
            PlaneObject.AddComponent(PlaneMesh);

            gameScene.AddGameObject(CubeObject);
            gameScene.AddGameObject(PlaneObject);


        }
    }
}
