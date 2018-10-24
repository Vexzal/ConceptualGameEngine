using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
namespace BaseEngine
{
    public class CoreGame : Game
    {
        public SpriteBatch spriteBatch;
        public GraphicsDeviceManager graphics;

        public CoreGame()
        {            
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        protected override void Initialize()
        {
            base.Initialize();
        }
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            base.LoadContent();
        }
        
    }
}
