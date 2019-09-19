using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Backend.EntityInterfaces.DrawObjects
{
    public interface ITextureTransformation
    {
        float Rotation { get; set; }
        Vector2 Origin { get; set; }
        SpriteEffects Effects { get; set; }
        float LayerDepth { get; set; }
    }
}
