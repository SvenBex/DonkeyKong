using Backend.EntityInterfaces.GameLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.GameState
{
    public class ObjectPositionRepository
    {
        private List<IPlayer> PlayerPositions { get; set; }
        private List<IHostile> HostilePositions { get; set; }
        private List<ISolid> SolidPositions { get; set; }

        private ObjectPositionRepository()
        {
            PlayerPositions = new List<IPlayer>();
            HostilePositions = new List<IHostile>();
            SolidPositions = new List<ISolid>();
        }

        public static ObjectPositionRepository InitializeRepository()
        {
            return new ObjectPositionRepository();
        }

        public List<IPlayer> GetPlayerPositions()
        {
            return PlayerPositions;
        }

        public void AddPlayerPosition(IPlayer player)
        {
            PlayerPositions.Add(player);
        }

        public void UpdatePlayerPosition(IPlayer player)
        {
            var newList = PlayerPositions.Where(x => x.Id != player.Id).ToList();
            newList.Add(player);
            PlayerPositions = newList;
        }

        public List<IHostile> GetHostilePositions()
        {
            return HostilePositions;
        }

        public void AddHostilePosition(IHostile hostile)
        {
            HostilePositions.Add(hostile);
        }

        public void UpdateHostilePosition(IHostile hostile)
        {
            var newList = HostilePositions.Where(x => x.Id != hostile.Id).ToList();
            newList.Add(hostile);
            HostilePositions = newList;
        }

        public List<ISolid> GetSolidPositions()
        {
            return SolidPositions;
        }

        public void AddSolidPosition(ISolid solid)
        {
            SolidPositions.Add(solid);
        }

        public void UpdateSolidPosition(ISolid solid)
        {
            var newList = SolidPositions.Where(x => x.Id != solid.Id).ToList();
            newList.Add(solid);
            SolidPositions = newList;
        }
    }
}
