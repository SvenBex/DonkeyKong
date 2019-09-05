using GameController.Interfaces;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameController.KeyboardController
{
    public class NonInvertedKeyboardBehaviour : IControllerInput
    {
        public bool MoveDown()
        {
            return Keyboard.GetState().IsKeyDown(Keys.Down) || Keyboard.GetState().IsKeyDown(Keys.S);
        }

        public bool MoveLeft()
        {
            return Keyboard.GetState().IsKeyDown(Keys.Left) || Keyboard.GetState().IsKeyDown(Keys.A);
        }

        public bool MoveRight()
        {
            return Keyboard.GetState().IsKeyDown(Keys.Right) || Keyboard.GetState().IsKeyDown(Keys.D);
        }

        public bool MoveUp()
        {
            return Keyboard.GetState().IsKeyDown(Keys.Up) || Keyboard.GetState().IsKeyDown(Keys.W);
        }
    }
}
