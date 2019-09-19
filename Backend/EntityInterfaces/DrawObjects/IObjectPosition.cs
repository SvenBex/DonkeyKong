using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Backend.EntityInterfaces.DrawObjects
{
    public interface IObjectPosition
    {
        Texture2D Texture { get; set; }
        Rectangle DestinationRectangle { get; set; }
    }
}
