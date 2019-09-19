using Backend.EntityInterfaces.DrawObjects;
using Backend.EntityInterfaces.Entity;

namespace Backend.EntityInterfaces.GameLogic
{
    public interface ISolid : IIdentifiable, IDraw
    {
        //If true, other objects can't pass through this object
        bool ObjectIsSolid { get; set; }
    }
}
