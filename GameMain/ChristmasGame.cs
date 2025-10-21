using Engine;
using GameMain.GameStates;
using System;

namespace GameMain
{
    public class ChristmasGame : ExtendedGame
    {
        public const string Key_StartState = "startState";

        [STAThread]
        static void Main()
        {
            ChristmasGame game = new ChristmasGame();
            game.Run();
        }

        public ChristmasGame()
        {
            GameStateManager.AddGameState(new StartState(GameStateManager), Key_StartState);
            GameStateManager.SwitchState(Key_StartState);
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            base.LoadContent();
        }
    }
}
