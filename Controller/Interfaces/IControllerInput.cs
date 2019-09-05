using System;
using System.Collections.Generic;
using System.Text;

namespace GameController.Interfaces
{
    public interface IControllerInput
    {
        bool MoveLeft();
        bool MoveRight();
        bool MoveUp();
        bool MoveDown();
    }
}
