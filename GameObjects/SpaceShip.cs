using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asteroids.GameObjects
{
    class SpaceShip : RotatingSpriteGameObject
    {
        public SpaceShip(string _assetName) : base(_assetName)
        {
            origin = Center;
            position = GameEnvironment.Screen.ToVector2() * .5f;
        }

        public override void Update(GameTime gameTime)
        {
            WrapScreen();
            base.Update(gameTime);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            if (inputHelper.IsKeyDown(Keys.Up))
            {
                velocity += AngularDirection * 5;
            }
            if (inputHelper.IsKeyDown(Keys.Down))
            {
                velocity -= AngularDirection * 5;
            }
            if (inputHelper.IsKeyDown(Keys.Left))
            {
                Degrees -= 4;
            }
            if (inputHelper.IsKeyDown(Keys.Right))
            {
                Degrees += 4;
            }
            base.HandleInput(inputHelper);
        }

        void WrapScreen()
        {
            if (position.X - sprite.Width * .5f > GameEnvironment.Screen.X)
            {
                position.X = -sprite.Width;
            }
            if (position.X + sprite.Width * .5f < -sprite.Width)
            {
                position.X = GameEnvironment.Screen.X + sprite.Width * .5f;
            }
            if (position.Y - sprite.Height * .5f > GameEnvironment.Screen.Y)
            {
                position.Y = -sprite.Height;
            }
            if(position.Y + sprite.Width * .5f < -sprite.Height)
            {
                position.Y = GameEnvironment.Screen.Y + sprite.Height * .5f;
            }
        }
    }
}
