using GameController.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.GameState
{
    public class MovementBehaviour
    {
        private const int MOVEMENTINTERVAL = 5;

        public static void UpdateObjectPositions(ObjectPositionRepository objectPositionRepository, IControllerInput controllerInput)
        {
            UpdatePlayerPositions(objectPositionRepository, controllerInput);
        }

        private static void UpdatePlayerPositions(ObjectPositionRepository objectPositionRepository, IControllerInput controllerInput)
        {
            foreach (var player in objectPositionRepository.GetPlayerPositions())
            {
                if (controllerInput.MoveLeft())
                {
                    player.Effects = SpriteEffects.FlipHorizontally;

                    Rectangle newPosition = player.DestinationRectangle;
                    newPosition.X -= MOVEMENTINTERVAL;

                    if (!CollidedWithSolidObject(objectPositionRepository, newPosition))
                    {
                        player.DestinationRectangle = newPosition;
                    }
                }

                if (controllerInput.MoveRight())
                {
                    player.Effects = SpriteEffects.None;

                    Rectangle newPosition = player.DestinationRectangle;
                    newPosition.X += MOVEMENTINTERVAL;

                    if (!CollidedWithSolidObject(objectPositionRepository, newPosition))
                    {
                        player.DestinationRectangle = newPosition;
                    }
                }
            }
        }

        private static bool CollidedWithSolidObject(ObjectPositionRepository objectPositionRepository, Rectangle toBePosition)
        {
            var solidObjectRectangles = objectPositionRepository.GetSolidPositions().Select(x => x.DestinationRectangle);

            foreach (var solidObject in solidObjectRectangles)
            {
                if (toBePosition.Intersects(solidObject))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
