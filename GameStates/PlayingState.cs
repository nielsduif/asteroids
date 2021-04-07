using Asteroids.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asteroids.GameStates
{
    //kogel op goede plek ipv midden van ss
    class PlayingState : GameObjectList
    {
        SpaceShip ss;
        GameObjectList bullets;
        GameObjectList rocks;
        Score score;
        public PlayingState()
        {
            Add(new SpriteGameObject("spr_background"));
            ss = new SpaceShip("spr_spaceship");
            Add(ss);
            bullets = new GameObjectList();
            Add(bullets);
            rocks = new GameObjectList();
            Add(rocks);
            for (int i = 0; i < 20; i++)
            {
                rocks.Add(new Rock("spr_rock1"));
            }
            score = new Score("GameFont");
            Add(score);
        }

        public override void Update(GameTime gameTime)
        {
            foreach (Rock r in rocks.Children)
            {
                for (int i = bullets.Children.Count - 1; i >= 0; i--)
                {
                    Bullet b = bullets.Children[i] as Bullet;
                    if (r.CollidesWith(b))
                    {
                        r.SizeMe();
                        bullets.Remove(b);
                        score.AddScore(10);
                    }
                }
                if (r.CollidesWith(ss))
                {
                    GameEnvironment.GameStateManager.SwitchTo("gameOverState");
                }
            }
            base.Update(gameTime);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            if (inputHelper.KeyPressed(Keys.Space))
            {
                bullets.Add(new Bullet("spr_bullet", ss.Position + (ss.AngularDirection * ss.Width * .5f), ss.AngularDirection * 300));
            }
            base.HandleInput(inputHelper);
        }
    }
}
