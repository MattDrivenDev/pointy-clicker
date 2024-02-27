using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace PointyClicker.Scenes
{
    public class Room : Scene
    {
        public Room(PointyClickerGame game) : base(game, "room")
        {
            Bounds.Add(new Vector2(145, 540));
            Bounds.Add(new Vector2(824, 540));
            Bounds.Add(new Vector2(1000, 760));
            Bounds.Add(new Vector2(10, 760));
        }

        public override List<Vector2> Bounds { get; init; } = new();
    }
}
