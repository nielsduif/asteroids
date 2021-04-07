using Asteroids;
using Asteroids.GameStates;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BaseProject
{
    public class Asteroids : GameEnvironment
    {      
        protected override void LoadContent()
        {
            base.LoadContent();

            screen = new Point(800, 600);
            ApplyResolutionSettings();

            // TODO: use this.Content to load your game content here
            gameStateManager.AddGameState("playingState", new PlayingState());
            GameStateManager.AddGameState("gameOverState", new GameOverState());
            gameStateManager.SwitchTo("playingState");
        }
    }
}
