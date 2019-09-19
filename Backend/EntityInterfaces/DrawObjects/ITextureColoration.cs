using Microsoft.Xna.Framework;

namespace Backend.EntityInterfaces.DrawObjects
{
    public interface ITextureColoration
    {
        Rectangle? SourceRectangle { get; set; }
        Color Color { get; set; }
    }
}
