using Backend.EntityInterfaces.GameLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.GameState
{
    public class GameRules
    {
        public static void CheckGameRules(ObjectPositionRepository objectPositionRepository)
        {
            If_Hostile_Touch_Then_Lose_Player_Life(objectPositionRepository);
            //etc...
        }

        private static void If_Hostile_Touch_Then_Lose_Player_Life(ObjectPositionRepository objectPositionRepository)
        {
            var players = objectPositionRepository.GetPlayerPositions();
            var hostiles = objectPositionRepository.GetHostilePositions();

            var hostileRectangles = hostiles.Select(x => x.DestinationRectangle);
            var playersHit = new List<IPlayer>();

            foreach (var player in players)
            {
                foreach (var hostile in hostileRectangles)
                {
                    if (player.DestinationRectangle.Intersects(hostile))
                    {
                        player.PlayerLives -= 1;
                        //TODO Rename 'position', these are more than just the positions
                        objectPositionRepository.UpdatePlayerPosition(player);
                        break;
                    }
                }
            }
        }

        //etc...
    }
}
