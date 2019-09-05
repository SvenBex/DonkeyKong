using DonkeyKong.Enums;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DonkeyKong.Objects
{
    public class HumanPlayer : MovableObject
    {
        public HumanPlayer(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
            :base(texture, destinationRectangle, sourceRectangle,color,rotation,origin,scale,effects,layerDepth)
        {
        }

        public override void NewPosition(DirectionInput input, int value)
        {
            switch (input)
            {
                case DirectionInput.UP:
                    MoveY(value);
                    break;
                case DirectionInput.DOWN:
                    MoveY(value);
                    break;
                case DirectionInput.LEFT:
                    MoveX(value);
                    break;
                case DirectionInput.RIGHT:
                    MoveX(value);
                    break;
                case DirectionInput.JUMP:
                    break;
                default:
                    break;
            }

        }
    }
}
