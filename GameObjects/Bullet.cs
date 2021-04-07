using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asteroids.GameObjects
{
    class Bullet : SpriteGameObject
    {
        public Bullet(string _assetName, Vector2 _pos, Vector2 _vel) : base(_assetName)
        {
            position = _pos;
            velocity = _vel;
        }
    }
}
