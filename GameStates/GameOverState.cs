using System;
using System.Collections.Generic;
using System.Text;

namespace Asteroids.GameStates
{
    class GameOverState : GameObjectList
    {
        public GameOverState()
        {
            Add(new SpriteGameObject("spr_gameover"));
        }
    }
}
