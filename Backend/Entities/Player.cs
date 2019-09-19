using Backend.EntityInterfaces.GameLogic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Entities
{
    public class Player : IPlayer
    {
        public int PlayerLives { get; set; }
        public int Id { get; set; }
        public Texture2D Texture { get; set; }
        public Rectangle DestinationRectangle { get; set; }
        public Rectangle? SourceRectangle { get; set; }
        public Color Color { get; set; }
        public float Rotation { get; set; }
        public Vector2 Origin { get; set; }
        public SpriteEffects Effects { get; set; }
        public float LayerDepth { get; set; }
    }
}
