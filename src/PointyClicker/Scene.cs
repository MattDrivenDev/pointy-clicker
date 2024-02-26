using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PointyClicker
{
    public class Scene
    {
        public Scene(PointyClickerGame game, string name)
        {
            Game = game;
            Name = name;

            LoadContent();
        }

        public PointyClickerGame Game { get; init; }

        public string Name { get; init; }

        public Texture2D Background { get; private set; }

        public void LoadContent()
        {
            Background = Game.Content.Load<Texture2D>($"scenes/{Name}/background");        
        }

        public void Update(GameTime gameTime)
        { 
        
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(Background, Vector2.Zero, Color.White);
        }
    }
}
