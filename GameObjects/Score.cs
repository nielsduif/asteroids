using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asteroids.GameObjects
{
    class Score : TextGameObject
    {
        int score;
        public Score(string _assetName) : base(_assetName)
        {

        }

        public override void Update(GameTime gameTime)
        {
            text = score.ToString();
            base.Update(gameTime);
        }

        public void AddScore(int _amount)
        {
            score += _amount;
        }
    }
}
