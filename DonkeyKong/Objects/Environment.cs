using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DonkeyKong.Objects
{
    public class Environment : NonMovableObject
    {
        public Environment(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth) 
            : base(texture, destinationRectangle, sourceRectangle, color, rotation, origin, scale, effects, layerDepth)
        {

        }
    }
}
