using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace PointyClicker
{
    public static class SpriteBatchExtensions
    {
        private static Texture2D _pixel;

        private static Texture2D GetPixel(SpriteBatch spriteBatch)
        {
            if (_pixel == null)
            {
                _pixel = new Texture2D(spriteBatch.GraphicsDevice, 1, 1);
                _pixel.SetData(new[] { Color.White });
            }

            return _pixel;
        }

        public static void FillRectangle(this SpriteBatch spriteBatch, Rectangle rectangle, Color color)
        {
            spriteBatch.Draw(GetPixel(spriteBatch), rectangle, color);
        }

        public static void DrawLine(this SpriteBatch spriteBatch, Vector2 start, Vector2 end, Color color, int thickness = 1, float depth = 0)
        {
            var edge = end - start;
            var rotation = (float)MathF.Atan2(edge.Y, edge.X);
            var scale = new Vector2(edge.Length(), thickness);

            spriteBatch.Draw(GetPixel(spriteBatch), start, null, color, rotation, Vector2.Zero, scale, SpriteEffects.None, depth);
        }
    }
}
