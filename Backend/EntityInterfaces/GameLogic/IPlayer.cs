using Backend.EntityInterfaces.DrawObjects;
using Backend.EntityInterfaces.Entity;

namespace Backend.EntityInterfaces.GameLogic
{
    public interface IPlayer : IIdentifiable, IDraw
    {
        //If zero, player ded
        int PlayerLives { get; set; }
    }
}
