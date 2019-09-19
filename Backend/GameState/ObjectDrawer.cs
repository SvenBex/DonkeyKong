using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.GameState
{
    public class ObjectDrawer
    {
        public static void Draw(SpriteBatch spriteBatch, ObjectPositionRepository objectPositionRepository)
        {
            spriteBatch.Begin();

            DrawSolidObjects(spriteBatch, objectPositionRepository);
            DrawHostileObjects(spriteBatch, objectPositionRepository);
            DrawPlayerObjects(spriteBatch, objectPositionRepository);

            spriteBatch.End();
        }

        private static void DrawSolidObjects(SpriteBatch spriteBatch, ObjectPositionRepository objectPositionRepository)
        {
            foreach (var item in objectPositionRepository.GetSolidPositions())
            {
                spriteBatch.Draw(item.Texture, item.DestinationRectangle, item.SourceRectangle, item.Color, item.Rotation, item.Origin, item.Effects, item.LayerDepth);
            }
        }

        private static void DrawHostileObjects(SpriteBatch spriteBatch, ObjectPositionRepository objectPositionRepository)
        {
            foreach (var item in objectPositionRepository.GetHostilePositions())
            {
                spriteBatch.Draw(item.Texture, item.DestinationRectangle, item.SourceRectangle, item.Color, item.Rotation, item.Origin, item.Effects, item.LayerDepth);
            }
        }

        private static void DrawPlayerObjects(SpriteBatch spriteBatch, ObjectPositionRepository objectPositionRepository)
        {
            foreach (var item in objectPositionRepository.GetPlayerPositions())
            {
                spriteBatch.Draw(item.Texture, item.DestinationRectangle, item.SourceRectangle, item.Color, item.Rotation, item.Origin, item.Effects, item.LayerDepth);
            }
        }
    }
}
