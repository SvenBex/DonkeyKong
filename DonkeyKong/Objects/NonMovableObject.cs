using DonkeyKong.Enums;
using DonkeyKong.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DonkeyKong.Objects
{
    public abstract class NonMovableObject : IDrawObject
    {
        protected NonMovableObject(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
        {
            Texture = texture;
            DestinationRectangle = destinationRectangle;
            SourceRectangle = sourceRectangle;
            Color = color;
            Rotation = rotation;
            Origin = origin;
            Scale = scale;
            Effects = effects;
            LayerDepth = layerDepth;
        }
        public Texture2D Texture { get; set; }
        public Rectangle DestinationRectangle { get; set; }
        public Rectangle? SourceRectangle { get; set; }
        public Color Color { get; set; }
        public float Rotation { get; set; }
        public Vector2 Origin { get; set; }
        public Vector2 Scale { get; set; }
        public SpriteEffects Effects { get; set; }
        public float LayerDepth { get; set; }
    }
}
