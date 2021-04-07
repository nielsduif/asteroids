using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Asteroids.GameObjects
{
    class Rock : SpriteGameObject
    {
        string[] sprites = { "spr_rock1", "spr_rock2", "spr_rock3" };
        int size;
        public Rock(string _assetName) : base(_assetName)
        {
            position = new Vector2(GameEnvironment.Random.Next(-sprite.Width, GameEnvironment.Screen.X), GameEnvironment.Random.Next(-sprite.Height, GameEnvironment.Screen.Y));
            velocity = position * .1f;
            if (GameEnvironment.Random.NextDouble() > .5f)
            {
                velocity *= -1;
            }
            size = GameEnvironment.Random.Next(0, sprites.Length);
            sprite = new SpriteSheet(sprites[size]);
        }

        public void SizeMe()
        {
            if (size > 0)
            {
                sprite = new SpriteSheet(sprites[size - 1]);
                size--;
            }
            else
            {
                visible = false;
            }
        }

        public override void Update(GameTime gameTime)
        {
            WrapScreen();
            base.Update(gameTime);
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
            if (position.Y + sprite.Width * .5f < -sprite.Height)
            {
                position.Y = GameEnvironment.Screen.Y + sprite.Height * .5f;
            }
        }
    }
}
