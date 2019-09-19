using Backend.EntityInterfaces.DrawObjects;
using Backend.EntityInterfaces.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.EntityInterfaces.GameLogic
{
    public interface IHostile : IIdentifiable, IDraw
    {
        //If true, player loses lives on touch
        bool ObjectIsHostile { get; set; }
    }
}
