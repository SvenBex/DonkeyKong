using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DonkeyKong.Interfaces
{
    public interface IDrawObject
    {
        Texture2D Texture { get; set; }
        Rectangle DestinationRectangle { get; set; }
        Rectangle? SourceRectangle { get; set; }
        Color Color { get; set; }
        float Rotation { get; set; }
        Vector2 Origin { get; set; }
        Vector2 Scale{ get; set; }
        SpriteEffects Effects { get; set; }
        float LayerDepth { get; set; }
    }
}
