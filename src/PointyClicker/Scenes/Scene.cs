using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace PointyClicker.Scenes
{
    public abstract class Scene
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

        public abstract List<Vector2> Bounds { get; init; }

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

            if (Game.Debug)
            {
                // Draw lines around the bounds
                for (int i = 0; i < Bounds.Count; i++)
                {
                    var start = Bounds[i];
                    var end = Bounds[(i + 1) % Bounds.Count];

                    spriteBatch.DrawLine(start, end, Color.Red, 2);
                }
            }            
        }
    }
}
